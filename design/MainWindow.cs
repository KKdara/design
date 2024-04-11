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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            label1.Parent = Picture3;
            label1.BackColor = Color.Transparent;
            ProfileButton.Parent = Picture3;
            ProfileButton.BackColor = Color.Transparent;
            ProfileButton.FlatAppearance.BorderSize = 0;
            ProfileButton.FlatStyle = FlatStyle.Flat;
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.ShowDialog();
            this.Close();
        }
    }
}
