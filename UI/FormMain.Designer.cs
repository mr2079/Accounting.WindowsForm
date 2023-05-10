namespace UI
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            dialogButtonsContainer = new ToolStrip();
            btnCustomerDialog = new ToolStripButton();
            btnAddTransactionDialog = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            btnRefresh = new ToolStripButton();
            groupBox1 = new GroupBox();
            lblBalance = new Label();
            label6 = new Label();
            lblPayments = new Label();
            label4 = new Label();
            lblRecieves = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            dialogButtonsContainer.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dialogButtonsContainer
            // 
            dialogButtonsContainer.ImageScalingSize = new Size(20, 20);
            dialogButtonsContainer.Items.AddRange(new ToolStripItem[] { btnCustomerDialog, btnAddTransactionDialog, toolStripButton1, btnRefresh });
            dialogButtonsContainer.Location = new Point(0, 0);
            dialogButtonsContainer.Name = "dialogButtonsContainer";
            dialogButtonsContainer.RightToLeft = RightToLeft.Yes;
            dialogButtonsContainer.Size = new Size(784, 67);
            dialogButtonsContainer.TabIndex = 0;
            dialogButtonsContainer.Text = "dialogButtonsContainer";
            // 
            // btnCustomerDialog
            // 
            btnCustomerDialog.Image = (Image)resources.GetObject("btnCustomerDialog.Image");
            btnCustomerDialog.ImageScaling = ToolStripItemImageScaling.None;
            btnCustomerDialog.ImageTransparentColor = Color.Magenta;
            btnCustomerDialog.Name = "btnCustomerDialog";
            btnCustomerDialog.Size = new Size(90, 64);
            btnCustomerDialog.Text = "طرف حساب";
            btnCustomerDialog.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCustomerDialog.Click += btnCustomerDialog_Click;
            // 
            // btnAddTransactionDialog
            // 
            btnAddTransactionDialog.Image = Properties.Resources._1371476499_todo_list;
            btnAddTransactionDialog.ImageScaling = ToolStripItemImageScaling.None;
            btnAddTransactionDialog.ImageTransparentColor = Color.Magenta;
            btnAddTransactionDialog.Name = "btnAddTransactionDialog";
            btnAddTransactionDialog.Size = new Size(92, 64);
            btnAddTransactionDialog.Text = "تراکنش جدید";
            btnAddTransactionDialog.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAddTransactionDialog.Click += btnAddTransactionDialog_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = Properties.Resources.servicesCosts;
            toolStripButton1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(53, 64);
            toolStripButton1.Text = "گزارش";
            toolStripButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButton1.ToolTipText = "گزارش";
            toolStripButton1.Click += btnReportDialog_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Image = Properties.Resources._1371476342_Refresh;
            btnRefresh.ImageScaling = ToolStripItemImageScaling.None;
            btnRefresh.ImageTransparentColor = Color.Magenta;
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(76, 64);
            btnRefresh.Text = "بروزرسانی";
            btnRefresh.TextImageRelation = TextImageRelation.ImageAboveText;
            btnRefresh.ToolTipText = "گزارش";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblBalance);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(lblPayments);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lblRecieves);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(522, 91);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox1.Size = new Size(250, 195);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "گزارشات ماه";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(6, 162);
            lblBalance.Name = "lblBalance";
            lblBalance.RightToLeft = RightToLeft.No;
            lblBalance.Size = new Size(17, 20);
            lblBalance.TabIndex = 9;
            lblBalance.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(178, 141);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 8;
            label6.Text = "موجودی :";
            // 
            // lblPayments
            // 
            lblPayments.AutoSize = true;
            lblPayments.Location = new Point(6, 109);
            lblPayments.Name = "lblPayments";
            lblPayments.RightToLeft = RightToLeft.No;
            lblPayments.Size = new Size(17, 20);
            lblPayments.TabIndex = 7;
            lblPayments.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(138, 88);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 6;
            label4.Text = "مجموع پرداخت :";
            // 
            // lblRecieves
            // 
            lblRecieves.AutoSize = true;
            lblRecieves.Location = new Point(6, 54);
            lblRecieves.Name = "lblRecieves";
            lblRecieves.RightToLeft = RightToLeft.No;
            lblRecieves.Size = new Size(17, 20);
            lblRecieves.TabIndex = 5;
            lblRecieves.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(137, 33);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 4;
            label1.Text = "مجموع دریافت :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Untitled_1;
            pictureBox1.Location = new Point(522, 292);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 171);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.accounting;
            pictureBox2.Location = new Point(12, 91);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(504, 372);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 477);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(dialogButtonsContainer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "حسابداری";
            Load += Form1_Load;
            dialogButtonsContainer.ResumeLayout(false);
            dialogButtonsContainer.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip dialogButtonsContainer;
        private ToolStripButton btnCustomerDialog;
        private ToolStripButton btnAddTransactionDialog;
        private ToolStripButton btnRefresh;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblBalance;
        private Label label6;
        private Label lblPayments;
        private Label label4;
        private Label lblRecieves;
        private Label label1;
        private ToolStripButton toolStripButton1;
    }
}