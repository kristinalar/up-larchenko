namespace up_larchenko
{
    partial class CharacterCardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterCardForm));
            lblNickname = new Label();
            lblClass = new Label();
            lblBackstory = new Label();
            btnNext = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblNickname
            // 
            lblNickname.AutoSize = true;
            lblNickname.BackColor = Color.Transparent;
            lblNickname.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblNickname.ForeColor = Color.White;
            lblNickname.Location = new Point(132, 75);
            lblNickname.Name = "lblNickname";
            lblNickname.Size = new Size(59, 17);
            lblNickname.TabIndex = 0;
            lblNickname.Text = "Имя: ...";
            // 
            // lblClass
            // 
            lblClass.AutoSize = true;
            lblClass.BackColor = Color.Transparent;
            lblClass.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblClass.ForeColor = Color.White;
            lblClass.Location = new Point(132, 122);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(69, 17);
            lblClass.TabIndex = 1;
            lblClass.Text = "Класс: ...";
            // 
            // lblBackstory
            // 
            lblBackstory.AutoSize = true;
            lblBackstory.BackColor = Color.Transparent;
            lblBackstory.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblBackstory.ForeColor = Color.White;
            lblBackstory.Location = new Point(132, 167);
            lblBackstory.Name = "lblBackstory";
            lblBackstory.Size = new Size(125, 17);
            lblBackstory.TabIndex = 2;
            lblBackstory.Text = "Предыстория: ...";
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnNext.Location = new Point(132, 214);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(213, 29);
            btnNext.TabIndex = 3;
            btnNext.Text = "Мои силы — моё решение!";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(75, 29);
            label1.Name = "label1";
            label1.Size = new Size(321, 18);
            label1.TabIndex = 4;
            label1.Text = "Взгляни на своё отражение в зеркале отваги!";
            // 
            // CharacterCardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(482, 353);
            Controls.Add(label1);
            Controls.Add(btnNext);
            Controls.Add(lblBackstory);
            Controls.Add(lblClass);
            Controls.Add(lblNickname);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(500, 400);
            MinimizeBox = false;
            Name = "CharacterCardForm";
            Text = "CharacterCardForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNickname;
        private Label lblClass;
        private Label lblBackstory;
        private Button btnNext;
        private Label label1;
    }
}