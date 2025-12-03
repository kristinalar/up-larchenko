using System;
using System.Drawing;
using System.Windows.Forms;

namespace up_larchenko
{
    public partial class DungeonForm : Form
    {
        private enum EnemyType { NONE = 0, WEAK = 1, NORMAL = 2, STRONG = 3 }

        private const int MAP_SIZE = 10;
        private const int CELL_SIZE = 30;
        private const int MINIMAP_CELL_SIZE = 15;

        private int[,] dungeon;
        private EnemyType[,] enemyType;
        private bool[,] chestOpened; 
        private bool[,] restUsed;
        private bool[,] explored;

        private Player player;
        private int playerX = 1, playerY = 1;
        private int currentLevel = 1;
        private Random rand = new Random();

        public DungeonForm(Player player)
        {
            InitializeComponent();
            this.player = player;
            GenerateDungeon(currentLevel);
        }

        private void GenerateDungeon(int level)
        {
            dungeon = new int[MAP_SIZE, MAP_SIZE];
            enemyType = new EnemyType[MAP_SIZE, MAP_SIZE];
            chestOpened = new bool[MAP_SIZE, MAP_SIZE];
            restUsed = new bool[MAP_SIZE, MAP_SIZE];
            explored = new bool[MAP_SIZE, MAP_SIZE];

            for (int i = 0; i < MAP_SIZE; i++)
                for (int j = 0; j < MAP_SIZE; j++)
                    dungeon[i, j] = 0;

            int targetRooms = rand.Next(50, 61); 
            int currentRooms = 1; 

            dungeon[1, 1] = 1;
            explored[1, 1] = true;

            int[] dx = { 0, 1, 0, -1 };
            int[] dy = { -1, 0, 1, 0 };

            while (currentRooms < targetRooms)
            {
                int startX = rand.Next(1, MAP_SIZE - 1);
                int startY = rand.Next(1, MAP_SIZE - 1);

                if (dungeon[startX, startY] != 1) continue;

                int dir = rand.Next(4);
                int newX = startX + dx[dir];
                int newY = startY + dy[dir];

                if (newX > 0 && newX < MAP_SIZE - 1 && newY > 0 && newY < MAP_SIZE - 1 && dungeon[newX, newY] == 0)
                {
                    dungeon[newX, newY] = 1;
                    currentRooms++;
                }
            }

            var config = level switch
            {
                1 => (weak: 3, normal: 2, strong: 0),
                2 => (weak: 2, normal: 3, strong: 1),
                3 => (weak: 1, normal: 3, strong: 2),
                _ => (weak: 0, normal: 4, strong: 3)
            };

            PlaceEnemies(EnemyType.WEAK, config.weak);
            PlaceEnemies(EnemyType.NORMAL, config.normal);
            PlaceEnemies(EnemyType.STRONG, config.strong);

            PlaceObjects(3, 2 + rand.Next(2));

            PlaceObjects(4, 1 + rand.Next(2));

            playerX = 1; playerY = 1;
            explored[1, 1] = true;
            currentLevel = level;

            UpdateAll();
        }

        private void PlaceEnemies(EnemyType type, int count)
        {
            for (int i = 0; i < count; i++)
            {
                (int x, int y) = GetRandomFreeCell();
                dungeon[x, y] = 2;
                enemyType[x, y] = type;
            }
        }

        private void PlaceObjects(int objType, int count)
        {
            for (int i = 0; i < count; i++)
            {
                (int x, int y) = GetRandomFreeCell();
                dungeon[x, y] = objType;
            }
        }

        private (int, int) GetRandomFreeCell()
        {
            while (true)
            {
                int x = rand.Next(1, MAP_SIZE - 1);
                int y = rand.Next(1, MAP_SIZE - 1);
                if (dungeon[x, y] == 1) return (x, y);
            }
        }

