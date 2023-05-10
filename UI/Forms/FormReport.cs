using Infrastructure.Services.Interfaces;
using Infrastructure.Statics;
using Infrastructure.ViewModels;

namespace UI.Forms;

public partial class FormReport : Form
{
    private readonly ITransactionService _transactionService;
    private readonly ICustomerService _customerService;

    public FormReport()
    {
        InitializeComponent();
        _transactionService = Program.GetService<ITransactionService>();
        _customerService = Program.GetService<ICustomerService>();
    }

    async void BindGrid(string? transactionType, Guid? customerId)
    {
        if (customerId != null)
        {
            dgvTransactionReport.DataSource = await _transactionService
                .GetTransactionsReportByCustomerIdAsync(customerId ?? Guid.Empty);
            return;
        }
        dgvTransactionReport.DataSource = await _transactionService.GetTransactionsReportAsync(transactionType);
    }

    async void BindList()
    {
        var customersList = await _customerService.GetCustomersListForAddTransactionAsync();
        customersList.Insert(0, new CustomersListForAddTransactionViewModel
        {
            Id = Guid.Empty,
            FullName = "انتخاب کنید",
        });
        cbCustomersList.DataSource = customersList;
        cbCustomersList.DisplayMember = "FullName";
        cbCustomersList.ValueMember = "Id";
    }

    private async void frmReport_Load(object sender, EventArgs e)
    {
        rbtnAll.Checked = true;
        BindGrid(null, null);
        BindList();
    }

    private void rbtnPay_CheckedChanged(object sender, EventArgs e)
    {
        BindGrid(TransactionType.Payment, null);
    }

    private void rbtnRecieve_CheckedChanged(object sender, EventArgs e)
    {
        BindGrid(TransactionType.Recieve, null);
    }

    private void rbtnAll_CheckedChanged(object sender, EventArgs e)
    {
        BindGrid(null, null);
    }

    private void btnRefreshList_Click(object sender, EventArgs e)
    {
        rbtnAll.Checked = true;
        cbCustomersList.SelectedIndex = 0;
        BindGrid(null, null);
    }

    private void btnFilter_Click(object sender, EventArgs e)
    {
        rbtnAll.Checked = true;
        var customerId = Guid.Parse(cbCustomersList.SelectedValue.ToString());
        if (!Equals(customerId, Guid.Empty))
            BindGrid(null, customerId);
        else BindGrid(null, null);
    }

    private async void btnDelete_Click(object sender, EventArgs e)
    {
        var result = MessageBox.Show($"آیا از حذف این تراکنش مطمئن هستید؟",
            string.Empty, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

        if (result == DialogResult.OK)
        {
            Guid transactionId = Guid.Parse(dgvTransactionReport.CurrentRow.Cells[0].Value.ToString());
            if (await _transactionService.DeleteTransactionAsync(transactionId))
                BindGrid(null, null);
        }
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        FormUpsertTransaction frmUpdate = new FormUpsertTransaction();
        frmUpdate.TransactionId = Guid.Parse(dgvTransactionReport.CurrentRow.Cells[0].Value.ToString());
        frmUpdate.ShowDialog();
    }
}
