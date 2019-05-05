namespace Game
{
    partial class FormGame
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.comboBoxCharactersFirst = new System.Windows.Forms.ComboBox();
            this.labelGamer1 = new System.Windows.Forms.Label();
            this.labelGamer2 = new System.Windows.Forms.Label();
            this.comboBoxCharacterSecond = new System.Windows.Forms.ComboBox();
            this.textBoxLifeFirst = new System.Windows.Forms.TextBox();
            this.textBoxLifeSecond = new System.Windows.Forms.TextBox();
            this.textBoxStrenghtFirst = new System.Windows.Forms.TextBox();
            this.textBoxStrenghtSecond = new System.Windows.Forms.TextBox();
            this.buttonAttack = new System.Windows.Forms.Button();
            this.buttonHeal = new System.Windows.Forms.Button();
            this.textBoxTurn = new System.Windows.Forms.TextBox();
            this.labelLifeFirst = new System.Windows.Forms.Label();
            this.labelStrenghtFirst = new System.Windows.Forms.Label();
            this.labelLifeSecond = new System.Windows.Forms.Label();
            this.labelStrenghtSecond = new System.Windows.Forms.Label();
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.textBoxNameNewCharacter = new System.Windows.Forms.TextBox();
            this.textBoxLifeNewCharacter = new System.Windows.Forms.TextBox();
            this.textBoxStrenghtNewCharacter = new System.Windows.Forms.TextBox();
            this.buttonAddNewCharacter = new System.Windows.Forms.Button();
            this.textBoxRound = new System.Windows.Forms.TextBox();
            this.labelRound = new System.Windows.Forms.Label();
            this.textBoxHealNewCharacter = new System.Windows.Forms.TextBox();
            this.labelMakeNewCharacter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxCharactersFirst
            // 
            this.comboBoxCharactersFirst.FormattingEnabled = true;
            this.comboBoxCharactersFirst.Location = new System.Drawing.Point(59, 118);
            this.comboBoxCharactersFirst.Name = "comboBoxCharactersFirst";
            this.comboBoxCharactersFirst.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCharactersFirst.TabIndex = 0;
            this.comboBoxCharactersFirst.Text = "Wybierz postać";
            this.comboBoxCharactersFirst.SelectedIndexChanged += new System.EventHandler(this.comboBoxCharactersFirst_SelectedIndexChanged);
            // 
            // labelGamer1
            // 
            this.labelGamer1.AutoSize = true;
            this.labelGamer1.Location = new System.Drawing.Point(87, 92);
            this.labelGamer1.Name = "labelGamer1";
            this.labelGamer1.Size = new System.Drawing.Size(44, 13);
            this.labelGamer1.TabIndex = 1;
            this.labelGamer1.Text = "Gracz 1";
            // 
            // labelGamer2
            // 
            this.labelGamer2.AutoSize = true;
            this.labelGamer2.Location = new System.Drawing.Point(481, 92);
            this.labelGamer2.Name = "labelGamer2";
            this.labelGamer2.Size = new System.Drawing.Size(44, 13);
            this.labelGamer2.TabIndex = 2;
            this.labelGamer2.Text = "Gracz 2";
            // 
            // comboBoxCharacterSecond
            // 
            this.comboBoxCharacterSecond.FormattingEnabled = true;
            this.comboBoxCharacterSecond.Location = new System.Drawing.Point(442, 118);
            this.comboBoxCharacterSecond.Name = "comboBoxCharacterSecond";
            this.comboBoxCharacterSecond.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCharacterSecond.TabIndex = 3;
            this.comboBoxCharacterSecond.Text = "Wybierz postać";
            this.comboBoxCharacterSecond.SelectedIndexChanged += new System.EventHandler(this.comboBoxCharacterSecond_SelectedIndexChanged);
            // 
            // textBoxLifeFirst
            // 
            this.textBoxLifeFirst.Location = new System.Drawing.Point(68, 239);
            this.textBoxLifeFirst.Name = "textBoxLifeFirst";
            this.textBoxLifeFirst.Size = new System.Drawing.Size(100, 20);
            this.textBoxLifeFirst.TabIndex = 4;
            this.textBoxLifeFirst.TextChanged += new System.EventHandler(this.textBoxLifeFirst_TextChanged);
            // 
            // textBoxLifeSecond
            // 
            this.textBoxLifeSecond.Location = new System.Drawing.Point(442, 239);
            this.textBoxLifeSecond.Name = "textBoxLifeSecond";
            this.textBoxLifeSecond.Size = new System.Drawing.Size(100, 20);
            this.textBoxLifeSecond.TabIndex = 5;
            this.textBoxLifeSecond.TextChanged += new System.EventHandler(this.textBoxLifeSecond_TextChanged);
            // 
            // textBoxStrenghtFirst
            // 
            this.textBoxStrenghtFirst.Location = new System.Drawing.Point(68, 309);
            this.textBoxStrenghtFirst.Name = "textBoxStrenghtFirst";
            this.textBoxStrenghtFirst.Size = new System.Drawing.Size(100, 20);
            this.textBoxStrenghtFirst.TabIndex = 8;
            this.textBoxStrenghtFirst.TextChanged += new System.EventHandler(this.textBoxStrenghtFirst_TextChanged);
            // 
            // textBoxStrenghtSecond
            // 
            this.textBoxStrenghtSecond.Location = new System.Drawing.Point(442, 309);
            this.textBoxStrenghtSecond.Name = "textBoxStrenghtSecond";
            this.textBoxStrenghtSecond.Size = new System.Drawing.Size(100, 20);
            this.textBoxStrenghtSecond.TabIndex = 9;
            this.textBoxStrenghtSecond.TextChanged += new System.EventHandler(this.textBoxStrenghtSecond_TextChanged);
            // 
            // buttonAttack
            // 
            this.buttonAttack.Location = new System.Drawing.Point(271, 242);
            this.buttonAttack.Name = "buttonAttack";
            this.buttonAttack.Size = new System.Drawing.Size(75, 23);
            this.buttonAttack.TabIndex = 12;
            this.buttonAttack.Text = "Atakuj";
            this.buttonAttack.UseVisualStyleBackColor = true;
            this.buttonAttack.Click += new System.EventHandler(this.buttonAttack_Click);
            // 
            // buttonHeal
            // 
            this.buttonHeal.Location = new System.Drawing.Point(271, 288);
            this.buttonHeal.Name = "buttonHeal";
            this.buttonHeal.Size = new System.Drawing.Size(75, 23);
            this.buttonHeal.TabIndex = 13;
            this.buttonHeal.Text = "Ulecz się";
            this.buttonHeal.UseVisualStyleBackColor = true;
            this.buttonHeal.Click += new System.EventHandler(this.buttonHeal_Click);
            // 
            // textBoxTurn
            // 
            this.textBoxTurn.Location = new System.Drawing.Point(256, 94);
            this.textBoxTurn.Multiline = true;
            this.textBoxTurn.Name = "textBoxTurn";
            this.textBoxTurn.Size = new System.Drawing.Size(116, 90);
            this.textBoxTurn.TabIndex = 14;
            this.textBoxTurn.Text = "Gdy wybierzecie już postacie, zaczyna gracz pierwszy";
            this.textBoxTurn.TextChanged += new System.EventHandler(this.textBoxTurn_TextChanged);
            // 
            // labelLifeFirst
            // 
            this.labelLifeFirst.AutoSize = true;
            this.labelLifeFirst.Location = new System.Drawing.Point(40, 242);
            this.labelLifeFirst.Name = "labelLifeFirst";
            this.labelLifeFirst.Size = new System.Drawing.Size(22, 13);
            this.labelLifeFirst.TabIndex = 15;
            this.labelLifeFirst.Text = "HP";
            // 
            // labelStrenghtFirst
            // 
            this.labelStrenghtFirst.AutoSize = true;
            this.labelStrenghtFirst.Location = new System.Drawing.Point(40, 309);
            this.labelStrenghtFirst.Name = "labelStrenghtFirst";
            this.labelStrenghtFirst.Size = new System.Drawing.Size(26, 13);
            this.labelStrenghtFirst.TabIndex = 16;
            this.labelStrenghtFirst.Text = "Siła";
            // 
            // labelLifeSecond
            // 
            this.labelLifeSecond.AutoSize = true;
            this.labelLifeSecond.Location = new System.Drawing.Point(414, 242);
            this.labelLifeSecond.Name = "labelLifeSecond";
            this.labelLifeSecond.Size = new System.Drawing.Size(22, 13);
            this.labelLifeSecond.TabIndex = 18;
            this.labelLifeSecond.Text = "HP";
            // 
            // labelStrenghtSecond
            // 
            this.labelStrenghtSecond.AutoSize = true;
            this.labelStrenghtSecond.Location = new System.Drawing.Point(410, 312);
            this.labelStrenghtSecond.Name = "labelStrenghtSecond";
            this.labelStrenghtSecond.Size = new System.Drawing.Size(26, 13);
            this.labelStrenghtSecond.TabIndex = 19;
            this.labelStrenghtSecond.Text = "Siła";
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Location = new System.Drawing.Point(271, 190);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(75, 23);
            this.buttonStartGame.TabIndex = 20;
            this.buttonStartGame.Text = "Start";
            this.buttonStartGame.UseVisualStyleBackColor = true;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStartGame_Click);
            // 
            // textBoxNameNewCharacter
            // 
            this.textBoxNameNewCharacter.Location = new System.Drawing.Point(661, 107);
            this.textBoxNameNewCharacter.Multiline = true;
            this.textBoxNameNewCharacter.Name = "textBoxNameNewCharacter";
            this.textBoxNameNewCharacter.Size = new System.Drawing.Size(100, 32);
            this.textBoxNameNewCharacter.TabIndex = 21;
            this.textBoxNameNewCharacter.Text = "Wpisz imię nowej postaci";
            this.textBoxNameNewCharacter.TextChanged += new System.EventHandler(this.textBoxNameNewCharacter_TextChanged);
            // 
            // textBoxLifeNewCharacter
            // 
            this.textBoxLifeNewCharacter.Location = new System.Drawing.Point(661, 145);
            this.textBoxLifeNewCharacter.Multiline = true;
            this.textBoxLifeNewCharacter.Name = "textBoxLifeNewCharacter";
            this.textBoxLifeNewCharacter.Size = new System.Drawing.Size(100, 52);
            this.textBoxLifeNewCharacter.TabIndex = 22;
            this.textBoxLifeNewCharacter.Text = "Wpisz ilość punktów życia nowej postaci";
            this.textBoxLifeNewCharacter.TextChanged += new System.EventHandler(this.textBoxLifeNewCharacter_TextChanged);
            // 
            // textBoxStrenghtNewCharacter
            // 
            this.textBoxStrenghtNewCharacter.Location = new System.Drawing.Point(661, 203);
            this.textBoxStrenghtNewCharacter.Multiline = true;
            this.textBoxStrenghtNewCharacter.Name = "textBoxStrenghtNewCharacter";
            this.textBoxStrenghtNewCharacter.Size = new System.Drawing.Size(100, 51);
            this.textBoxStrenghtNewCharacter.TabIndex = 23;
            this.textBoxStrenghtNewCharacter.Text = "Wpisz ilość punktów siły nowej postaci";
            this.textBoxStrenghtNewCharacter.TextChanged += new System.EventHandler(this.textBoxStrenghtNewCharacter_TextChanged);
            // 
            // buttonAddNewCharacter
            // 
            this.buttonAddNewCharacter.Location = new System.Drawing.Point(661, 317);
            this.buttonAddNewCharacter.Name = "buttonAddNewCharacter";
            this.buttonAddNewCharacter.Size = new System.Drawing.Size(75, 23);
            this.buttonAddNewCharacter.TabIndex = 24;
            this.buttonAddNewCharacter.Text = "Dodaj";
            this.buttonAddNewCharacter.UseVisualStyleBackColor = true;
            this.buttonAddNewCharacter.Click += new System.EventHandler(this.buttonAddNewCharacter_Click);
            // 
            // textBoxRound
            // 
            this.textBoxRound.Location = new System.Drawing.Point(287, 49);
            this.textBoxRound.Name = "textBoxRound";
            this.textBoxRound.Size = new System.Drawing.Size(44, 20);
            this.textBoxRound.TabIndex = 25;
            this.textBoxRound.TextChanged += new System.EventHandler(this.textBoxRound_TextChanged);
            // 
            // labelRound
            // 
            this.labelRound.AutoSize = true;
            this.labelRound.Location = new System.Drawing.Point(287, 33);
            this.labelRound.Name = "labelRound";
            this.labelRound.Size = new System.Drawing.Size(39, 13);
            this.labelRound.TabIndex = 26;
            this.labelRound.Text = "Runda";
            // 
            // textBoxHealNewCharacter
            // 
            this.textBoxHealNewCharacter.Location = new System.Drawing.Point(661, 260);
            this.textBoxHealNewCharacter.Multiline = true;
            this.textBoxHealNewCharacter.Name = "textBoxHealNewCharacter";
            this.textBoxHealNewCharacter.Size = new System.Drawing.Size(100, 51);
            this.textBoxHealNewCharacter.TabIndex = 27;
            this.textBoxHealNewCharacter.Text = "Wpisz ilość punktów leczenia nowej postaci\r\n";
            // 
            // labelMakeNewCharacter
            // 
            this.labelMakeNewCharacter.AutoSize = true;
            this.labelMakeNewCharacter.Location = new System.Drawing.Point(658, 91);
            this.labelMakeNewCharacter.Name = "labelMakeNewCharacter";
            this.labelMakeNewCharacter.Size = new System.Drawing.Size(103, 13);
            this.labelMakeNewCharacter.TabIndex = 28;
            this.labelMakeNewCharacter.Text = "Stwórz nową postać";
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelMakeNewCharacter);
            this.Controls.Add(this.textBoxHealNewCharacter);
            this.Controls.Add(this.labelRound);
            this.Controls.Add(this.textBoxRound);
            this.Controls.Add(this.buttonAddNewCharacter);
            this.Controls.Add(this.textBoxStrenghtNewCharacter);
            this.Controls.Add(this.textBoxLifeNewCharacter);
            this.Controls.Add(this.textBoxNameNewCharacter);
            this.Controls.Add(this.buttonStartGame);
            this.Controls.Add(this.labelStrenghtSecond);
            this.Controls.Add(this.labelLifeSecond);
            this.Controls.Add(this.labelStrenghtFirst);
            this.Controls.Add(this.labelLifeFirst);
            this.Controls.Add(this.textBoxTurn);
            this.Controls.Add(this.buttonHeal);
            this.Controls.Add(this.buttonAttack);
            this.Controls.Add(this.textBoxStrenghtSecond);
            this.Controls.Add(this.textBoxStrenghtFirst);
            this.Controls.Add(this.textBoxLifeSecond);
            this.Controls.Add(this.textBoxLifeFirst);
            this.Controls.Add(this.comboBoxCharacterSecond);
            this.Controls.Add(this.labelGamer2);
            this.Controls.Add(this.labelGamer1);
            this.Controls.Add(this.comboBoxCharactersFirst);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "FormGame";
            this.Text = "Fight class";
            this.Load += new System.EventHandler(this.FormGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCharactersFirst;
        private System.Windows.Forms.Label labelGamer1;
        private System.Windows.Forms.Label labelGamer2;
        private System.Windows.Forms.ComboBox comboBoxCharacterSecond;
        private System.Windows.Forms.TextBox textBoxLifeFirst;
        private System.Windows.Forms.TextBox textBoxLifeSecond;
        private System.Windows.Forms.TextBox textBoxStrenghtFirst;
        private System.Windows.Forms.TextBox textBoxStrenghtSecond;
        private System.Windows.Forms.Button buttonAttack;
        private System.Windows.Forms.Button buttonHeal;
        private System.Windows.Forms.TextBox textBoxTurn;
        private System.Windows.Forms.Label labelLifeFirst;
        private System.Windows.Forms.Label labelStrenghtFirst;
        private System.Windows.Forms.Label labelLifeSecond;
        private System.Windows.Forms.Label labelStrenghtSecond;
        private System.Windows.Forms.Button buttonStartGame;
        private System.Windows.Forms.TextBox textBoxNameNewCharacter;
        private System.Windows.Forms.TextBox textBoxLifeNewCharacter;
        private System.Windows.Forms.TextBox textBoxStrenghtNewCharacter;
        private System.Windows.Forms.Button buttonAddNewCharacter;
        private System.Windows.Forms.TextBox textBoxRound;
        private System.Windows.Forms.Label labelRound;
        private System.Windows.Forms.TextBox textBoxHealNewCharacter;
        private System.Windows.Forms.Label labelMakeNewCharacter;
    }
}

