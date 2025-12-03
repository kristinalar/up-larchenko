namespace up_larchenko
{
    partial class DungeonForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DungeonForm));
            mapPanel = new Panel();
            minimapPanel = new Panel();
            logBox = new RichTextBox();
            inventoryList = new ListBox();
            grpInventory = new GroupBox();
            btnUsePotion = new Button();
            lblMinimap = new Label();
            grpStatus = new GroupBox();
            lblArmor = new Label();
            lblWeapon = new Label();
            lblStrength = new Label();
            hpBar = new ProgressBar();
            lblHP = new Label();
            grpResources = new GroupBox();
            lblPotions = new Label();
            lblExp = new Label();
            lblGold = new Label();
            grpStats = new GroupBox();
            lblExplored = new Label();
            lblRest = new Label();
            lblChests = new Label();
            lblStrong = new Label();
            lblNormal = new Label();
            lblWeak = new Label();
            lblEnemiesLeft = new Label();
            lblPosition = new Label();
            lblLevel = new Label();
            grpControl = new GroupBox();
            btnNewMap = new Button();
            btnD = new Button();
            btnA = new Button();
            btnS = new Button();
            btnW = new Button();
            lblLog = new Label();
            grpInventory.SuspendLayout();
            grpStatus.SuspendLayout();
            grpResources.SuspendLayout();
            grpStats.SuspendLayout();
            grpControl.SuspendLayout();
            SuspendLayout();
            // 
            // mapPanel
            // 
            mapPanel.BackColor = Color.White;
            mapPanel.Location = new Point(20, 60);
            mapPanel.Name = "mapPanel";
            mapPanel.Size = new Size(400, 400);
            mapPanel.TabIndex = 0;
            // 
            // minimapPanel
            // 
            minimapPanel.BackColor = Color.White;
            minimapPanel.Location = new Point(450, 60);
            minimapPanel.Name = "minimapPanel";
            minimapPanel.Size = new Size(150, 150);
            minimapPanel.TabIndex = 1;
            // 
            // logBox
            // 
            logBox.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            logBox.Location = new Point(20, 700);
            logBox.Name = "logBox";
            logBox.ReadOnly = true;
            logBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            logBox.Size = new Size(1050, 95);
            logBox.TabIndex = 2;
            logBox.Text = "";
            // 
            // inventoryList
            // 
            inventoryList.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            inventoryList.FormattingEnabled = true;
            inventoryList.IntegralHeight = false;
            inventoryList.ItemHeight = 17;
            inventoryList.Location = new Point(10, 20);
            inventoryList.Name = "inventoryList";
            inventoryList.Size = new Size(200, 120);
            inventoryList.TabIndex = 3;
            // 
            // grpInventory
            // 
            grpInventory.Controls.Add(btnUsePotion);
            grpInventory.Controls.Add(inventoryList);
            grpInventory.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grpInventory.Location = new Point(350, 480);
            grpInventory.Name = "grpInventory";
            grpInventory.Size = new Size(220, 180);
            grpInventory.TabIndex = 4;
            grpInventory.TabStop = false;
            grpInventory.Text = "Инвентарь";
            // 
            // btnUsePotion
            // 
            btnUsePotion.Location = new Point(10, 145);
            btnUsePotion.Name = "btnUsePotion";
            btnUsePotion.Size = new Size(200, 30);
            btnUsePotion.TabIndex = 4;
            btnUsePotion.Text = "Использовать зелье";
            btnUsePotion.UseVisualStyleBackColor = true;
            btnUsePotion.Click += btnUsePotion_Click;
            // 
            // lblMinimap
            // 
            lblMinimap.AutoSize = true;
            lblMinimap.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblMinimap.Location = new Point(450, 40);
            lblMinimap.Name = "lblMinimap";
            lblMinimap.Size = new Size(94, 17);
            lblMinimap.TabIndex = 5;
            lblMinimap.Text = "Миникарта:";
            // 
            // grpStatus
            // 
            grpStatus.BackColor = Color.LightGray;
            grpStatus.Controls.Add(lblArmor);
            grpStatus.Controls.Add(lblWeapon);
            grpStatus.Controls.Add(lblStrength);
            grpStatus.Controls.Add(hpBar);
            grpStatus.Controls.Add(lblHP);
            grpStatus.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grpStatus.Location = new Point(620, 60);
            grpStatus.Name = "grpStatus";
            grpStatus.Size = new Size(220, 140);
            grpStatus.TabIndex = 6;
            grpStatus.TabStop = false;
            grpStatus.Text = "Статус героя";
            // 
            // lblArmor
            // 
            lblArmor.Location = new Point(10, 120);
            lblArmor.Name = "lblArmor";
            lblArmor.Size = new Size(200, 20);
            lblArmor.TabIndex = 4;
            lblArmor.Text = "Броня: Кожаная";
            // 
            // lblWeapon
            // 
            lblWeapon.Location = new Point(10, 95);
            lblWeapon.Name = "lblWeapon";
            lblWeapon.Size = new Size(200, 20);
            lblWeapon.TabIndex = 3;
            lblWeapon.Text = "Вооружение: Меч";
            // 
            // lblStrength
            // 
            lblStrength.Location = new Point(10, 70);
            lblStrength.Name = "lblStrength";
            lblStrength.Size = new Size(200, 20);
            lblStrength.TabIndex = 2;
            lblStrength.Text = "Сила: 15";
            // 
            // hpBar
            // 
            hpBar.ForeColor = Color.Green;
            hpBar.Location = new Point(10, 45);
            hpBar.Name = "hpBar";
            hpBar.Size = new Size(200, 20);
            hpBar.TabIndex = 1;
            hpBar.Value = 100;
            // 
            // lblHP
            // 
            lblHP.Location = new Point(10, 20);
            lblHP.Name = "lblHP";
            lblHP.Size = new Size(150, 20);
            lblHP.TabIndex = 0;
            lblHP.Text = "HP: 100/100";
            // 
            // grpResources
            // 
            grpResources.BackColor = Color.LightGray;
            grpResources.Controls.Add(lblPotions);
            grpResources.Controls.Add(lblExp);
            grpResources.Controls.Add(lblGold);
            grpResources.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grpResources.Location = new Point(620, 220);
            grpResources.Name = "grpResources";
            grpResources.Size = new Size(220, 90);
            grpResources.TabIndex = 7;
            grpResources.TabStop = false;
            grpResources.Text = "Ресурсы";
            // 
            // lblPotions
            // 
            lblPotions.Location = new Point(10, 50);
            lblPotions.Name = "lblPotions";
            lblPotions.Size = new Size(100, 20);
            lblPotions.TabIndex = 2;
            lblPotions.Text = "Зелья: 0";
            // 
            // lblExp
            // 
            lblExp.Location = new Point(110, 20);
            lblExp.Name = "lblExp";
            lblExp.Size = new Size(100, 20);
            lblExp.TabIndex = 1;
            lblExp.Text = "Опыт: 0";
            // 
            // lblGold
            // 
            lblGold.Location = new Point(10, 20);
            lblGold.Name = "lblGold";
            lblGold.Size = new Size(100, 20);
            lblGold.TabIndex = 0;
            lblGold.Text = "Золото: 0";
            // 
            // grpStats
            // 
            grpStats.BackColor = Color.LightGray;
            grpStats.Controls.Add(lblExplored);
            grpStats.Controls.Add(lblRest);
            grpStats.Controls.Add(lblChests);
            grpStats.Controls.Add(lblStrong);
            grpStats.Controls.Add(lblNormal);
            grpStats.Controls.Add(lblWeak);
            grpStats.Controls.Add(lblEnemiesLeft);
            grpStats.Controls.Add(lblPosition);
            grpStats.Controls.Add(lblLevel);
            grpStats.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grpStats.Location = new Point(20, 480);
            grpStats.Name = "grpStats";
            grpStats.Size = new Size(300, 180);
            grpStats.TabIndex = 8;
            grpStats.TabStop = false;
            grpStats.Text = "Статистика";
            // 
            // lblExplored
            // 
            lblExplored.Location = new Point(10, 155);
            lblExplored.Name = "lblExplored";
            lblExplored.Size = new Size(280, 20);
            lblExplored.TabIndex = 17;
            lblExplored.Text = "Иследовано: 0%";
            // 
            // lblRest
            // 
            lblRest.Location = new Point(10, 130);
            lblRest.Name = "lblRest";
            lblRest.Size = new Size(280, 20);
            lblRest.TabIndex = 16;
            lblRest.Text = "Мест отдыха: 0";
            // 
            // lblChests
            // 
            lblChests.Location = new Point(10, 105);
            lblChests.Name = "lblChests";
            lblChests.Size = new Size(280, 20);
            lblChests.TabIndex = 15;
            lblChests.Text = "Сундуков закрытых: 0";
            // 
            // lblStrong
            // 
            lblStrong.Location = new Point(210, 75);
            lblStrong.Name = "lblStrong";
            lblStrong.Size = new Size(90, 20);
            lblStrong.TabIndex = 14;
            lblStrong.Text = "Сильных: 0";
            // 
            // lblNormal
            // 
            lblNormal.Location = new Point(110, 75);
            lblNormal.Name = "lblNormal";
            lblNormal.Size = new Size(95, 20);
            lblNormal.TabIndex = 13;
            lblNormal.Text = "Обычных: 0";
            // 
            // lblWeak
            // 
            lblWeak.Location = new Point(10, 75);
            lblWeak.Name = "lblWeak";
            lblWeak.Size = new Size(90, 20);
            lblWeak.TabIndex = 12;
            lblWeak.Text = "Слабых: 0";
            // 
            // lblEnemiesLeft
            // 
            lblEnemiesLeft.Location = new Point(10, 50);
            lblEnemiesLeft.Name = "lblEnemiesLeft";
            lblEnemiesLeft.Size = new Size(280, 20);
            lblEnemiesLeft.TabIndex = 11;
            lblEnemiesLeft.Text = "Врагов осталось: 0";
            // 
            // lblPosition
            // 
            lblPosition.Location = new Point(150, 20);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(140, 20);
            lblPosition.TabIndex = 10;
            lblPosition.Text = "Позиция: (1, 1)";
            // 
            // lblLevel
            // 
            lblLevel.Location = new Point(10, 20);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(120, 20);
            lblLevel.TabIndex = 9;
            lblLevel.Text = "Уровень: 1 из 5";
            // 
            // grpControl
            // 
            grpControl.BackColor = Color.LightGray;
            grpControl.Controls.Add(btnNewMap);
            grpControl.Controls.Add(btnD);
            grpControl.Controls.Add(btnA);
            grpControl.Controls.Add(btnS);
            grpControl.Controls.Add(btnW);
            grpControl.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grpControl.Location = new Point(590, 480);
            grpControl.Name = "grpControl";
            grpControl.Size = new Size(220, 180);
            grpControl.TabIndex = 9;
            grpControl.TabStop = false;
            grpControl.Text = "Управление";
            // 
            // btnNewMap
            // 
            btnNewMap.Location = new Point(20, 130);
            btnNewMap.Name = "btnNewMap";
            btnNewMap.Size = new Size(180, 30);
            btnNewMap.TabIndex = 4;
            btnNewMap.Text = "Новая карта";
            btnNewMap.UseVisualStyleBackColor = true;
            btnNewMap.Click += btnNewMap_Click;
            // 
            // btnD
            // 
            btnD.Location = new Point(130, 70);
            btnD.Name = "btnD";
            btnD.Size = new Size(50, 40);
            btnD.TabIndex = 3;
            btnD.Text = "D";
            btnD.UseVisualStyleBackColor = true;
            btnD.Click += btnD_Click;
            // 
            // btnA
            // 
            btnA.Location = new Point(20, 70);
            btnA.Name = "btnA";
            btnA.Size = new Size(50, 40);
            btnA.TabIndex = 2;
            btnA.Text = "A";
            btnA.UseVisualStyleBackColor = true;
            btnA.Click += btnA_Click;
            // 
            // btnS
            // 
            btnS.Location = new Point(75, 70);
            btnS.Name = "btnS";
            btnS.Size = new Size(50, 40);
            btnS.TabIndex = 1;
            btnS.Text = "S";
            btnS.UseVisualStyleBackColor = true;
            btnS.Click += btnS_Click;
            // 
            // btnW
            // 
            btnW.Location = new Point(75, 20);
            btnW.Name = "btnW";
            btnW.Size = new Size(50, 40);
            btnW.TabIndex = 0;
            btnW.Text = "W";
            btnW.UseVisualStyleBackColor = true;
            btnW.Click += btnW_Click;
            // 
            // lblLog
            // 
            lblLog.AutoSize = true;
            lblLog.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblLog.Location = new Point(20, 680);
            lblLog.Name = "lblLog";
            lblLog.Size = new Size(94, 17);
            lblLog.TabIndex = 10;
            lblLog.Text = "Сообщение:";
            // 
            // DungeonForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1082, 803);
            Controls.Add(lblLog);
            Controls.Add(grpControl);
            Controls.Add(grpStats);
            Controls.Add(grpResources);
            Controls.Add(grpStatus);
            Controls.Add(lblMinimap);
            Controls.Add(grpInventory);
            Controls.Add(logBox);
            Controls.Add(minimapPanel);
            Controls.Add(mapPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "DungeonForm";
            Text = "DungeonForm";
            grpInventory.ResumeLayout(false);
            grpStatus.ResumeLayout(false);
            grpResources.ResumeLayout(false);
            grpStats.ResumeLayout(false);
            grpControl.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel mapPanel;
        private Panel minimapPanel;
        private RichTextBox logBox;
        private ListBox inventoryList;
        private GroupBox grpInventory;
        private Button btnUsePotion;
        private Label lblMinimap;
        private GroupBox grpStatus;
        private Label lblHP;
        private Label lblWeapon;
        private Label lblStrength;
        private ProgressBar hpBar;
        private Label lblArmor;
        private GroupBox grpResources;
        private Label lblPotions;
        private Label lblExp;
        private Label lblGold;
        private GroupBox grpStats;
        private Label lblEnemiesLeft;
        private Label lblPosition;
        private Label lblLevel;
        private Label lblStrong;
        private Label lblNormal;
        private Label lblWeak;
        private Label lblExplored;
        private Label lblRest;
        private Label lblChests;
        private GroupBox grpControl;
        private Button btnD;
        private Button btnA;
        private Button btnS;
        private Button btnW;
        private Button btnNewMap;
        private Label lblLog;
    }
}