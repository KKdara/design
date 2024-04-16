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
    public partial class CreateNewList : Form
    {
        public CreateNewList()
        {
            InitializeComponent();
            Text1.Parent = Picture5;
            Text1.BackColor = Color.Transparent;
            Text2.Parent = Picture5;
            Text2.BackColor = Color.Transparent;
            Text3.Parent = Picture5;
            Text3.BackColor = Color.Transparent;
        }
    }
}
