﻿namespace WinFormMiniMart
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvEmployees = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            txtSearch = new TextBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();
            // 
            // dgvEmployees
            // 
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Location = new Point(12, 160);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.RowHeadersWidth = 51;
            dgvEmployees.Size = new Size(776, 274);
            dgvEmployees.TabIndex = 0;
            dgvEmployees.CellDoubleClick += dgvEmployees_CellDoubleClick;
            dgvEmployees.CellMouseUp += dgvEmployees_CellMouseUp;
            // 
            // button1
            // 
            button1.BackColor = Color.Cyan;
            button1.Location = new Point(373, 87);
            button1.Name = "button1";
            button1.Size = new Size(102, 55);
            button1.TabIndex = 1;
            button1.Text = "ล้างการค้นหา";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Lime;
            button2.Location = new Point(242, 87);
            button2.Name = "button2";
            button2.Size = new Size(125, 52);
            button2.TabIndex = 1;
            button2.Text = "เพิ่มข้อมูล";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(36, 26);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(733, 55);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += textBox1_TextChanged;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.ForeColor = SystemColors.ControlText;
            button3.Location = new Point(481, 87);
            button3.Name = "button3";
            button3.Size = new Size(125, 52);
            button3.TabIndex = 1;
            button3.Text = "ลบข้อมูล";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSearch);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvEmployees);
            Name = "Form1";
            Text = "จัดการพนักงาน";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEmployees;
        private Button button1;
        private Button button2;
        private TextBox txtSearch;
        private Button button3;
    }
}