using Infrastructure.Services.Interfaces;
using Infrastructure.Statics;
using Infrastructure.ViewModels;

namespace UI.Forms;

public partial class FormUpsertTransaction : Form
{
    public Guid? TransactionId = null;
    private readonly ICustomerService _customerService;
    private readonly ITransactionService _transactionService;

    public FormUpsertTransaction()
    {
        InitializeComponent();
        _customerService = Program.GetService<ICustomerService>();
        _transactionService = Program.GetService<ITransactionService>();
    }

    private async void frmAddTransaction_Load(object sender, EventArgs e)
    {
        if (TransactionId == null)
        {
            // Insert
            btnSubmit.BackColor = Color.Green;
            dgvCustomersList.DataSource = await _customerService.GetCustomersListForAddTransactionAsync();
        }
        else
        {
            // Update
            this.Text = "ویرایش تراکنش";
            btnSubmit.Text = "ویرایش";
            lblWarning.Visible = false;
            btnSubmit.BackColor = Color.Yellow;
            gbCustomersList.Enabled = false;
            var transaction = await _transactionService.GetByIdAsync((Guid)TransactionId);
            if (transaction != null)
            {
                if (transaction.Type == TransactionType.Payment) rBtnPay.Checked = true;
                if (transaction.Type == TransactionType.Recieve) rBtnRecieve.Checked = true;
                txtCustomerFullName.Text = transaction.Customer.FullName;
                txtAmount.Value = transaction.Amount;
                txtDescription.Text = transaction.Description;
            }
            else this.Close();
        }
    }

    private void dgvCustomersList_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        txtCustomerFullName.Text = dgvCustomersList.CurrentRow.Cells[1].Value.ToString();
    }

    private async void txtFilter_TextChanged(object sender, EventArgs e)
    {
        dgvCustomersList.DataSource =
            await _customerService.GetCustomersListForAddTransactionByFilterAsync(txtFilter.Text);
    }

    private async void btnSubmit_Click(object sender, EventArgs e)
    {
        bool condition = txtCustomerFullName.Text != string.Empty &&
            txtAmount.Value != 0 &&
            (rBtnPay.Checked || rBtnRecieve.Checked);

        if (condition)
        {
            var transaction = new CreateTransactionViewModel
            {
                Amount = long.Parse(txtAmount.Value.ToString()),
                Description = txtDescription.Text,
            };

            if (TransactionId == null)
                transaction.CustomerId = Guid.Parse(dgvCustomersList.CurrentRow.Cells[0].Value.ToString());

            if (rBtnPay.Checked) transaction.TransactionType = TransactionType.Payment;
            if (rBtnRecieve.Checked) transaction.TransactionType = TransactionType.Recieve;

            if (TransactionId == null && await _transactionService.CreateTransactionAsync(transaction))
            {
                MessageBox.Show("تراکنش با موفقیت ثبت شد",
                    string.Empty,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Clear();
            }
            else if (await _transactionService.UpdateTransactionAsync((Guid)TransactionId, transaction))
                this.Close();
            else
                MessageBox.Show("متاسفانه خطایی در سمت ما رخ داده است",
                    string.Empty,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }
        else
            MessageBox.Show("فیلدهای الزامی را پر کنید",
                string.Empty,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
    }

    void Clear()
    {
        txtCustomerFullName.Text = string.Empty;
        txtAmount.Value = 0;
        txtDescription.Text = string.Empty;
        rBtnPay.Checked = false;
        rBtnRecieve.Checked = false;
    }
}
