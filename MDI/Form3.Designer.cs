﻿namespace WinFormMiniMart
{
    partial class Form3
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
            txtSearch = new TextBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dgvProducts = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(210, 12);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(394, 55);
            txtSearch.TabIndex = 7;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(648, 79);
            button3.Name = "button3";
            button3.Size = new Size(125, 52);
            button3.TabIndex = 4;
            button3.Text = "ลบข้อมูล";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Lime;
            button2.Location = new Point(405, 79);
            button2.Name = "button2";
            button2.Size = new Size(125, 52);
            button2.TabIndex = 5;
            button2.Text = "เพิ่มข้อมูล";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Cyan;
            button1.Location = new Point(547, 79);
            button1.Name = "button1";
            button1.Size = new Size(83, 55);
            button1.TabIndex = 6;
            button1.Text = "ล้าง";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(12, 140);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(776, 286);
            dgvProducts.TabIndex = 3;
            dgvProducts.CellDoubleClick += dgvProducts_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 29);
            label1.Name = "label1";
            label1.Size = new Size(147, 38);
            label1.TabIndex = 8;
            label1.Text = "ค้นหาสินค้า:";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvProducts);
            Name = "Form3";
            Text = "จัดการสินค้า";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dgvProducts;
        private Label label1;
    }
}