using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace design
{
    public partial class OpenWindow : Form
    {
        public OpenWindow()
        {
            InitializeComponent();
            MaximizeBox = false;
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;

        }

        private void LoginText_Click(object sender, EventArgs e)
        {
            LoginTextAutho.Clear();
        }
        private void PasswordText_Click(object sender, EventArgs e)
        {
            PasswordTextAutho.Clear();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            RegistrationWindow reg_win = new RegistrationWindow();
            reg_win.ShowDialog();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.ShowDialog();
            this.Hide();

        }
    }
}
