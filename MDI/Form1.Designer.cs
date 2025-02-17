namespace MDI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            mnuLogin = new ToolStripMenuItem();
            mnuClos = new ToolStripMenuItem();
            menuStrip2 = new MenuStrip();
            mnuManage = new ToolStripMenuItem();
            mnuManageSell = new ToolStripMenuItem();
            mnuManageEmployee = new ToolStripMenuItem();
            mnuRepotSellEmployee = new ToolStripMenuItem();
            mnuLogoutEmployee = new ToolStripMenuItem();
            menuStrip3 = new MenuStrip();
            mnuSell = new ToolStripMenuItem();
            mnuRepotSell = new ToolStripMenuItem();
            mnuLogout = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            menuStrip2.SuspendLayout();
            menuStrip3.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuLogin, mnuClos });
            menuStrip1.Location = new Point(0, 56);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuLogin
            // 
            mnuLogin.Name = "mnuLogin";
            mnuLogin.Size = new Size(80, 24);
            mnuLogin.Text = "เข้าสู่ระบบ";
            mnuLogin.Click += mnuLogin_Click;
            // 
            // mnuClos
            // 
            mnuClos.Name = "mnuClos";
            mnuClos.Size = new Size(90, 24);
            mnuClos.Text = "ปิดโปรแกรม";
            mnuClos.Click += mnuClos_Click;
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { mnuManage, mnuManageSell, mnuManageEmployee, mnuRepotSellEmployee, mnuLogoutEmployee });
            menuStrip2.Location = new Point(0, 28);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(800, 28);
            menuStrip2.TabIndex = 5;
            menuStrip2.Text = "menuStrip2";
            // 
            // mnuManage
            // 
            mnuManage.Name = "mnuManage";
            mnuManage.Size = new Size(128, 24);
            mnuManage.Text = "จัดการข้อมูลสินค้า";
            mnuManage.Click += mnuManage_Click;
            // 
            // mnuManageSell
            // 
            mnuManageSell.Name = "mnuManageSell";
            mnuManageSell.Size = new Size(178, 24);
            mnuManageSell.Text = "จัดการข้อมูลหมวดหมู่สินค้า";
            mnuManageSell.Click += mnuManageSell_Click;
            // 
            // mnuManageEmployee
            // 
            mnuManageEmployee.Name = "mnuManageEmployee";
            mnuManageEmployee.Size = new Size(145, 24);
            mnuManageEmployee.Text = "จัดการข้อมูลพนักงาน";
            // 
            // mnuRepotSellEmployee
            // 
            mnuRepotSellEmployee.Name = "mnuRepotSellEmployee";
            mnuRepotSellEmployee.Size = new Size(112, 24);
            mnuRepotSellEmployee.Text = "รายงานการขาย";
            // 
            // mnuLogoutEmployee
            // 
            mnuLogoutEmployee.AccessibleDescription = "mnuSelllogout";
            mnuLogoutEmployee.Name = "mnuLogoutEmployee";
            mnuLogoutEmployee.Size = new Size(101, 24);
            mnuLogoutEmployee.Text = "ออกจากระบบ";
            mnuLogoutEmployee.Click += ออกจากระบบToolStripMenuItem_Click;
            // 
            // menuStrip3
            // 
            menuStrip3.ImageScalingSize = new Size(20, 20);
            menuStrip3.Items.AddRange(new ToolStripItem[] { mnuSell, mnuRepotSell, mnuLogout });
            menuStrip3.Location = new Point(0, 0);
            menuStrip3.Name = "menuStrip3";
            menuStrip3.Size = new Size(800, 28);
            menuStrip3.TabIndex = 6;
            menuStrip3.Text = "menuStrip3";
            // 
            // mnuSell
            // 
            mnuSell.Name = "mnuSell";
            mnuSell.Size = new Size(80, 24);
            mnuSell.Text = "ขายสินค้า";
            mnuSell.Click += mnuSell_Click;
            // 
            // mnuRepotSell
            // 
            mnuRepotSell.Name = "mnuRepotSell";
            mnuRepotSell.Size = new Size(115, 24);
            mnuRepotSell.Text = "รายงานยอดขาย";
            mnuRepotSell.Click += mnuRepotSell_Click;
            // 
            // mnuLogout
            // 
            mnuLogout.Name = "mnuLogout";
            mnuLogout.Size = new Size(101, 24);
            mnuLogout.Text = "ออกจากระบบ";
            mnuLogout.Click += mnuLogout_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            Controls.Add(menuStrip3);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            menuStrip3.ResumeLayout(false);
            menuStrip3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private MenuStrip menuStrip3;
        private ToolStripMenuItem mnuLogin;
        private ToolStripMenuItem mnuClos;
        private ToolStripMenuItem mnuManage;
        private ToolStripMenuItem mnuManageSell;
        private ToolStripMenuItem mnuManageEmployee;
        private ToolStripMenuItem mnuRepotSellEmployee;
        private ToolStripMenuItem mnuSell;
        private ToolStripMenuItem mnuRepotSell;
        private ToolStripMenuItem mnuLogoutEmployee;
        private ToolStripMenuItem mnuLogout;
    }
}
