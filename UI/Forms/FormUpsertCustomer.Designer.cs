namespace UI.Forms
{
    partial class FormUpsertCustomer
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
            gbCustomerInfo = new GroupBox();
            txtEmail = new TextBox();
            label1 = new Label();
            txtMobile = new TextBox();
            lblMobile = new Label();
            txtFullName = new TextBox();
            lblFullName = new Label();
            btnSubmit = new Button();
            btnCancel = new Button();
            gbCustomerInfo.SuspendLayout();
            SuspendLayout();
            // 
            // gbCustomerInfo
            // 
            gbCustomerInfo.Controls.Add(txtEmail);
            gbCustomerInfo.Controls.Add(label1);
            gbCustomerInfo.Controls.Add(txtMobile);
            gbCustomerInfo.Controls.Add(lblMobile);
            gbCustomerInfo.Controls.Add(txtFullName);
            gbCustomerInfo.Controls.Add(lblFullName);
            gbCustomerInfo.Location = new Point(12, 12);
            gbCustomerInfo.Name = "gbCustomerInfo";
            gbCustomerInfo.RightToLeft = RightToLeft.Yes;
            gbCustomerInfo.Size = new Size(335, 260);
            gbCustomerInfo.TabIndex = 0;
            gbCustomerInfo.TabStop = false;
            gbCustomerInfo.Text = "اطلاعات شخص";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(6, 212);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(323, 27);
            txtEmail.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(208, 182);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 4;
            label1.Text = "پست الکترونیکی :";
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(6, 138);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(323, 27);
            txtMobile.TabIndex = 3;
            // 
            // lblMobile
            // 
            lblMobile.AutoSize = true;
            lblMobile.Location = new Point(230, 108);
            lblMobile.Name = "lblMobile";
            lblMobile.Size = new Size(95, 20);
            lblMobile.TabIndex = 2;
            lblMobile.Text = "شماره همراه :";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(6, 67);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(323, 27);
            txtFullName.TabIndex = 1;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(195, 38);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(131, 20);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "نام و نام خانوادگی :";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(179, 278);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.RightToLeft = RightToLeft.Yes;
            btnSubmit.Size = new Size(168, 29);
            btnSubmit.TabIndex = 1;
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.Location = new Point(12, 278);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(161, 29);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "انصراف";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // FormUpsertCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 323);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(gbCustomerInfo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormUpsertCustomer";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Load += frmUpsertCustomer_Load;
            gbCustomerInfo.ResumeLayout(false);
            gbCustomerInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbCustomerInfo;
        private TextBox txtEmail;
        private Label label1;
        private TextBox txtMobile;
        private Label lblMobile;
        private TextBox txtFullName;
        private Label lblFullName;
        private Button btnSubmit;
        private Button btnCancel;
    }
}