        private void DrawMap()
        {
            mapPanel.Controls.Clear();
            for (int y = 0; y < MAP_SIZE; y++)
            {
                for (int x = 0; x < MAP_SIZE; x++)
                {
                    Label cell = new Label
                    {
                        Size = new Size(CELL_SIZE, CELL_SIZE),
                        Location = new Point(x * CELL_SIZE, y * CELL_SIZE),
                        TextAlign = ContentAlignment.MiddleCenter,
                        Font = new Font("Arial", 8, FontStyle.Bold)
                    };

                    Color backColor = Color.Gray;
                    string text = "";

                    switch (dungeon[x, y])
                    {
                        case 0: backColor = Color.FromArgb(51, 51, 51); break;
                        case 1: backColor = Color.LightGray; break;
                        case 2:
                            backColor = enemyType[x, y] switch
                            {
                                EnemyType.WEAK => Color.Yellow,
                                EnemyType.NORMAL => Color.Orange,
                                EnemyType.STRONG => Color.Red,
                                _ => Color.Black
                            };
                            text = enemyType[x, y] == EnemyType.STRONG ? "⚡" : "E";
                            break;
                        case 3: backColor = Color.Gold; text = "C"; break;
                        case 4: backColor = Color.LightGreen; text = "R+"; break;
                        case 5: backColor = Color.Cyan; text = "Ex+"; break;
                    }

                    if (x == playerX && y == playerY)
                    {
                        backColor = Color.LimeGreen;
                        text = "@";
                    }

                    cell.BackColor = backColor;
                    cell.Text = text;
                    mapPanel.Controls.Add(cell);
                }
            }
            DrawMinimap();
        }

        private void DrawMinimap()
        {
            minimapPanel.Controls.Clear();
            for (int y = 0; y < MAP_SIZE; y++)
            {
                for (int x = 0; x < MAP_SIZE; x++)
                {
                    Panel cell = new Panel
                    {
                        Size = new Size(MINIMAP_CELL_SIZE, MINIMAP_CELL_SIZE),
                        Location = new Point(x * MINIMAP_CELL_SIZE, y * MINIMAP_CELL_SIZE)
                    };

                    if (dungeon[x, y] == 0) cell.BackColor = Color.Gray;
                    else if (explored[x, y]) cell.BackColor = Color.White;
                    else cell.BackColor = Color.DarkGray;

                    if (x == playerX && y == playerY)
                    {
                        cell.Controls.Add(new Panel { Size = new Size(8, 8), Location = new Point(3, 3), BackColor = Color.Green });
                    }

                    minimapPanel.Controls.Add(cell);
                }
            }
        }

        private void MovePlayer(int dx, int dy)
        {
            int newX = playerX + dx, newY = playerY + dy;
            if (newX < 0 || newX >= MAP_SIZE || newY < 0 || newY >= MAP_SIZE || dungeon[newX, newY] == 0) return;
            playerX = newX; playerY = newY;
            explored[playerX, playerY] = true;
            HandleCellContent();
            UpdateAll();
        }

        private void HandleCellContent()
        {
            switch (dungeon[playerX, playerY])
            {
                case 2:
                    FightEnemy();
                    break;
                case 3:
                    OpenChest();
                    break;
                case 4:
                    UseRestPoint();
                    break;
                case 5:
                    GoToNextLevel();
                    break;
            }
        }

        private void FightEnemy()
        {
            EnemyType type = enemyType[playerX, playerY];
            int hp = type switch { EnemyType.WEAK => 20, EnemyType.NORMAL => 40, EnemyType.STRONG => 60 };
            int minDmg = type switch { EnemyType.WEAK => 3, EnemyType.NORMAL => 5, EnemyType.STRONG => 8 };
            int maxDmg = type switch { EnemyType.WEAK => 7, EnemyType.NORMAL => 10, EnemyType.STRONG => 15 };
            int gold = type switch { EnemyType.WEAK => rand.Next(5, 11), EnemyType.NORMAL => rand.Next(15, 26), EnemyType.STRONG => rand.Next(30, 51) };
            int exp = type switch { EnemyType.WEAK => 10, EnemyType.NORMAL => 25, EnemyType.STRONG => 50 };

            while (player.CurrentHP > 0 && hp > 0)
            {
                hp -= player.GetTotalDamage();
                if (hp <= 0) break;

                int dmg = rand.Next(minDmg, maxDmg + 1);
                int reducedDmg = player.ReduceDamage(dmg);
                player.CurrentHP -= player.ReduceDamage(dmg);
            }

            if (hp <= 0)
            {
                player.Gold += gold;
                player.Experience += exp;
                logBox.AppendText($"Враг побеждён! +{gold} золота, +{exp} опыта\n");
                dungeon[playerX, playerY] = 1;
                enemyType[playerX, playerY] = EnemyType.NONE;
            }
            else
            {
                logBox.AppendText("Ты пал в бою...\n");

                player.CurrentHP = player.MaxHP;

                playerX = 1;
                playerY = 1;
                explored[playerX, playerY] = true;
            }

            UpdateAll();
        }


