using Infrastructure.Services.Interfaces;
using Infrastructure.ViewModels;

namespace UI.Forms;

public partial class FormUpsertCustomer : Form
{
    public Guid? CustomerId = null;
    private readonly ICustomerService _customerService;

    public FormUpsertCustomer()
    {
        InitializeComponent();
        _customerService = Program.GetService<ICustomerService>();
    }

    private async void frmUpsertCustomer_Load(object sender, EventArgs e)
    {
        if (CustomerId == null)
        {
            // Insert
            btnSubmit.Text = "ثبت";
            btnSubmit.BackColor = Color.Green;
        }
        else
        {
            // Update
            btnSubmit.Text = "ویرایش";
            btnSubmit.BackColor = Color.Yellow;
            var customer = await _customerService.GetByIdAsync((Guid)CustomerId);
            if (customer != null)
            {
                txtFullName.Text = customer.FullName;
                txtMobile.Text = customer.Mobile;
                txtEmail.Text = customer.Email;
            }
            else this.Close();
        }
    }

    private async void btnSubmit_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(txtFullName.Text) && !string.IsNullOrEmpty(txtMobile.Text))
        {
            if (CustomerId == null)
            {
                var customer = new CreateCustomerViewModel
                {
                    FullName = txtFullName.Text,
                    Mobile = txtMobile.Text,
                    Email = txtEmail.Text
                };

                if (await _customerService.CreateCustomerAsync(customer))
                {
                    MessageBox.Show("شخص با موفقیت ثبت شد",
                    string.Empty,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    txtFullName.Text = string.Empty;
                    txtMobile.Text = string.Empty;
                    txtEmail.Text = string.Empty;
                }
            }

            var updatedCustomer = new UpdateCustomerViewModel
            {
                Id = CustomerId ?? Guid.Empty,
                FullName = txtFullName.Text,
                Mobile = txtMobile.Text,
                Email = txtEmail.Text
            };

            if (await _customerService.UpdateCustomerAsync(updatedCustomer))
                this.Close();
        }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
