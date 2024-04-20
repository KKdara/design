using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace design
{
    public partial class TestSecondWindow : Form
    {
        public TestSecondWindow()
        {
            InitializeComponent();
            Text1.Parent = Picture8;
            Text1.BackColor = Color.Transparent;
        }

        private void Photo1_Click(object sender, EventArgs e)
        {
            Card card = new Card();
            card.Show();
        }
    }
}
