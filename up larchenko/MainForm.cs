using System;
using System.Windows.Forms;
using up_larchenko;

namespace up_larchenko
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            // Заполняем ComboBox
            cmbClass.Items.AddRange(new string[] { "Воин", "Маг", "Вор", "Паладин" });
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string nickname = txtNickName.Text.Trim();
            string characterClass = cmbClass.SelectedItem?.ToString() ?? "";
            string backstory = txtBackStory.Text.Trim();

            if (string.IsNullOrEmpty(nickname)) nickname = "Безымянный раб";
            if (string.IsNullOrEmpty(backstory)) backstory = "Просто путник";

            if (string.IsNullOrEmpty(characterClass))
            {
                MessageBox.Show("Выберите класс персонажа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var player = GetPlayerData(nickname, characterClass, backstory);
            PrintCard(player);
        }

        private Player GetPlayerData(string nickname, string characterClass, string backstory)
        {
            return new Player
            {
                Nickname = nickname,
                Class = characterClass,
                Backstory = backstory
            };
        }

        private void PrintCard(Player player)
        {
            var cardForm = new CharacterCardForm(player);
            cardForm.FormClosed += (s, args) => this.Close(); // закрыть главную форму при закрытии карточки
            cardForm.Show();
            this.Hide(); // скрыть главную форму
        }
    }
}