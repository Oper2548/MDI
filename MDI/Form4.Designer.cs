namespace WinFormMiniMart
{
    partial class Form4
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
            label4 = new Label();
            label3 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            cmbCategoryID = new ComboBox();
            txtProductName = new TextBox();
            txtProductID = new TextBox();
            cmbDiscontinued = new ComboBox();
            numUD_UnitsInStock = new NumericUpDown();
            laka = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numUD_UnitsInStock).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(116, 129);
            label4.Name = "label4";
            label4.Size = new Size(77, 38);
            label4.TabIndex = 13;
            label4.Text = "ราคา:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(77, 71);
            label3.Name = "label3";
            label3.Size = new Size(116, 38);
            label3.TabIndex = 14;
            label3.Text = "ชื่อสินค้า:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(10, 223);
            label6.Name = "label6";
            label6.Size = new Size(183, 38);
            label6.TabIndex = 16;
            label6.Text = "สถานะจำหน่าย:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(96, 181);
            label5.Name = "label5";
            label5.Size = new Size(97, 38);
            label5.TabIndex = 17;
            label5.Text = "จำนวน:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(366, 16);
            label2.Name = "label2";
            label2.Size = new Size(163, 38);
            label2.TabIndex = 18;
            label2.Text = "ประเภทสินค้า:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(65, 20);
            label1.Name = "label1";
            label1.Size = new Size(128, 38);
            label1.TabIndex = 19;
            label1.Text = "รหัสสินค้า:";
            // 
            // button2
            // 
            button2.BackColor = Color.Lime;
            button2.Location = new Point(265, 283);
            button2.Name = "button2";
            button2.Size = new Size(178, 61);
            button2.TabIndex = 11;
            button2.Text = "บันทึก";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(466, 283);
            button1.Name = "button1";
            button1.Size = new Size(178, 61);
            button1.TabIndex = 12;
            button1.Text = "ยกเลิก";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cmbCategoryID
            // 
            cmbCategoryID.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategoryID.FormattingEnabled = true;
            cmbCategoryID.Location = new Point(529, 13);
            cmbCategoryID.Name = "cmbCategoryID";
            cmbCategoryID.Size = new Size(184, 45);
            cmbCategoryID.TabIndex = 10;
            cmbCategoryID.SelectedIndexChanged += cmbCategoryID_SelectedIndexChanged;
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductName.Location = new Point(193, 66);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(520, 43);
            txtProductName.TabIndex = 8;
            // 
            // txtProductID
            // 
            txtProductID.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductID.Location = new Point(193, 11);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(171, 43);
            txtProductID.TabIndex = 9;
            // 
            // cmbDiscontinued
            // 
            cmbDiscontinued.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDiscontinued.FormattingEnabled = true;
            cmbDiscontinued.Items.AddRange(new object[] { "พร้อมจำหน่าย", "เลิกจำหน่าย" });
            cmbDiscontinued.Location = new Point(193, 232);
            cmbDiscontinued.Name = "cmbDiscontinued";
            cmbDiscontinued.Size = new Size(203, 45);
            cmbDiscontinued.TabIndex = 10;
            // 
            // numUD_UnitsInStock
            // 
            numUD_UnitsInStock.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numUD_UnitsInStock.Location = new Point(193, 179);
            numUD_UnitsInStock.Name = "numUD_UnitsInStock";
            numUD_UnitsInStock.Size = new Size(250, 43);
            numUD_UnitsInStock.TabIndex = 20;
            // 
            // laka
            // 
            laka.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            laka.Location = new Point(193, 124);
            laka.Name = "laka";
            laka.Size = new Size(171, 43);
            laka.TabIndex = 21;
            laka.Tag = "";
            laka.Text = "0";
            laka.TextChanged += textBox1_TextChanged;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 357);
            Controls.Add(laka);
            Controls.Add(numUD_UnitsInStock);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cmbDiscontinued);
            Controls.Add(cmbCategoryID);
            Controls.Add(txtProductName);
            Controls.Add(txtProductID);
            Name = "Form4";
            Text = "เพิ่ม/แก้ไขสินค้า";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)numUD_UnitsInStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button1;
        private ComboBox cmbCategoryID;
        private TextBox txtProductName;
        private TextBox txtProductID;
        private ComboBox cmbDiscontinued;
        private NumericUpDown numUD_UnitsInStock;
        private TextBox laka;
    }
}