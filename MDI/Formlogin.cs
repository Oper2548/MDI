using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using WinFormMiniMart;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MDI
{
    public partial class frmlogin : System.Windows.Forms.Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        //property
        public int EmployeeID { get; set; }
        public string EmpName { get; set; }
        public string Position { get; set; }
        public string username { get; set; }


        //ตัวแปร connect ฐานข้อมูล
        SqlConnection conn;
        SqlDataAdapter da;
        SqlCommand cmd;

        private void frmlogin_Load(object sender, EventArgs e)
        {
            conn = connDB.ConnectMinimart();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EmployeeID = 0;
            EmpName = "";
            Position = "";
            username = "";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string sql = "select EmployeeID,EmpName = Title + FirstName + ' ' + LastName,Position,UserName from Employees where username = @username and password = @password";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@username", txtUserName.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count == 1)
            {
                EmployeeID = Convert.ToInt16(ds.Tables[0].Rows[0]["EmployeeID"]);
                EmpName = ds.Tables[0].Rows[0]["EmpName"].ToString();
                Position = ds.Tables[0].Rows[0]["Position"].ToString();
                username = ds.Tables[0].Rows[0]["UserName"].ToString();
                MessageBox.Show(EmployeeID+Environment.NewLine + EmpName + Environment.NewLine + Position,"ยินดีต้อนรับ");
                
            }
            else
            {
                MessageBox.Show("Username หรือ Password ไม่ถูกต้อง","เกิดข้อผิดพลาด");
                EmployeeID = 0;
                EmpName = "";
                Position = "";
                username = "";
            }
            this.Close();
        }
    }
}