        private void OpenChest()
        {
            int r = rand.Next(100);
            string loot = "";
            if (r < 50)
            {
                loot = rand.Next(2) == 0 ? "Меч" : "Боевой топор";
                player.Weapon = loot;
            }
            else if (r < 80)
            {
                loot = rand.Next(2) == 0 ? "Кожаная" : "Стальная";
                player.Armor = loot;
            }
            else if (r < 95)
            {
                loot = "Зелье";
                player.Potions++;
            }
            else loot = "Хлам";

            logBox.AppendText($"Ты открыл сундук! Получено: {loot}\n");
            dungeon[playerX, playerY] = 1;
            UpdateInventoryList();
        }

        private void UseRestPoint()
        {
            if (MessageBox.Show("Найдена комната отдыха! Восстановить HP?", "Отдых", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                player.CurrentHP = Math.Min(player.MaxHP, player.CurrentHP + player.MaxHP / 2);
                logBox.AppendText("Ты отдохнул... HP восстановлено!\n");
                dungeon[playerX, playerY] = 1;
            }
        }

        private void GoToNextLevel()
        {
            if (currentLevel == 5)
            {
                logBox.AppendText("Поздравляем! Ты прошёл подземелье!\n");
                return;
            }

            var result = MessageBox.Show(
                $"Ты нашёл выход! Перейти на уровень {currentLevel + 1}?",
                "Уровень пройден",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.Yes)
            {
                currentLevel++;
                GenerateDungeon(currentLevel);
            }
        }

        private void UpdateInventoryList()
        {
            inventoryList.Items.Clear();
            inventoryList.Items.Add($"Оружие: {player.Weapon}");
            inventoryList.Items.Add($"Броня: {player.Armor}");
            inventoryList.Items.Add($"Зелья: {player.Potions}");
        }

        private void UpdateAll()
        {
            lblHP.Text = $"HP: {player.CurrentHP}/{player.MaxHP}";
            hpBar.Value = Math.Max(0, Math.Min(100, player.CurrentHP));
            lblStrength.Text = $"Сила: {player.Strength}";
            lblWeapon.Text = $"Вооружение: {player.Weapon}";
            lblArmor.Text = $"Броня: {player.Armor}";
            lblGold.Text = $"Золото: {player.Gold}";
            lblExp.Text = $"Опыт: {player.Experience}";
            lblPotions.Text = $"Зелья: {player.Potions}";
            lblLevel.Text = $"Уровень: {currentLevel} из 5";
            lblPosition.Text = $"Позиция: ({playerX}, {playerY})";

            int weak = 0, normal = 0, strong = 0, chests = 0, rest = 0, exploredCount = 0;
            for (int x = 0; x < MAP_SIZE; x++)
                for (int y = 0; y < MAP_SIZE; y++)
                {
                    if (dungeon[x, y] == 2)
                    {
                        if (enemyType[x, y] == EnemyType.WEAK) weak++;
                        else if (enemyType[x, y] == EnemyType.NORMAL) normal++;
                        else if (enemyType[x, y] == EnemyType.STRONG) strong++;
                    }
                    else if (dungeon[x, y] == 3) chests++;
                    else if (dungeon[x, y] == 4) rest++;
                    if (explored[x, y]) exploredCount++;
                }

            lblEnemiesLeft.Text = $"Врагов осталось: {weak + normal + strong}";
            lblWeak.Text = $"Слабых: {weak}";
            lblNormal.Text = $"Обычных: {normal}";
            lblStrong.Text = $"Сильных: {strong}";
            lblChests.Text = $"Сундуков закрытых: {chests}";
            lblRest.Text = $"Мест отдыха: {rest}";
            lblExplored.Text = $"Исследовано: {(exploredCount * 100 / (MAP_SIZE * MAP_SIZE))}%";

            if (weak + normal + strong == 0)
            {
                (int x, int y) = GetRandomFreeCell();
                dungeon[x, y] = 5; 
            }

            DrawMap();
        }

        private void btnW_Click(object sender, EventArgs e) => MovePlayer(0, -1);
        private void btnA_Click(object sender, EventArgs e) => MovePlayer(-1, 0);
        private void btnS_Click(object sender, EventArgs e) => MovePlayer(0, 1);
        private void btnD_Click(object sender, EventArgs e) => MovePlayer(1, 0);
        private void btnNewMap_Click(object sender, EventArgs e) => GenerateDungeon(currentLevel);
        private void btnUsePotion_Click(object sender, EventArgs e)
        {
            if (player.Potions > 0)
            {
                player.CurrentHP = Math.Min(player.MaxHP, player.CurrentHP + 50);
                player.Potions--;
                logBox.AppendText("Выпил зелье! +50 HP\n");
            }
            else
            {
                MessageBox.Show("У тебя не осталось зелий!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            UpdateAll();
        }
    }
}
