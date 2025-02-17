using WinFormMiniMart;

namespace MDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            ShowHideMenu(true, false, false);
        }
        void ShowHideMenu(Boolean Start, Boolean mgrMenu, Boolean saleMenu)
        {
            menuStrip1.Visible = Start;
            menuStrip2.Visible = mgrMenu;
            menuStrip3.Visible = saleMenu;
        }

        private void mnuLogin_Click(object sender, EventArgs e)
        {
            frmlogin f = new frmlogin();
            f.ShowDialog();
            if (f.EmployeeID == 0) //กรณีที่ไม่มีการ login ไม่ผ่าน
            {

                return;
            }

            this.Text = "ชื่อผู้ใช้ : " + f.username + " ตำแหน่ง : " + f.Position;
            if (f.Position == "Sale Manager")
            {
                ShowHideMenu(false, true, false);
            }
            else if (f.Position == "Sale Representative")
            {
                ShowHideMenu(false, false, true);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("ปิดโปรแกรม", "โปรดนั่งยัน", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void mnuClos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuSell_Click(object sender, EventArgs e)
        {
            F2 f = new F2();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuRepotSell_Click(object sender, EventArgs e)
        {
            F3 f = new F3();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuManage_Click(object sender, EventArgs e)
        {
            frmCategories f = new frmCategories();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuManageSell_Click(object sender, EventArgs e)
        {
            F5 f = new F5();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            ShowHideMenu(true, false, false);
            foreach (var child in MdiChildren) 
            {
                child.Close();
            }
        }

        private void ออกจากระบบToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ShowHideMenu(true, false, false);
            foreach (var child in MdiChildren)
            {
                child.Close();
            }
        }
    }
}
