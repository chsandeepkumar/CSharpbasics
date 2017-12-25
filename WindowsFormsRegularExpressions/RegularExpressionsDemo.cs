using System;
using System.Windows.Forms;

namespace WindowsFormsRegularExpressions
{
    public partial class RegularExpressionForm : Form
    {
        public RegularExpressionForm() => InitializeComponent();

        private void SubmitButton_Click(object sender, EventArgs e)
        {

            User userInstance = new User
            {
                EmailId = emailIdTextBox.Text,
                Phoneumber = phoneNumberTextbox.Text,
                Zipcode = zipCodeTextBox.Text
            };
            if (ValidationService.DoesUserInputValid(userInstance))
            {
                MessageBox.Show("All User inputs are valid");
            }
            else
            {
                MessageBox.Show("All User inputs are not valid");
            }
        }

        
    }
}
