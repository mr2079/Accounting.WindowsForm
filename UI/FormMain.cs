using Infrastructure.Services.Interfaces;
using UI.Forms;

namespace UI;

public partial class FormMain : Form
{
    private readonly ITransactionService _transactionService;

    public FormMain()
    {
        InitializeComponent();
        _transactionService = Program.GetService<ITransactionService>();
    }

    async void RefreshInfo()
    {
        var info = await _transactionService.GetMainFormInfoAsync();
        lblRecieves.Text = info.RecievesCount.ToString("0,#");
        lblPayments.Text = info.PaymentsCount.ToString("0,#");
        lblBalance.Text = info.Balance.ToString("0,#");
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        RefreshInfo();
    }

    private void btnCustomerDialog_Click(object sender, EventArgs e)
    {
        var frmCustomer = new FormCustomer();
        frmCustomer.ShowDialog();
    }

    private void btnAddTransactionDialog_Click(object sender, EventArgs e)
    {
        var frmAddTransaction = new FormUpsertTransaction();
        frmAddTransaction.ShowDialog();
    }

    private void btnReportDialog_Click(object sender, EventArgs e)
    {
        var frmReport = new FormReport();
        frmReport.ShowDialog();
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
        RefreshInfo();
    }
}