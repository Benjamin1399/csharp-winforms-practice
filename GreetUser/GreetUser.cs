using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreetUser
{
    public partial class GreetUser : Form
    {
        public GreetUser()
        {
            InitializeComponent();
        }

        private void greetButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hello, {firstNameTextBox.Text} {lastNameTextBox.Text}", 
                "Greeting Application",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);

            ResetDataEntryUI();
        }

        private void ResetDataEntryUI()
        {
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            firstNameTextBox.Focus();
        }

        private void goodbyeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
