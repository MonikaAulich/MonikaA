using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib; //dodawanie możliwości dodawania muzyki do programu

namespace Gra
{ 
    public partial class FormMain : Form
    {
        WindowsMediaPlayer music = new WindowsMediaPlayer(); // zmienna pozwalająca odtwarzać muzukę  
        int counter;//ustawienie licznika

        public FormMain()
        {
            InitializeComponent();
            music.URL = "Music.mp3"; //odtwarzana ścieżka
        }

       
        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            //przycisk do zamyania okna
            Close();
            music.controls.pause(); //wyłączanie muzyki, by nie grała w tle. Przydatne przy pisaniu kodu ;)
        }




        /// <summary>
        /// przycisk służący do włączania okienka z instrukcją gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInstrukcja_Click(object sender, EventArgs e)
        {
            FormInstruction formInstruction = new FormInstruction();
            formInstruction.Show();

        }




        /// <summary>
        /// przycisk służący do włączania i pauzowania muzyki
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMusic_Click(object sender, EventArgs e)
        {  
                counter++;//zwiększanie licznika o 1
            if (counter%2 == 0) //reszta z dzielenia countera przez 2. Jeśli da 0, to muzyka się włącza. Jeśli 1, to się pauzuje
                music.controls.play();
            else
                music.controls.pause();

        }


        

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// ukrywanie okna menu i odpalanie okienka z grą
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            
            FormTrueGame game = new FormTrueGame();
            game.Show();
            music.controls.pause(); //pauzowanie muzyki, by nie grały 2 ścieżki w tle
            this.Hide();


        }
    }
}
