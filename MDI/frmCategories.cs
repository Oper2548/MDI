using Microsoft.Data.SqlClient;
using System.Data;

namespace WinFormMiniMart
{
    public partial class frmCategories : Form
    {
        public frmCategories()
        {
            InitializeComponent();
            this.Load += FrmCategories_Load;
            dgvCategories.CellMouseUp += DgvCategories_CellMouseUp;
        }

        private void DgvCategories_CellMouseUp(object? sender, DataGridViewCellMouseEventArgs e)
        {
            txtCategoryID.Text = dgvCategories.CurrentRow.Cells["CategoryID"].Value.ToString();
            txtCategoryName.Text = dgvCategories.CurrentRow.Cells["CategoryName"].Value.ToString();
            txtDescription.Text = dgvCategories.CurrentRow.Cells["Description"].Value.ToString();
        }

        SqlConnection conn;
        SqlDataAdapter da;
        SqlCommand cmd;

        private void FrmCategories_Load(object? sender, EventArgs e)
        {
            conn = connDB.ConnectMinimart();
            showdata();
            txtCategoryID.Enabled = false;
        }

        private void showdata()
        {
            string sql = "Select * from Categories";
            cmd = new SqlCommand(sql, conn);
            da = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            dgvCategories.DataSource = dataSet.Tables[0];
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            txtCategoryID.Text = string.Empty;
            txtCategoryName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtCategoryName.Focus();
            txtCategoryID.Enabled = false;
        }

        private void btninsert_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtCategoryName.Text))
            {
                MessageBox.Show("กรุณาข้อมูลที่ต้องการจะเพิ่มก่อน");
                return;
            }

            string sql = "Insert into Categories values (@categroyName,@Description)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@categroyName", txtCategoryName.Text.Trim());
            cmd.Parameters.AddWithValue("@Description", txtDescription.Text.Trim());

            if (cmd.ExecuteNonQuery() > 0)
            {
                showdata();
                btnClearForm.PerformClick();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategoryID.Text))
            {
                MessageBox.Show("กรุณาเลือกข้อมูลก่อน");
                return;
            }
            if (string.IsNullOrEmpty(txtCategoryName.Text))
            {
                MessageBox.Show("ชื่อประเภทสินค้าต้องว่าง");
                return;
            }

            string sql = "Update Categories set CategoryName = @categroyName, Description = @Description where CategoryID = @categoryID";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@categoryID", txtCategoryID.Text.Trim());
            cmd.Parameters.AddWithValue("@categroyName", txtCategoryName.Text.Trim());
            cmd.Parameters.AddWithValue("@Description", txtDescription.Text.Trim());


            if (cmd.ExecuteNonQuery() > 0)
            {
                showdata();
                btnClearForm.PerformClick();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategoryID.Text))
            {
                MessageBox.Show("กรุณาเลือกข้อมูล");
                return;
            }
            if (MessageBox.Show("ต้องการลบข้อมูล?", "โปรดยืนยัน", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            string sql = "delete from Categories where CategoryID = @categoryID";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@categoryID", txtCategoryID.Text.Trim());
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    showdata();
                    btnClearForm.PerformClick();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("เกิดข้อผิดพลาด :" + Environment.NewLine + ex.Message, "ไม่สามารถลบข้อมูลได้");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmInsertUpdateCategories f = new FrmInsertUpdateCategories();
            f.status = "insert";
            f.ShowDialog();
            showdata();
        }

        private void dgvCategories_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FrmInsertUpdateCategories f = new FrmInsertUpdateCategories();
            f.status = "update";
            var dgv = dgvCategories.CurrentRow.Cells;
            f.categoryID = Convert.ToInt16(dgv["CategoryID"].Value);
            f.categoryName = dgv["CategoryName"].Value.ToString();
            f.description = dgv["Description"].Value.ToString();
            f.ShowDialog();
            showdata();
        }
    }
}
