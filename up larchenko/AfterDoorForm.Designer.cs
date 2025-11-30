namespace up_larchenko
{
    partial class AfterDoorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AfterDoorForm));
            label1 = new Label();
            btnOpenInventory = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(28, 31);
            label1.Name = "label1";
            label1.Size = new Size(457, 161);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // btnOpenInventory
            // 
            btnOpenInventory.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnOpenInventory.Location = new Point(401, 287);
            btnOpenInventory.Name = "btnOpenInventory";
            btnOpenInventory.Size = new Size(154, 29);
            btnOpenInventory.TabIndex = 1;
            btnOpenInventory.Text = "Заглянуть в сумку";
            btnOpenInventory.UseVisualStyleBackColor = true;
            btnOpenInventory.Click += btnOpenInventory_Click;
            // 
            // AfterDoorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(582, 353);
            Controls.Add(btnOpenInventory);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(600, 400);
            MinimizeBox = false;
            MinimumSize = new Size(600, 400);
            Name = "AfterDoorForm";
            Text = "AfterDoorForm";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnOpenInventory;
    }
}