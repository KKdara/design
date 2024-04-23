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
            Address.Parent = Picture3;
            Address.BackColor = Color.Transparent;
            Price.Parent = Picture3;
            Price.BackColor = Color.Transparent;
            Square.Parent = Picture3;
            Square.BackColor = Color.Transparent;
            AmountOfFloors.Parent = Picture3;
            AmountOfFloors.BackColor = Color.Transparent;
            Floor.Parent = Picture3;
            Floor.BackColor = Color.Transparent;
            ProfileButton.Parent = Picture3;
            ProfileButton.BackColor = Color.Transparent;
            ProfileButton.FlatAppearance.BorderSize = 0;
            ProfileButton.FlatStyle = FlatStyle.Flat;
            FavButton.Parent = Picture3;
            FavButton.BackColor = Color.Transparent;
            FavButton.FlatAppearance.BorderSize = 0;
            FavButton.FlatStyle = FlatStyle.Flat;
            BlackListButton.Parent = Picture3;
            BlackListButton.BackColor = Color.Transparent;
            BlackListButton.FlatAppearance.BorderSize = 0;
            BlackListButton.FlatStyle = FlatStyle.Flat;
            MyListsButton.Parent = Picture3;
            MyListsButton.BackColor = Color.Transparent;
            MyListsButton.FlatAppearance.BorderSize = 0;
            MyListsButton.FlatStyle = FlatStyle.Flat;
            BackButton.Parent = Picture3;
            BackButton.BackColor = Color.Transparent;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            StraightButton.Parent = Picture3;
            StraightButton.BackColor = Color.Transparent;
            StraightButton.FlatAppearance.BorderSize = 0;
            StraightButton.FlatStyle = FlatStyle.Flat;
            AddButton.Parent = Picture3;
            AddButton.BackColor = Color.Transparent;
            AddButton.FlatAppearance.BorderSize = 0;
            AddButton.FlatStyle = FlatStyle.Flat;
            EstimateButton.Parent = Picture3;
            EstimateButton.BackColor = Color.Transparent;
            EstimateButton.FlatAppearance.BorderSize = 0;
            EstimateButton.FlatStyle = FlatStyle.Flat;
            AddressText.Parent = Picture3;
            AddressText.BackColor = Color.Transparent;
            PriceText.Parent = Picture3;
            PriceText.BackColor = Color.Transparent;
            SquareText.Parent = Picture3;
            SquareText.BackColor = Color.Transparent;
            FloorText.Parent = Picture3;
            FloorText.BackColor = Color.Transparent;
            AddFavButton.Parent = Picture3;
            AddFavButton.BackColor = Color.Transparent;
            AddFavButton.FlatAppearance.BorderSize = 0;
            AddFavButton.FlatStyle = FlatStyle.Flat;
            AddBlackListButton.Parent = Picture3;
            AddBlackListButton.BackColor = Color.Transparent;
            AddBlackListButton.FlatAppearance.BorderSize = 0;
            AddBlackListButton.FlatStyle = FlatStyle.Flat;
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.ShowDialog();
            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddList addList = new AddList();
            addList.ShowDialog();
        }

        private void FormMyRecommendationButton_Click(object sender, EventArgs e)
        {
            TestFirstWindow testFirstWindow = new TestFirstWindow();
            testFirstWindow.ShowDialog();
            this.Close();
        }

        private void FavButton_Click(object sender, EventArgs e)
        {
            Favorite favorite = new Favorite();
            favorite.ShowDialog();
        }

        private void BlackListButton_Click(object sender, EventArgs e)
        {
            BlackList blackList = new BlackList();
            blackList.ShowDialog();
        }

        private void MyListsButton_Click(object sender, EventArgs e)
        {
            MyCollections myCollections = new MyCollections();
            myCollections.ShowDialog();
        }

        private void EstimateButton_Click(object sender, EventArgs e)
        {
            MarkWindow markWindow = new MarkWindow();
            markWindow.ShowDialog();
        }
    }
}
