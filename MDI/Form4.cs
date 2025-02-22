using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormMiniMart
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int CategoryID { get; set; }
        public bool Discontinued { get; set; }
        public string status { get; set; }

        SqlConnection conn;
        SqlDataAdapter da;
        SqlCommand cmd;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                conn = connDB.ConnectMinimart();
                numUD_UnitsInStock.Minimum = 0;
                numUD_UnitsInStock.Maximum = 10000;
                numUD_UnitsInStock.Value = 100;

                LoadCategories();

                txtProductID.Text = ProductID;
                txtProductName.Text = ProductName;
                laka.Text = UnitPrice.ToString();
                numUD_UnitsInStock.Value = UnitsInStock;
                cmbCategoryID.SelectedValue = CategoryID;
                cmbDiscontinued.SelectedIndex = Discontinued ? 1 : 0;

                this.Text += "(" + status + ")";
                txtProductName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาดขณะโหลดฟอร์ม: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCategories()
        {
            try
            {
                string sql = "SELECT CategoryID, CategoryName FROM Categories";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbCategoryID.DataSource = dt;
                cmbCategoryID.DisplayMember = "CategoryName";
                cmbCategoryID.ValueMember = "CategoryID";
                cmbCategoryID.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาดขณะโหลดหมวดหมู่: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateProduct()
        {
            try
            {
                if (string.IsNullOrEmpty(txtProductID.Text))
                {
                    MessageBox.Show("กรุณาเลือกข้อมูลก่อน", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(txtProductName.Text))
                {
                    MessageBox.Show("ชื่อสินค้าต้องไม่ว่าง", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string sql = "Update Products set ProductName = @ProductName, UnitPrice = @UnitPrice, UnitsInStock = @UnitsInStock, CategoryID = @CategoryID, Discontinued = @Discontinued where ProductID = @ProductID";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ProductID", txtProductID.Text.Trim());
                cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text.Trim());
                cmd.Parameters.AddWithValue("@UnitPrice", laka.Text);
                cmd.Parameters.AddWithValue("@UnitsInStock", numUD_UnitsInStock.Value);
                cmd.Parameters.AddWithValue("@CategoryID", cmbCategoryID.SelectedValue);
                cmd.Parameters.AddWithValue("@Discontinued", cmbDiscontinued.SelectedIndex);
                cmd.ExecuteNonQuery();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาดขณะอัปเดตสินค้า: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertProduct()
        {
            try
            {
                if (string.IsNullOrEmpty(txtProductName.Text))
                {
                    MessageBox.Show("ชื่อสินค้า,รหัสสินค้าและประเภทสินค้า!ต้องไม่ว่าง!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string sql = "Insert into Products (ProductID, ProductName, UnitPrice, UnitsInStock, CategoryID, Discontinued) values (@ProductID, @ProductName, @UnitPrice, @UnitsInStock, @CategoryID, @Discontinued)";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ProductID", txtProductID.Text.Trim());
                cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text.Trim());
                cmd.Parameters.AddWithValue("@UnitPrice", laka.Text);
                cmd.Parameters.AddWithValue("@UnitsInStock", numUD_UnitsInStock.Value);
                cmd.Parameters.AddWithValue("@CategoryID", cmbCategoryID.SelectedValue);
                cmd.Parameters.AddWithValue("@Discontinued", cmbDiscontinued.SelectedIndex);
                cmd.ExecuteNonQuery();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาดขณะเพิ่มสินค้า: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (status == "insert")
                {
                    InsertProduct();
                }
                else if (status == "update")
                {
                    UpdateProduct();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาดขณะบันทึกข้อมูล: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbCategoryID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}