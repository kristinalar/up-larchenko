namespace up_larchenko
{
    partial class CharacterStatsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterStatsForm));
            label1 = new Label();
            numStrength = new NumericUpDown();
            label2 = new Label();
            numDexterity = new NumericUpDown();
            label3 = new Label();
            numIntelligence = new NumericUpDown();
            lblRemaining = new Label();
            btnConfirm = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)numStrength).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDexterity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numIntelligence).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(31, 168);
            label1.Name = "label1";
            label1.Size = new Size(48, 17);
            label1.TabIndex = 0;
            label1.Text = "Сила:";
            // 
            // numStrength
            // 
            numStrength.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            numStrength.Location = new Point(128, 168);
            numStrength.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numStrength.Name = "numStrength";
            numStrength.Size = new Size(150, 25);
            numStrength.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.White;
            label2.Location = new Point(31, 200);
            label2.Name = "label2";
            label2.Size = new Size(80, 17);
            label2.TabIndex = 2;
            label2.Text = "Ловкость:";
            // 
            // numDexterity
            // 
            numDexterity.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            numDexterity.Location = new Point(128, 200);
            numDexterity.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numDexterity.Name = "numDexterity";
            numDexterity.Size = new Size(150, 25);
            numDexterity.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.White;
            label3.Location = new Point(31, 231);
            label3.Name = "label3";
            label3.Size = new Size(91, 17);
            label3.TabIndex = 4;
            label3.Text = "Интеллект:";
            // 
            // numIntelligence
            // 
            numIntelligence.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            numIntelligence.Location = new Point(128, 231);
            numIntelligence.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numIntelligence.Name = "numIntelligence";
            numIntelligence.Size = new Size(150, 25);
            numIntelligence.TabIndex = 5;
            // 
            // lblRemaining
            // 
            lblRemaining.AutoSize = true;
            lblRemaining.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblRemaining.ForeColor = Color.DarkGreen;
            lblRemaining.Location = new Point(295, 170);
            lblRemaining.Name = "lblRemaining";
            lblRemaining.Size = new Size(143, 17);
            lblRemaining.TabIndex = 6;
            lblRemaining.Text = "Осталось очков: 20";
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnConfirm.Location = new Point(128, 275);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(252, 29);
            btnConfirm.TabIndex = 7;
            btnConfirm.Text = "Вперёд — к первому испытанию!";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.White;
            label4.Location = new Point(1, 9);
            label4.Name = "label4";
            label4.Size = new Size(277, 130);
            label4.TabIndex = 8;
            label4.Text = "Отлично, новобранец! Теперь распредели свои характеристики — пусть сила, ловкость и разум станут твоими верными спутниками в дороге. Выбирай с умом: судьба не прощает оплошностей!";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CharacterStatsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(482, 353);
            Controls.Add(label4);
            Controls.Add(btnConfirm);
            Controls.Add(lblRemaining);
            Controls.Add(numIntelligence);
            Controls.Add(label3);
            Controls.Add(numDexterity);
            Controls.Add(label2);
            Controls.Add(numStrength);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(500, 400);
            MinimumSize = new Size(500, 400);
            Name = "CharacterStatsForm";
            Text = "CharacterStatsForm";
            ((System.ComponentModel.ISupportInitialize)numStrength).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDexterity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numIntelligence).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numStrength;
        private Label label2;
        private NumericUpDown numDexterity;
        private Label label3;
        private NumericUpDown numIntelligence;
        private Label lblRemaining;
        private Button btnConfirm;
        private Label label4;
    }
}