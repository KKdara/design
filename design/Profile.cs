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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
            SaveButton.Hide();
            label1.Parent = Picture4;
            label1.BackColor = Color.Transparent;
            label2.Parent = Picture4;
            label2.BackColor = Color.Transparent;
            label3.Parent = Picture4;
            label3.BackColor = Color.Transparent;
            label4.Parent = Picture4;   
            label4.BackColor = Color.Transparent;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            SaveButton.Show();
        }
    }
}
