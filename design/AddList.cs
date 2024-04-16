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
    public partial class AddList : Form
    {
        public AddList()
        {
            InitializeComponent();
            Text1.Parent = Picture4;
            Text1.BackColor = Color.Transparent;
            AddFavButton.Parent = Picture4;
            AddFavButton.BackColor = Color.Transparent;
            ChooseButton.Parent = Picture4;
            ChooseButton.BackColor = Color.Transparent;
        }

        private void CreateCollectionButton_Click(object sender, EventArgs e)
        {
            CreateNewList createNewList = new CreateNewList();
            createNewList.ShowDialog();
        }
    }
}
