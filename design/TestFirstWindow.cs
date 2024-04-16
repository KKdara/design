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
    public partial class TestFirstWindow : Form
    {
        public TestFirstWindow()
        {
            InitializeComponent();
            label1.Parent = Picture7;
            label1.BackColor = Color.Transparent;
            Town.Parent = Picture7;
            Town.BackColor = Color.Transparent;
            TypeOfRealty.Parent = Picture7;
            TypeOfRealty.BackColor = Color.Transparent;
            Purpose.Parent = Picture7;
            Purpose.BackColor = Color.Transparent;
        }
    }
}
