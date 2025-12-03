using System;
using System.Windows.Forms;
using up_larchenko;

namespace up_larchenko
{
    public partial class AfterDoorForm : Form
    {
        private Player player; 

        public AfterDoorForm(Player player)
        {
            InitializeComponent();
            this.player = player;

            this.Text = "После двери";
            this.Size = new Size(300, 150);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void btnOpenInventory_Click(object sender, EventArgs e)
        {
            var inventoryForm = new InventoryForm(this.player);
            inventoryForm.Show();
        }

        private void BtnDungeon1_Click(object sender, EventArgs e)
        {
            var dungeonForm = new DungeonForm(player);
            dungeonForm.FormClosed += (s, args) => this.Close(); 
            dungeonForm.ShowDialog();
        }
    }
}