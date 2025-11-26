using System;
using System.Drawing;
using System.Windows.Forms;
using up_larchenko;

namespace up_larchenko
{
    public partial class CharacterCardForm : Form
    {
        private Player player;

        public CharacterCardForm(Player player)
        {
            InitializeComponent();
            this.player = player;

            // Обновляем текст меток
            lblNickname.Text = $"Имя: {player.Nickname}";
            lblClass.Text = $"Класс: {player.Class}";
            lblBackstory.Text = $"Предыстория: {player.Backstory}";

            // Настройки формы
            this.Text = "Карточка персонажа";
            this.Size = new Size(400, 250);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var statsForm = new CharacterStatsForm(player);
            statsForm.FormClosed += (s, args) => this.Close();
            statsForm.Show();
            this.Hide();
        }
    }
}