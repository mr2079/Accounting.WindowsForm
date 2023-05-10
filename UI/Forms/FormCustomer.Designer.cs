namespace UI.Forms
{
    partial class FormCustomer
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
            btnAddCustomer = new ToolStripButton();
            btnEditCustomer = new ToolStripButton();
            btnDeleteCustomer = new ToolStripButton();
            btnRefreshList = new ToolStripButton();
            toolStripLabel1 = new ToolStripLabel();
            dgvCustomersList = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Mobile = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            label1 = new Label();
            actionButtonsContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomersList).BeginInit();
            SuspendLayout();
            // 
            // actionButtonsContainer
            // 
            actionButtonsContainer.ImageScalingSize = new Size(20, 20);
            actionButtonsContainer.Items.AddRange(new ToolStripItem[] { btnAddCustomer, btnEditCustomer, btnDeleteCustomer, btnRefreshList, toolStripLabel1 });
            actionButtonsContainer.Location = new Point(0, 0);
            actionButtonsContainer.Name = "actionButtonsContainer";
            actionButtonsContainer.RightToLeft = RightToLeft.Yes;
            actionButtonsContainer.Size = new Size(682, 67);
            actionButtonsContainer.TabIndex = 0;
            actionButtonsContainer.Text = "actionButtonsContainer";
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Image = Properties.Resources._1371475930_filenew;
            btnAddCustomer.ImageScaling = ToolStripItemImageScaling.None;
            btnAddCustomer.ImageTransparentColor = Color.Magenta;
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(56, 64);
            btnAddCustomer.Text = "افزودن";
            btnAddCustomer.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // btnEditCustomer
            // 
            btnEditCustomer.Image = Properties.Resources._1371475973_document_edit;
            btnEditCustomer.ImageScaling = ToolStripItemImageScaling.None;
            btnEditCustomer.ImageTransparentColor = Color.Magenta;
            btnEditCustomer.Name = "btnEditCustomer";
            btnEditCustomer.Size = new Size(59, 64);
            btnEditCustomer.Text = "ویرایش";
            btnEditCustomer.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEditCustomer.Click += btnEditCustomer_Click;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.Image = Properties.Resources._1371476007_Close_Box_Red;
            btnDeleteCustomer.ImageScaling = ToolStripItemImageScaling.None;
            btnDeleteCustomer.ImageTransparentColor = Color.Magenta;
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(45, 64);
            btnDeleteCustomer.Text = "حذف";
            btnDeleteCustomer.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDeleteCustomer.Click += btnDeleteCustomer_Click;
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
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(0, 64);
            // 
            // dgvCustomersList
            // 
            dgvCustomersList.AllowUserToAddRows = false;
            dgvCustomersList.AllowUserToDeleteRows = false;
            dgvCustomersList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomersList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomersList.Columns.AddRange(new DataGridViewColumn[] { Id, FullName, Mobile, Email });
            dgvCustomersList.Location = new Point(12, 103);
            dgvCustomersList.MultiSelect = false;
            dgvCustomersList.Name = "dgvCustomersList";
            dgvCustomersList.ReadOnly = true;
            dgvCustomersList.RightToLeft = RightToLeft.Yes;
            dgvCustomersList.RowHeadersWidth = 51;
            dgvCustomersList.RowTemplate.Height = 29;
            dgvCustomersList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomersList.Size = new Size(658, 338);
            dgvCustomersList.TabIndex = 1;
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
            // Mobile
            // 
            Mobile.DataPropertyName = "Mobile";
            Mobile.HeaderText = "شماره همراه";
            Mobile.MinimumWidth = 6;
            Mobile.Name = "Mobile";
            Mobile.ReadOnly = true;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "پست الکترونیکی";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(371, 74);
            label1.Name = "label1";
            label1.Size = new Size(299, 17);
            label1.TabIndex = 2;
            label1.Text = "برای دیدن هر تغییر اعمال شده لیست را بروزرسانی کنید";
            // 
            // FormCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 453);
            Controls.Add(label1);
            Controls.Add(dgvCustomersList);
            Controls.Add(actionButtonsContainer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormCustomer";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "لیست اشخاص";
            Load += frmCustomer_Load;
            actionButtonsContainer.ResumeLayout(false);
            actionButtonsContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomersList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip actionButtonsContainer;
        private ToolStripButton btnAddCustomer;
        private ToolStripButton btnEditCustomer;
        private ToolStripButton btnDeleteCustomer;
        private ToolStripButton btnRefreshList;
        private ToolStripLabel toolStripLabel1;
        private DataGridView dgvCustomersList;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Mobile;
        private DataGridViewTextBoxColumn Email;
        private Label label1;
    }
}