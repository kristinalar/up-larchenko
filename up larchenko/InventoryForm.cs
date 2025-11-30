using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace up_larchenko
{
    public partial class InventoryForm : Form
    {
        private Player player;
        public InventoryForm(Player player)
        {
            InitializeComponent();
            this.player = player;
            LoadShopItems();
            UpdateDisplay();
        }

        private void LoadShopItems()
        {
            // Товары торговца: название + цена в скобках
            cmbShop.Items.Add("Меч (1000)");
            cmbShop.Items.Add("Щит (800)");
            cmbShop.Items.Add("Зелье лечения (50)");
            cmbShop.Items.Add("Плащ невидимости (300)");
        }

        private List<Item> inventory = new List<Item>
{
    new Item { Name = "Неопознанный перстень", RecognizedName = "Кольцо ловкости", Price = 120 },
    new Item { Name = "Ржавый кинжал",        RecognizedName = "Кинжал вора", Price = 45 },
    new Item { Name = "Потрёпанная книга",    RecognizedName = "Гримуар мага", Price = 200 },
    new Item { Name = "Старая бутылка",       RecognizedName = "Зелье маны", Price = 30 },
    new Item { Name = "Сломанный амулет",     RecognizedName = "Амулет защиты", Price = 80 },
    new Item { Name = "Гнилая палка",         RecognizedName = "Посох друида", Price = 25 },
    new Item { Name = "Блестящий камень",     RecognizedName = "Драгоценный рубин", Price = 500 }
};

        private int wallet = 0; // Кошелёк

        private void UpdateDisplay()
        {
            lstItems.Items.Clear();
            foreach (var item in inventory)
            {
                lstItems.Items.Add(item.DisplayName);
            }

            lblTotalItems.Text = $"Всего предметов: {inventory.Count}";

            int totalValue = 0;
            foreach (var item in inventory)
            {
                totalValue += item.Price;
            }
            lblTotalValue.Text = $"Общая стоимость: {totalValue}";

            lblWallet.Text = $"Кошелёк: {wallet}";
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            foreach (var item in inventory)
            {
                item.IsRecognized = true; // Опознали всё!
            }
            UpdateDisplay();
            MessageBox.Show("Все предметы опознаны!", "Анализ завершён", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSellJunk_Click(object sender, EventArgs e)
        {
            var junkItems = new List<Item>();

            // Находим хлам
            foreach (var item in inventory)
            {
                if (item.Price < 50)
                {
                    junkItems.Add(item);
                }
            }

            if (junkItems.Count == 0)
            {
                MessageBox.Show("Нет предметов дешевле 50 монет!", "Нечего продавать", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Продаём
            foreach (var item in junkItems)
            {
                wallet += item.Price;
                inventory.Remove(item);
            }

            UpdateDisplay();
            MessageBox.Show($"Продано {junkItems.Count} предметов на сумму {junkItems.Sum(i => i.Price)} монет!", "Успешная продажа", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (cmbShop.SelectedItem == null)
            {
                MessageBox.Show("Выберите товар для покупки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedItem = cmbShop.SelectedItem.ToString();

            // Извлекаем цену из строки вида "Меч (1000)"
            int open = selectedItem.LastIndexOf('(');
            int close = selectedItem.LastIndexOf(')');
            if (open == -1 || close == -1 || !int.TryParse(selectedItem.Substring(open + 1, close - open - 1), out int price))
            {
                MessageBox.Show("Некорректный формат товара!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string itemName = selectedItem.Substring(0, open).Trim();

            if (wallet < price)
            {
                MessageBox.Show("Не хватает золота!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Покупка
            wallet -= price;
            inventory.Add(new Item
            {
                Name = itemName,
                RecognizedName = itemName,
                Price = price,
                IsRecognized = true
            });

            UpdateDisplay();
            MessageBox.Show($"Куплено: {itemName} за {price} монет!", "Покупка успешна", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
