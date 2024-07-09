using System;
using System.Windows.Forms;

namespace AddressBookApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string email = emailTextBox.Text;
            string phone = phoneTextBox.Text;

            MessageBox.Show($"Name: {name}\nEmail: {email}\nPhone: {phone}", "Saved Information");
        }
    }
}
