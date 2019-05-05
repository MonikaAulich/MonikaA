namespace Gra
{
    partial class FormTrueGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrueGame));
            this.buttonMusic = new System.Windows.Forms.Button();
            this.buttonBackToMenu = new System.Windows.Forms.Button();
            this.timerLicznik = new System.Windows.Forms.Timer(this.components);
            this.textBoxDay = new System.Windows.Forms.TextBox();
            this.textBoxPeople = new System.Windows.Forms.TextBox();
            this.textBoxWoda = new System.Windows.Forms.TextBox();
            this.textBoxJedzenie = new System.Windows.Forms.TextBox();
            this.textBoxMorale = new System.Windows.Forms.TextBox();
            this.labelPeople = new System.Windows.Forms.Label();
            this.labelWoda = new System.Windows.Forms.Label();
            this.labelJedzenie = new System.Windows.Forms.Label();
            this.labelMorale = new System.Windows.Forms.Label();
            this.textBoxStory = new System.Windows.Forms.TextBox();
            this.labelDay = new System.Windows.Forms.Label();
            this.buttonWoda = new System.Windows.Forms.Button();
            this.buttonJedzenie = new System.Windows.Forms.Button();
            this.buttonMorale = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMusic
            // 
            this.buttonMusic.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonMusic.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMusic.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonMusic.Location = new System.Drawing.Point(703, 389);
            this.buttonMusic.Name = "buttonMusic";
            this.buttonMusic.Size = new System.Drawing.Size(85, 49);
            this.buttonMusic.TabIndex = 8;
            this.buttonMusic.Text = "Muzyka";
            this.buttonMusic.UseVisualStyleBackColor = false;
            this.buttonMusic.Click += new System.EventHandler(this.buttonMusic_Click);
            // 
            // buttonBackToMenu
            // 
            this.buttonBackToMenu.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonBackToMenu.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBackToMenu.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonBackToMenu.Location = new System.Drawing.Point(12, 389);
            this.buttonBackToMenu.Name = "buttonBackToMenu";
            this.buttonBackToMenu.Size = new System.Drawing.Size(85, 49);
            this.buttonBackToMenu.TabIndex = 9;
            this.buttonBackToMenu.Text = "Menu";
            this.buttonBackToMenu.UseVisualStyleBackColor = false;
            this.buttonBackToMenu.Click += new System.EventHandler(this.buttonBackToMenu_Click);
            // 
            // timerLicznik
            // 
            this.timerLicznik.Interval = 2500;
            this.timerLicznik.Tick += new System.EventHandler(this.timerLicznik_Tick);
            // 
            // textBoxDay
            // 
            this.textBoxDay.Location = new System.Drawing.Point(289, 102);
            this.textBoxDay.Name = "textBoxDay";
            this.textBoxDay.Size = new System.Drawing.Size(115, 20);
            this.textBoxDay.TabIndex = 10;
            this.textBoxDay.TextChanged += new System.EventHandler(this.textBoxDay_TextChanged);
            // 
            // textBoxPeople
            // 
            this.textBoxPeople.Location = new System.Drawing.Point(36, 43);
            this.textBoxPeople.Name = "textBoxPeople";
            this.textBoxPeople.Size = new System.Drawing.Size(100, 20);
            this.textBoxPeople.TabIndex = 11;
            this.textBoxPeople.Text = "10";
            this.textBoxPeople.TextChanged += new System.EventHandler(this.textBoxPeople_TextChanged);
            // 
            // textBoxWoda
            // 
            this.textBoxWoda.Location = new System.Drawing.Point(36, 115);
            this.textBoxWoda.Name = "textBoxWoda";
            this.textBoxWoda.Size = new System.Drawing.Size(100, 20);
            this.textBoxWoda.TabIndex = 12;
            this.textBoxWoda.Text = "100";
            this.textBoxWoda.TextChanged += new System.EventHandler(this.textBoxWoda_TextChanged);
            // 
            // textBoxJedzenie
            // 
            this.textBoxJedzenie.Location = new System.Drawing.Point(36, 190);
            this.textBoxJedzenie.Name = "textBoxJedzenie";
            this.textBoxJedzenie.Size = new System.Drawing.Size(100, 20);
            this.textBoxJedzenie.TabIndex = 13;
            this.textBoxJedzenie.Text = "100";
            this.textBoxJedzenie.TextChanged += new System.EventHandler(this.textBoxJedzenie_TextChanged);
            // 
            // textBoxMorale
            // 
            this.textBoxMorale.Location = new System.Drawing.Point(36, 265);
            this.textBoxMorale.Name = "textBoxMorale";
            this.textBoxMorale.Size = new System.Drawing.Size(100, 20);
            this.textBoxMorale.TabIndex = 14;
            this.textBoxMorale.Text = "100";
            this.textBoxMorale.TextChanged += new System.EventHandler(this.textBoxMorale_TextChanged);
            // 
            // labelPeople
            // 
            this.labelPeople.AutoSize = true;
            this.labelPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPeople.Location = new System.Drawing.Point(32, 20);
            this.labelPeople.Name = "labelPeople";
            this.labelPeople.Size = new System.Drawing.Size(94, 20);
            this.labelPeople.TabIndex = 15;
            this.labelPeople.Text = "Liczba osób";
            // 
            // labelWoda
            // 
            this.labelWoda.AutoSize = true;
            this.labelWoda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelWoda.Location = new System.Drawing.Point(32, 92);
            this.labelWoda.Name = "labelWoda";
            this.labelWoda.Size = new System.Drawing.Size(51, 20);
            this.labelWoda.TabIndex = 16;
            this.labelWoda.Text = "Woda";
            // 
            // labelJedzenie
            // 
            this.labelJedzenie.AutoSize = true;
            this.labelJedzenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelJedzenie.Location = new System.Drawing.Point(32, 167);
            this.labelJedzenie.Name = "labelJedzenie";
            this.labelJedzenie.Size = new System.Drawing.Size(73, 20);
            this.labelJedzenie.TabIndex = 17;
            this.labelJedzenie.Text = "Jedzenie";
            // 
            // labelMorale
            // 
            this.labelMorale.AutoSize = true;
            this.labelMorale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelMorale.Location = new System.Drawing.Point(32, 242);
            this.labelMorale.Name = "labelMorale";
            this.labelMorale.Size = new System.Drawing.Size(57, 20);
            this.labelMorale.TabIndex = 18;
            this.labelMorale.Text = "Morale";
            // 
            // textBoxStory
            // 
            this.textBoxStory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxStory.Location = new System.Drawing.Point(194, 128);
            this.textBoxStory.Multiline = true;
            this.textBoxStory.Name = "textBoxStory";
            this.textBoxStory.Size = new System.Drawing.Size(295, 166);
            this.textBoxStory.TabIndex = 20;
            this.textBoxStory.Text = "W schronie jak narazie panuje spokój, jednak to dopiero początek...\r\n";
            this.textBoxStory.TextChanged += new System.EventHandler(this.textBoxStory_TextChanged);
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDay.Location = new System.Drawing.Point(324, 79);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(50, 20);
            this.labelDay.TabIndex = 23;
            this.labelDay.Text = "Dzień";
            // 
            // buttonWoda
            // 
            this.buttonWoda.Location = new System.Drawing.Point(142, 112);
            this.buttonWoda.Name = "buttonWoda";
            this.buttonWoda.Size = new System.Drawing.Size(30, 23);
            this.buttonWoda.TabIndex = 25;
            this.buttonWoda.Text = "+1";
            this.buttonWoda.UseVisualStyleBackColor = true;
            this.buttonWoda.Click += new System.EventHandler(this.buttonWoda_Click);
            // 
            // buttonJedzenie
            // 
            this.buttonJedzenie.Location = new System.Drawing.Point(142, 187);
            this.buttonJedzenie.Name = "buttonJedzenie";
            this.buttonJedzenie.Size = new System.Drawing.Size(30, 23);
            this.buttonJedzenie.TabIndex = 26;
            this.buttonJedzenie.Text = "+1";
            this.buttonJedzenie.UseVisualStyleBackColor = true;
            this.buttonJedzenie.Click += new System.EventHandler(this.buttonJedzenie_Click);
            // 
            // buttonMorale
            // 
            this.buttonMorale.Location = new System.Drawing.Point(142, 263);
            this.buttonMorale.Name = "buttonMorale";
            this.buttonMorale.Size = new System.Drawing.Size(30, 23);
            this.buttonMorale.TabIndex = 27;
            this.buttonMorale.Text = "+1";
            this.buttonMorale.UseVisualStyleBackColor = true;
            this.buttonMorale.Click += new System.EventHandler(this.buttonMorale_Click);
            // 
            // FormTrueGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMorale);
            this.Controls.Add(this.buttonJedzenie);
            this.Controls.Add(this.buttonWoda);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.textBoxStory);
            this.Controls.Add(this.labelMorale);
            this.Controls.Add(this.labelJedzenie);
            this.Controls.Add(this.labelWoda);
            this.Controls.Add(this.labelPeople);
            this.Controls.Add(this.textBoxMorale);
            this.Controls.Add(this.textBoxJedzenie);
            this.Controls.Add(this.textBoxWoda);
            this.Controls.Add(this.textBoxPeople);
            this.Controls.Add(this.textBoxDay);
            this.Controls.Add(this.buttonBackToMenu);
            this.Controls.Add(this.buttonMusic);
            this.Name = "FormTrueGame";
            this.Text = "Nuclear Winter is Coming";
            this.Load += new System.EventHandler(this.FormTrueGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonMusic;
        private System.Windows.Forms.Button buttonBackToMenu;
        private System.Windows.Forms.Timer timerLicznik;
        private System.Windows.Forms.TextBox textBoxDay;
        private System.Windows.Forms.TextBox textBoxPeople;
        private System.Windows.Forms.TextBox textBoxWoda;
        private System.Windows.Forms.TextBox textBoxJedzenie;
        private System.Windows.Forms.TextBox textBoxMorale;
        private System.Windows.Forms.Label labelPeople;
        private System.Windows.Forms.Label labelWoda;
        private System.Windows.Forms.Label labelJedzenie;
        private System.Windows.Forms.Label labelMorale;
        private System.Windows.Forms.TextBox textBoxStory;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Button buttonWoda;
        private System.Windows.Forms.Button buttonJedzenie;
        private System.Windows.Forms.Button buttonMorale;
    }
}