namespace UI.Forms
{
    partial class FormUpsertTransaction
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
            lblCustomer = new Label();
            txtCustomerFullName = new TextBox();
            label1 = new Label();
            rBtnRecieve = new RadioButton();
            rBtnPay = new RadioButton();
            label2 = new Label();
            txtAmount = new NumericUpDown();
            lblDescription = new Label();
            txtDescription = new TextBox();
            btnSubmit = new Button();
            gbCustomersList = new GroupBox();
            dgvCustomersList = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            txtFilter = new TextBox();
            label3 = new Label();
            lblWarning = new Label();
            ((System.ComponentModel.ISupportInitialize)txtAmount).BeginInit();
            gbCustomersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomersList).BeginInit();
            SuspendLayout();
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(695, 29);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.RightToLeft = RightToLeft.Yes;
            lblCustomer.Size = new Size(93, 20);
            lblCustomer.TabIndex = 0;
            lblCustomer.Text = "طرف حساب :";
            // 
            // txtCustomerFullName
            // 
            txtCustomerFullName.Location = new Point(388, 26);
            txtCustomerFullName.Name = "txtCustomerFullName";
            txtCustomerFullName.ReadOnly = true;
            txtCustomerFullName.RightToLeft = RightToLeft.Yes;
            txtCustomerFullName.Size = new Size(278, 27);
            txtCustomerFullName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(701, 79);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(87, 20);
            label1.TabIndex = 2;
            label1.Text = "نوع تراکنش :";
            // 
            // rBtnRecieve
            // 
            rBtnRecieve.AutoSize = true;
            rBtnRecieve.Location = new Point(590, 75);
            rBtnRecieve.Name = "rBtnRecieve";
            rBtnRecieve.RightToLeft = RightToLeft.Yes;
            rBtnRecieve.Size = new Size(76, 24);
            rBtnRecieve.TabIndex = 3;
            rBtnRecieve.TabStop = true;
            rBtnRecieve.Text = "دریافت";
            rBtnRecieve.UseVisualStyleBackColor = true;
            // 
            // rBtnPay
            // 
            rBtnPay.AutoSize = true;
            rBtnPay.Location = new Point(493, 75);
            rBtnPay.Name = "rBtnPay";
            rBtnPay.RightToLeft = RightToLeft.Yes;
            rBtnPay.Size = new Size(75, 24);
            rBtnPay.TabIndex = 4;
            rBtnPay.TabStop = true;
            rBtnPay.Text = "پرداخت";
            rBtnPay.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(744, 122);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(44, 20);
            label2.TabIndex = 5;
            label2.Text = "مبلغ :";
            // 
            // txtAmount
            // 
            txtAmount.Increment = new decimal(new int[] { 200000, 0, 0, 0 });
            txtAmount.Location = new Point(388, 122);
            txtAmount.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            txtAmount.Name = "txtAmount";
            txtAmount.RightToLeft = RightToLeft.Yes;
            txtAmount.Size = new Size(278, 27);
            txtAmount.TabIndex = 7;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(745, 175);
            lblDescription.Name = "lblDescription";
            lblDescription.RightToLeft = RightToLeft.Yes;
            lblDescription.Size = new Size(43, 20);
            lblDescription.TabIndex = 8;
            lblDescription.Text = "شرح :";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(388, 175);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.RightToLeft = RightToLeft.Yes;
            txtDescription.Size = new Size(278, 194);
            txtDescription.TabIndex = 9;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(388, 385);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.RightToLeft = RightToLeft.Yes;
            btnSubmit.Size = new Size(278, 42);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "ثبت";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // gbCustomersList
            // 
            gbCustomersList.Controls.Add(dgvCustomersList);
            gbCustomersList.Controls.Add(txtFilter);
            gbCustomersList.Controls.Add(label3);
            gbCustomersList.Location = new Point(12, 16);
            gbCustomersList.Name = "gbCustomersList";
            gbCustomersList.RightToLeft = RightToLeft.Yes;
            gbCustomersList.Size = new Size(359, 411);
            gbCustomersList.TabIndex = 11;
            gbCustomersList.TabStop = false;
            gbCustomersList.Text = "لیست اشخاص";
            // 
            // dgvCustomersList
            // 
            dgvCustomersList.AllowUserToAddRows = false;
            dgvCustomersList.AllowUserToDeleteRows = false;
            dgvCustomersList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomersList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomersList.Columns.AddRange(new DataGridViewColumn[] { Id, FullName });
            dgvCustomersList.Location = new Point(12, 80);
            dgvCustomersList.Name = "dgvCustomersList";
            dgvCustomersList.ReadOnly = true;
            dgvCustomersList.RowHeadersWidth = 51;
            dgvCustomersList.RowTemplate.Height = 29;
            dgvCustomersList.Size = new Size(341, 325);
            dgvCustomersList.TabIndex = 14;
            dgvCustomersList.CellClick += dgvCustomersList_CellClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // FullName
            // 
            FullName.DataPropertyName = "FullName";
            FullName.HeaderText = "نام و نام خانوادگی";
            FullName.MinimumWidth = 6;
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(12, 34);
            txtFilter.Name = "txtFilter";
            txtFilter.RightToLeft = RightToLeft.Yes;
            txtFilter.Size = new Size(272, 27);
            txtFilter.TabIndex = 13;
            txtFilter.TextChanged += txtFilter_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(293, 35);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(60, 20);
            label3.TabIndex = 12;
            label3.Text = "جستجو :";
            // 
            // lblWarning
            // 
            lblWarning.AutoSize = true;
            lblWarning.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblWarning.ForeColor = Color.OrangeRed;
            lblWarning.Location = new Point(491, 6);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(175, 17);
            lblWarning.TabIndex = 15;
            lblWarning.Text = "نام را از لیست روبرو انتخاب کنید";
            // 
            // FormUpsertTransaction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 443);
            Controls.Add(lblWarning);
            Controls.Add(gbCustomersList);
            Controls.Add(btnSubmit);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(txtAmount);
            Controls.Add(label2);
            Controls.Add(rBtnPay);
            Controls.Add(rBtnRecieve);
            Controls.Add(label1);
            Controls.Add(txtCustomerFullName);
            Controls.Add(lblCustomer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormUpsertTransaction";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "تراکنش جدید";
            Load += frmAddTransaction_Load;
            ((System.ComponentModel.ISupportInitialize)txtAmount).EndInit();
            gbCustomersList.ResumeLayout(false);
            gbCustomersList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomersList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCustomer;
        private TextBox txtCustomerFullName;
        private Label label1;
        private RadioButton rBtnRecieve;
        private RadioButton rBtnPay;
        private Label label2;
        private NumericUpDown txtAmount;
        private Label lblDescription;
        private TextBox txtDescription;
        private Button btnSubmit;
        private GroupBox gbCustomersList;
        private DataGridView dgvCustomersList;
        private TextBox txtFilter;
        private Label label3;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn FullName;
        private Label lblWarning;
    }
}