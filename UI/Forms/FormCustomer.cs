using Infrastructure.Services.Interfaces;

namespace UI.Forms;

public partial class FormCustomer : Form
{
    private readonly ICustomerService _customerService;

    public FormCustomer()
    {
        InitializeComponent();
        _customerService = Program.GetService<ICustomerService>();
    }

    void BindGrid()
    {
        dgvCustomersList.DataSource = _customerService.GetAllAsync().Result;
    }

    private void frmCustomer_Load(object sender, EventArgs e)
    {
        dgvCustomersList.AutoGenerateColumns = false;
        BindGrid();
    }

    private void btnAddCustomer_Click(object sender, EventArgs e)
    {
        var frmAddCustomer = new FormUpsertCustomer();
        frmAddCustomer.ShowDialog();
    }

    private void btnRefreshList_Click(object sender, EventArgs e)
    {
        BindGrid();
    }

    private void btnEditCustomer_Click(object sender, EventArgs e)
    {
        var customerId = Guid.Parse(dgvCustomersList.CurrentRow.Cells[0].Value.ToString());
        var frmUpdateCustomer = new FormUpsertCustomer();
        frmUpdateCustomer.CustomerId = customerId;
        frmUpdateCustomer.ShowDialog();
    }

    private async void btnDeleteCustomer_Click(object sender, EventArgs e)
    {
        var result = MessageBox.Show($"آیا از حذف \"{dgvCustomersList.CurrentRow.Cells[1].Value}\" مطمئن هستید؟",
            string.Empty, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

        if (result == DialogResult.OK)
        {
            var customerId = Guid.Parse(dgvCustomersList.CurrentRow.Cells[0].Value.ToString());

            if (await _customerService.DeleteCustomerAsync(customerId))
                BindGrid();
        }
    }
}
