namespace UI.Forms
{
    partial class FormReport
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
            actionButtonsContainer = new ToolStrip();
            btnEdit = new ToolStripButton();
            btnDelete = new ToolStripButton();
            btnRefreshList = new ToolStripButton();
            gbFilter = new GroupBox();
            btnFilter = new Button();
            cbCustomersList = new ComboBox();
            lblCustomer = new Label();
            dgvTransactionReport = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            CustomerId = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            AddedAt = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            gbTransactionType = new GroupBox();
            rbtnAll = new RadioButton();
            rbtnRecieve = new RadioButton();
            rbtnPay = new RadioButton();
            lblType = new Label();
            actionButtonsContainer.SuspendLayout();
            gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactionReport).BeginInit();
            gbTransactionType.SuspendLayout();
            SuspendLayout();
            // 
            // actionButtonsContainer
            // 
            actionButtonsContainer.ImageScalingSize = new Size(20, 20);
            actionButtonsContainer.Items.AddRange(new ToolStripItem[] { btnEdit, btnDelete, btnRefreshList });
            actionButtonsContainer.Location = new Point(0, 0);
            actionButtonsContainer.Name = "actionButtonsContainer";
            actionButtonsContainer.RightToLeft = RightToLeft.Yes;
            actionButtonsContainer.Size = new Size(800, 67);
            actionButtonsContainer.TabIndex = 0;
            actionButtonsContainer.Text = "actionButtonsContainer";
            // 
            // btnEdit
            // 
            btnEdit.Image = Properties.Resources._1371475973_document_edit;
            btnEdit.ImageScaling = ToolStripItemImageScaling.None;
            btnEdit.ImageTransparentColor = Color.Magenta;
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(59, 64);
            btnEdit.Text = "ویرایش";
            btnEdit.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Image = Properties.Resources._1371476007_Close_Box_Red;
            btnDelete.ImageScaling = ToolStripItemImageScaling.None;
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(45, 64);
            btnDelete.Text = "حذف";
            btnDelete.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefreshList
            // 
            btnRefreshList.Image = Properties.Resources._1371476342_Refresh;
            btnRefreshList.ImageScaling = ToolStripItemImageScaling.None;
            btnRefreshList.ImageTransparentColor = Color.Magenta;
            btnRefreshList.Name = "btnRefreshList";
            btnRefreshList.Size = new Size(76, 64);
            btnRefreshList.Text = "بروزرسانی";
            btnRefreshList.TextImageRelation = TextImageRelation.ImageAboveText;
            btnRefreshList.Click += btnRefreshList_Click;
            // 
            // gbFilter
            // 
            gbFilter.Controls.Add(btnFilter);
            gbFilter.Controls.Add(cbCustomersList);
            gbFilter.Controls.Add(lblCustomer);
            gbFilter.Location = new Point(12, 165);
            gbFilter.Name = "gbFilter";
            gbFilter.RightToLeft = RightToLeft.Yes;
            gbFilter.Size = new Size(776, 75);
            gbFilter.TabIndex = 1;
            gbFilter.TabStop = false;
            gbFilter.Text = "جستجو";
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(6, 28);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(197, 29);
            btnFilter.TabIndex = 2;
            btnFilter.Text = "اعمال";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // cbCustomersList
            // 
            cbCustomersList.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCustomersList.FormattingEnabled = true;
            cbCustomersList.Location = new Point(209, 29);
            cbCustomersList.Name = "cbCustomersList";
            cbCustomersList.Size = new Size(449, 28);
            cbCustomersList.TabIndex = 1;
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(677, 32);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(93, 20);
            lblCustomer.TabIndex = 0;
            lblCustomer.Text = "طرف حساب :";
            // 
            // dgvTransactionReport
            // 
            dgvTransactionReport.AllowUserToAddRows = false;
            dgvTransactionReport.AllowUserToDeleteRows = false;
            dgvTransactionReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransactionReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactionReport.Columns.AddRange(new DataGridViewColumn[] { Id, CustomerId, FullName, Amount, AddedAt, Description });
            dgvTransactionReport.Location = new Point(12, 246);
            dgvTransactionReport.Name = "dgvTransactionReport";
            dgvTransactionReport.ReadOnly = true;
            dgvTransactionReport.RightToLeft = RightToLeft.Yes;
            dgvTransactionReport.RowHeadersWidth = 51;
            dgvTransactionReport.RowTemplate.Height = 29;
            dgvTransactionReport.Size = new Size(776, 276);
            dgvTransactionReport.TabIndex = 2;
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
            // CustomerId
            // 
            CustomerId.DataPropertyName = "CustomerId";
            CustomerId.HeaderText = "CustomerId";
            CustomerId.MinimumWidth = 6;
            CustomerId.Name = "CustomerId";
            CustomerId.ReadOnly = true;
            CustomerId.Visible = false;
            // 
            // FullName
            // 
            FullName.DataPropertyName = "FullName";
            FullName.HeaderText = "نام و نام خانوادگی";
            FullName.MinimumWidth = 6;
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            // 
            // Amount
            // 
            Amount.DataPropertyName = "Amount";
            Amount.HeaderText = "مبلغ";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            // 
            // AddedAt
            // 
            AddedAt.DataPropertyName = "AddedAt";
            AddedAt.HeaderText = "تاریخ";
            AddedAt.MinimumWidth = 6;
            AddedAt.Name = "AddedAt";
            AddedAt.ReadOnly = true;
            // 
            // Description
            // 
            Description.DataPropertyName = "Description";
            Description.HeaderText = "شرح";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.ReadOnly = true;
            // 
            // gbTransactionType
            // 
            gbTransactionType.Controls.Add(rbtnAll);
            gbTransactionType.Controls.Add(rbtnRecieve);
            gbTransactionType.Controls.Add(rbtnPay);
            gbTransactionType.Controls.Add(lblType);
            gbTransactionType.Location = new Point(12, 82);
            gbTransactionType.Name = "gbTransactionType";
            gbTransactionType.RightToLeft = RightToLeft.Yes;
            gbTransactionType.Size = new Size(776, 77);
            gbTransactionType.TabIndex = 3;
            gbTransactionType.TabStop = false;
            gbTransactionType.Text = "نوع تراکنش";
            // 
            // rbtnAll
            // 
            rbtnAll.AutoSize = true;
            rbtnAll.Location = new Point(449, 33);
            rbtnAll.Name = "rbtnAll";
            rbtnAll.Size = new Size(57, 24);
            rbtnAll.TabIndex = 3;
            rbtnAll.TabStop = true;
            rbtnAll.Text = "همه";
            rbtnAll.UseVisualStyleBackColor = true;
            rbtnAll.CheckedChanged += rbtnAll_CheckedChanged;
            // 
            // rbtnRecieve
            // 
            rbtnRecieve.AutoSize = true;
            rbtnRecieve.Location = new Point(523, 33);
            rbtnRecieve.Name = "rbtnRecieve";
            rbtnRecieve.Size = new Size(76, 24);
            rbtnRecieve.TabIndex = 2;
            rbtnRecieve.TabStop = true;
            rbtnRecieve.Text = "دریافت";
            rbtnRecieve.UseVisualStyleBackColor = true;
            rbtnRecieve.CheckedChanged += rbtnRecieve_CheckedChanged;
            // 
            // rbtnPay
            // 
            rbtnPay.AutoSize = true;
            rbtnPay.Location = new Point(613, 33);
            rbtnPay.Name = "rbtnPay";
            rbtnPay.Size = new Size(75, 24);
            rbtnPay.TabIndex = 1;
            rbtnPay.TabStop = true;
            rbtnPay.Text = "پرداخت";
            rbtnPay.UseVisualStyleBackColor = true;
            rbtnPay.CheckedChanged += rbtnPay_CheckedChanged;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(712, 35);
            lblType.Name = "lblType";
            lblType.Size = new Size(38, 20);
            lblType.TabIndex = 0;
            lblType.Text = "نوع :";
            // 
            // FormReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 534);
            Controls.Add(gbTransactionType);
            Controls.Add(dgvTransactionReport);
            Controls.Add(gbFilter);
            Controls.Add(actionButtonsContainer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormReport";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Load += frmReport_Load;
            actionButtonsContainer.ResumeLayout(false);
            actionButtonsContainer.PerformLayout();
            gbFilter.ResumeLayout(false);
            gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactionReport).EndInit();
            gbTransactionType.ResumeLayout(false);
            gbTransactionType.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip actionButtonsContainer;
        private ToolStripButton btnRefreshList;
        private ToolStripButton btnEdit;
        private ToolStripButton btnDelete;
        private GroupBox gbFilter;
        private Button btnFilter;
        private ComboBox cbCustomersList;
        private Label lblCustomer;
        private DataGridView dgvTransactionReport;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn CustomerId;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn AddedAt;
        private DataGridViewTextBoxColumn Description;
        private GroupBox gbTransactionType;
        private RadioButton rbtnAll;
        private RadioButton rbtnRecieve;
        private RadioButton rbtnPay;
        private Label lblType;
    }
}