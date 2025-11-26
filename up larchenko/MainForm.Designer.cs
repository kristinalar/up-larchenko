namespace up_larchenko
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            label1 = new Label();
            txtNickName = new TextBox();
            label2 = new Label();
            cmbClass = new ComboBox();
            label3 = new Label();
            txtBackStory = new TextBox();
            btnRegister = new Button();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(130, 107);
            label1.Name = "label1";
            label1.Size = new Size(79, 17);
            label1.TabIndex = 0;
            label1.Text = "Никнейм:";
            // 
            // txtNickName
            // 
            txtNickName.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtNickName.Location = new Point(275, 100);
            txtNickName.Name = "txtNickName";
            txtNickName.Size = new Size(125, 25);
            txtNickName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.White;
            label2.Location = new Point(130, 147);
            label2.Name = "label2";
            label2.Size = new Size(53, 17);
            label2.TabIndex = 2;
            label2.Text = "Класс:";
            // 
            // cmbClass
            // 
            cmbClass.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cmbClass.FormattingEnabled = true;
            cmbClass.Location = new Point(275, 139);
            cmbClass.Name = "cmbClass";
            cmbClass.Size = new Size(151, 25);
            cmbClass.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.White;
            label3.Location = new Point(130, 192);
            label3.Name = "label3";
            label3.Size = new Size(109, 17);
            label3.TabIndex = 4;
            label3.Text = "Предыстория:";
            // 
            // txtBackStory
            // 
            txtBackStory.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtBackStory.Location = new Point(275, 192);
            txtBackStory.Multiline = true;
            txtBackStory.Name = "txtBackStory";
            txtBackStory.Size = new Size(125, 60);
            txtBackStory.TabIndex = 5;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnRegister.Location = new Point(184, 273);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(188, 29);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Покажи мне, кто я есть!";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(108, 28);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 7;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.White;
            label5.Location = new Point(95, 10);
            label5.Name = "label5";
            label5.Size = new Size(441, 87);
            label5.TabIndex = 8;
            label5.Text = "Добро пожаловать, отважный путник! Гильдия авантюристов всегда рада тем, чьё сердце бьётся в ритме приключений. Готов ли ты внести своё имя в наши свитки славы?";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(632, 353);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnRegister);
            Controls.Add(txtBackStory);
            Controls.Add(label3);
            Controls.Add(cmbClass);
            Controls.Add(label2);
            Controls.Add(txtNickName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(650, 400);
            MinimizeBox = false;
            MinimumSize = new Size(650, 400);
            Name = "MainForm";
            Text = "Начало пути";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNickName;
        private Label label2;
        private ComboBox cmbClass;
        private Label label3;
        private TextBox txtBackStory;
        private Button btnRegister;
        private Label label4;
        private Label label5;
    }
}
