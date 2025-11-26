using System;
using System.Drawing;
using System.Windows.Forms;
using up_larchenko;

namespace up_larchenko
{
    public partial class CharacterStatsForm : Form
    {
        private const int TOTAL_POINTS = 20;
        private Player player;

        public CharacterStatsForm(Player player)
        {
            InitializeComponent();
            this.player = player;
            this.Text = "Распределение характеристик";
            this.Size = new Size(400, 250);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Подписываемся на события изменения значений
            numStrength.ValueChanged += OnStatChanged;
            numDexterity.ValueChanged += OnStatChanged;
            numIntelligence.ValueChanged += OnStatChanged;
        }

        private void OnStatChanged(object sender, EventArgs e)
        {
            int totalUsed = (int)numStrength.Value + (int)numDexterity.Value + (int)numIntelligence.Value;
            int remaining = TOTAL_POINTS - totalUsed;

            lblRemaining.Text = $"Осталось очков: {remaining}";

            if (remaining < 0)
                lblRemaining.ForeColor = Color.Red;
            else if (remaining > 0)
                lblRemaining.ForeColor = Color.Orange;
            else
                lblRemaining.ForeColor = Color.Green;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int totalUsed = (int)numStrength.Value + (int)numDexterity.Value + (int)numIntelligence.Value;

            if (totalUsed > TOTAL_POINTS)
            {
                MessageBox.Show("Слишком много очков! У тебя только 20.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (totalUsed < TOTAL_POINTS)
            {
                var result = MessageBox.Show("У тебя остались нераспределённые очки. Продолжить?", "Внимание",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No) return;
            }

            // Сохраняем характеристики
            player.Strength = (int)numStrength.Value;
            player.Dexterity = (int)numDexterity.Value;
            player.Intelligence = (int)numIntelligence.Value;

            // Часть 2 — проверка силы
            TestDoorStrength(player.Strength);

            this.Close();
        }

        private void TestDoorStrength(int strength)
        {
            string message = "";

            if (strength < 5)
                message = "Ты пытаешься выбить дверь плечом… и ломаешь себе ключицу";
            else if (strength >= 5 && strength <= 9)
                message = "Дверь отвечает глухим звуком на твою жалкую попытку ее открыть";
            else if (strength >= 10 && strength <= 14)
                message = "Сильным движением руки, ты отпираешь дверь";
            else if (strength >= 15 && strength <= 19)
                message = "Дверь разлетелась в щепки от твоего удара!";
            else if (strength >= 20)
                message = "ТЫДЫЩ!!!!! Дверь не просто открывается — её выбивает ударная волна!";

            MessageBox.Show(message, "Испытание двери", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}