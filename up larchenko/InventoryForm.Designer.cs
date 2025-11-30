namespace up_larchenko
{
    partial class InventoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryForm));
            lblTitle = new Label();
            lstItems = new ListBox();
            grpStats = new GroupBox();
            lblWallet = new Label();
            lblTotalValue = new Label();
            lblTotalItems = new Label();
            btnAnalyze = new Button();
            btnSellJunk = new Button();
            cmbShop = new ComboBox();
            btnBuy = new Button();
            grpStats.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(297, 35);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(195, 26);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Сумка странника";
            // 
            // lstItems
            // 
            lstItems.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lstItems.FormattingEnabled = true;
            lstItems.ItemHeight = 17;
            lstItems.Location = new Point(38, 53);
            lstItems.Name = "lstItems";
            lstItems.Size = new Size(178, 157);
            lstItems.TabIndex = 1;
            // 
            // grpStats
            // 
            grpStats.BackColor = Color.Transparent;
            grpStats.Controls.Add(lblWallet);
            grpStats.Controls.Add(lblTotalValue);
            grpStats.Controls.Add(lblTotalItems);
            grpStats.FlatStyle = FlatStyle.Flat;
            grpStats.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grpStats.ForeColor = Color.White;
            grpStats.Location = new Point(254, 97);
            grpStats.Name = "grpStats";
            grpStats.Size = new Size(247, 156);
            grpStats.TabIndex = 2;
            grpStats.TabStop = false;
            // 
            // lblWallet
            // 
            lblWallet.AutoSize = true;
            lblWallet.Location = new Point(32, 113);
            lblWallet.Name = "lblWallet";
            lblWallet.Size = new Size(101, 20);
            lblWallet.TabIndex = 2;
            lblWallet.Text = "Кошелек: 0";
            // 
            // lblTotalValue
            // 
            lblTotalValue.AutoSize = true;
            lblTotalValue.Location = new Point(32, 66);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(176, 20);
            lblTotalValue.TabIndex = 1;
            lblTotalValue.Text = "Общая стоимость: 0";
            // 
            // lblTotalItems
            // 
            lblTotalItems.AutoSize = true;
            lblTotalItems.Location = new Point(32, 24);
            lblTotalItems.Name = "lblTotalItems";
            lblTotalItems.Size = new Size(165, 20);
            lblTotalItems.TabIndex = 0;
            lblTotalItems.Text = "Всего предметов: 0";
            // 
            // btnAnalyze
            // 
            btnAnalyze.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAnalyze.Location = new Point(38, 236);
            btnAnalyze.Name = "btnAnalyze";
            btnAnalyze.Size = new Size(157, 29);
            btnAnalyze.TabIndex = 3;
            btnAnalyze.Text = "Анализировать";
            btnAnalyze.UseVisualStyleBackColor = true;
            btnAnalyze.Click += btnAnalyze_Click;
            // 
            // btnSellJunk
            // 
            btnSellJunk.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnSellJunk.Location = new Point(38, 282);
            btnSellJunk.Name = "btnSellJunk";
            btnSellJunk.Size = new Size(157, 29);
            btnSellJunk.TabIndex = 3;
            btnSellJunk.Text = "Продать хлам ";
            btnSellJunk.UseVisualStyleBackColor = true;
            btnSellJunk.Click += btnSellJunk_Click;
            // 
            // cmbShop
            // 
            cmbShop.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cmbShop.FormattingEnabled = true;
            cmbShop.Location = new Point(545, 62);
            cmbShop.Name = "cmbShop";
            cmbShop.Size = new Size(179, 25);
            cmbShop.TabIndex = 5;
            // 
            // btnBuy
            // 
            btnBuy.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnBuy.Location = new Point(578, 109);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(94, 29);
            btnBuy.TabIndex = 6;
            btnBuy.Text = "Купить";
            btnBuy.UseVisualStyleBackColor = true;
            btnBuy.Click += btnBuy_Click;
            // 
            // InventoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(782, 353);
            Controls.Add(btnBuy);
            Controls.Add(cmbShop);
            Controls.Add(btnSellJunk);
            Controls.Add(btnAnalyze);
            Controls.Add(grpStats);
            Controls.Add(lstItems);
            Controls.Add(lblTitle);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(800, 400);
            MinimizeBox = false;
            MinimumSize = new Size(800, 400);
            Name = "InventoryForm";
            Text = "InventoryForm";
            grpStats.ResumeLayout(false);
            grpStats.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private ListBox lstItems;
        private GroupBox grpStats;
        private Label lblTotalItems;
        private Label lblWallet;
        private Label lblTotalValue;
        private Button btnAnalyze;
        private Button btnSellJunk;
        private ComboBox cmbShop;
        private Button btnBuy;
    }
}