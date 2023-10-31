using System.Data;

namespace PhoneBook
{
    public partial class frmPhoneDiary : Form
    {
        public frmPhoneDiary()
        {
            InitializeComponent();
        }

        DataTable contacts = new DataTable();
        bool editing = false;

        private void frmPhoneDiary_Load(object sender, EventArgs e)
        {
            contacts.Columns.Add("First Name");
            contacts.Columns.Add("Last Name");
            contacts.Columns.Add("Phone Number");
            contacts.Columns.Add("Email");

            PhoneBook.DataSource = contacts;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                contacts.Rows[PhoneBook.CurrentCell.RowIndex]["First Name"] = txtFirstName.Text;
                contacts.Rows[PhoneBook.CurrentCell.RowIndex]["Last Name"] = txtLastName.Text;
                contacts.Rows[PhoneBook.CurrentCell.RowIndex]["Phone Number"] = txtPhoneNumber.Text;
                contacts.Rows[PhoneBook.CurrentCell.RowIndex]["Email"] = txtEmail.Text;
            }
            else
            {
                contacts.Rows.Add(txtFirstName.Text, txtLastName.Text, txtPhoneNumber.Text, txtEmail.Text);

                txtFirstName.Clear();
                txtLastName.Clear();
                txtEmail.Clear();
                txtPhoneNumber.Clear();
                editing = false;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = contacts.Rows[PhoneBook.CurrentCell.RowIndex]["First Name"].ToString();
            txtLastName.Text = contacts.Rows[PhoneBook.CurrentCell.RowIndex]["Last Name"].ToString();
            txtPhoneNumber.Text = contacts.Rows[PhoneBook.CurrentCell.RowIndex]["Phone Number"].ToString();
            txtEmail.Text = contacts.Rows[PhoneBook.CurrentCell.RowIndex]["Email"].ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhoneNumber.Clear();
            editing = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            contacts.Rows[PhoneBook.CurrentCell.RowIndex].Delete();
        }


    }
}