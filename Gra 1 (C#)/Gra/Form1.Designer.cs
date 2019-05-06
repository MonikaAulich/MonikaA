namespace Gra
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonInstrukcja = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonMusic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonStart.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStart.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonStart.Location = new System.Drawing.Point(309, 150);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(164, 81);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Rozpocznij grę";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonInstrukcja
            // 
            this.buttonInstrukcja.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonInstrukcja.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonInstrukcja.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonInstrukcja.Location = new System.Drawing.Point(309, 237);
            this.buttonInstrukcja.Name = "buttonInstrukcja";
            this.buttonInstrukcja.Size = new System.Drawing.Size(164, 81);
            this.buttonInstrukcja.TabIndex = 2;
            this.buttonInstrukcja.Text = "Instrukcja";
            this.buttonInstrukcja.UseVisualStyleBackColor = false;
            this.buttonInstrukcja.Click += new System.EventHandler(this.buttonInstrukcja_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonClose.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClose.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonClose.Location = new System.Drawing.Point(309, 324);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(164, 81);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Zakończ";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("MV Boli", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelTitle.Location = new System.Drawing.Point(109, 21);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(607, 126);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Brace yourself...\r\nNuclear winter is coming\r\n";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // buttonMusic
            // 
            this.buttonMusic.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonMusic.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMusic.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonMusic.Location = new System.Drawing.Point(703, 389);
            this.buttonMusic.Name = "buttonMusic";
            this.buttonMusic.Size = new System.Drawing.Size(85, 49);
            this.buttonMusic.TabIndex = 5;
            this.buttonMusic.Text = "Muzyka";
            this.buttonMusic.UseVisualStyleBackColor = false;
            this.buttonMusic.Click += new System.EventHandler(this.buttonMusic_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMusic);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonInstrukcja);
            this.Controls.Add(this.buttonStart);
            this.Name = "FormMain";
            this.Text = "Nuclear Winter is Coming";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonInstrukcja;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonMusic;
    }
}

