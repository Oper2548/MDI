namespace WinFormMiniMart
{
    partial class FrmInsertUpdateCategories
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
            txtDescription = new TextBox();
            txtCategoryName = new TextBox();
            txtCategoryID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 16.2F);
            txtDescription.Location = new Point(245, 128);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(342, 123);
            txtDescription.TabIndex = 12;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Font = new Font("Segoe UI", 16.2F);
            txtCategoryName.Location = new Point(245, 69);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(327, 43);
            txtCategoryName.TabIndex = 11;
            // 
            // txtCategoryID
            // 
            txtCategoryID.Font = new Font("Segoe UI", 16.2F);
            txtCategoryID.Location = new Point(245, 23);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(153, 43);
            txtCategoryID.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F);
            label3.Location = new Point(108, 128);
            label3.Name = "label3";
            label3.Size = new Size(141, 38);
            label3.TabIndex = 9;
            label3.Text = "รายละเอียด:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F);
            label2.Location = new Point(54, 71);
            label2.Name = "label2";
            label2.Size = new Size(195, 38);
            label2.TabIndex = 8;
            label2.Text = "ชื่อประเภทสินค้า:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F);
            label1.Location = new Point(42, 33);
            label1.Name = "label1";
            label1.Size = new Size(207, 38);
            label1.TabIndex = 7;
            label1.Text = "รหัสประเภทสินค้า:";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Lime;
            btnSave.Font = new Font("Segoe UI", 16.2F);
            btnSave.ForeColor = SystemColors.ActiveCaptionText;
            btnSave.Location = new Point(362, 267);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(107, 51);
            btnSave.TabIndex = 13;
            btnSave.Text = "บันทึก";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.Font = new Font("Segoe UI", 16.2F);
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Location = new Point(475, 267);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 51);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "ยกเลิก";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // FrmInsertUpdateCategories
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtDescription);
            Controls.Add(txtCategoryName);
            Controls.Add(txtCategoryID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmInsertUpdateCategories";
            Text = "FrmInsertUpdateCategories";
            Load += FrmInsertUpdateCategories_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescription;
        private TextBox txtCategoryName;
        private TextBox txtCategoryID;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSave;
        private Button btnCancel;
    }
}