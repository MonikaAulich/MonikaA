using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib; //pozwala odtworzyć muzykę




namespace Game
{
    public partial class FormGame : Form
    {
        WindowsMediaPlayer musicPlay = new WindowsMediaPlayer(); // zmienna pozwalająca odtwarzać muzukę  


        int counter; //licznik
        List<Characters> charactersList = new List<Characters>(); //utworzenie jak narazie pustej listy z bohaterami. 


        public Characters characters;


        public FormGame()
        {
            InitializeComponent();

            musicPlay.URL = "MusicBackground.mp3";

            musicPlay.controls.play();

            //ukrycie przycisków do atakowania i leczenia
            buttonAttack.Hide();
            buttonHeal.Hide();

            charactersList.Add(new Daenerys("Daenerys",120, 21, 10)); //dodanie bohatera do listy wraz z odpowiednimi wartościami
            charactersList.Add(new Daredevil("Daredevil", 110, 22, 10));
            charactersList.Add(new Rey("Rey", 100, 23, 11));
            charactersList.Add(new Shazam("Shazam", 130, 19,9));
            


            foreach (var item in charactersList)
            {
                comboBoxCharactersFirst.Items.Add(item); //dodanie postaci z listy do comboboxa gracza 1
                comboBoxCharacterSecond.Items.Add(item); //dodanie postaci z listy do comboboxa gracza 2
              
            }


        }

        /// <summary>
        ///  wyświetlenie wartości przypisanych do wybranego bohatera gracza 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxCharactersFirst_SelectedIndexChanged(object sender, EventArgs e)
        {
            characters = (Characters)comboBoxCharactersFirst.SelectedItem;
            textBoxLifeFirst.Text = characters.life.ToString();
            textBoxStrenghtFirst.Text = characters.strenght.ToString();
        }

        /// <summary>
        /// wyświetlenie wartości przypisanych do wybranego bohatera gracza 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxCharacterSecond_SelectedIndexChanged(object sender, EventArgs e)
        {
            characters = (Characters)comboBoxCharacterSecond.SelectedItem;
            textBoxLifeSecond.Text = characters.life.ToString();
            textBoxStrenghtSecond.Text = characters.strenght.ToString();
        }

        private void FormGame_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// możliwość zaatakowania drugiej postaci
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAttack_Click(object sender, EventArgs e)
        {

            counter++;
            textBoxRound.Text = counter.ToString(); //kolejna runda

            //pętle dotyczące odbierania punktów życia
            if (int.Parse(textBoxRound.Text)%2 == 1)
            {
                int newLife = int.Parse(textBoxLifeFirst.Text) - int.Parse(textBoxStrenghtSecond.Text);
                textBoxLifeFirst.Text = newLife.ToString();
                    }
            if (int.Parse(textBoxRound.Text) % 2 == 0)
            {
                int newLife = int.Parse(textBoxLifeSecond.Text) - int.Parse(textBoxStrenghtFirst.Text);
                textBoxLifeSecond.Text = newLife.ToString();
            }

        }

        /// <summary>
        /// możliwość leczenia się postaci
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHeal_Click(object sender, EventArgs e)
        {
            counter++;
            textBoxRound.Text = counter.ToString(); //kolejna runda

            if (int.Parse(textBoxRound.Text) % 2 == 1)
            {
                int newLife = int.Parse(textBoxLifeFirst.Text) + characters.heal;
                textBoxLifeFirst.Text = newLife.ToString();
            }
            if (int.Parse(textBoxRound.Text) % 2 == 0)
            {
                int newLife = int.Parse(textBoxLifeSecond.Text) + characters.heal;
                textBoxLifeSecond.Text = newLife.ToString();
            }
        }

        /// <summary>
        /// punkty życia 1 gracza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxLifeFirst_TextChanged(object sender, EventArgs e) 
        {
           int lifePoints = int.Parse(textBoxLifeFirst.Text);
            if (lifePoints<0)
            {
                
                MessageBox.Show("Koniec gry. Wygrał gracz 2");
                
            }
           
        }

        private void textBoxStrenghtFirst_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// punkty życia gracza 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxLifeSecond_TextChanged(object sender, EventArgs e)
        {
            int lifePoints = int.Parse(textBoxLifeSecond.Text);
            if (lifePoints < 0)
            {
                MessageBox.Show("Koniec gry. Wygrał gracz 1");
                this.Hide();
            }
        }

        private void textBoxStrenghtSecond_TextChanged(object sender, EventArgs e)
        {

        }

       /// <summary>
       /// rozpoczęcie gry i 1 rundy
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        public void buttonStartGame_Click(object sender, EventArgs e)
        {
            counter++;
            textBoxTurn.Text = "Zaczyna gracz 1. W trakcie rundy można atakować albo się uleczyć. Jeden ruch na rundę.";
            textBoxRound.Text = counter.ToString();
            buttonStartGame.Hide(); //ukrycie przycisku start

            //pokazanie przycisków do ataku i leczenia
            buttonAttack.Show();
            buttonHeal.Show();
        }

        private void textBoxNameNewCharacter_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLifeNewCharacter_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxStrenghtNewCharacter_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// dodaje nową postać stworzoną przez graczy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddNewCharacter_Click(object sender, EventArgs e)
        {
            OwnCharacter ownCharacter = new OwnCharacter("tu będzie imię", 0, 0, 0);
            ownCharacter.name = textBoxNameNewCharacter.Text;
            ownCharacter.life = int.Parse(textBoxLifeNewCharacter.Text);
            ownCharacter.strenght = int.Parse(textBoxStrenghtNewCharacter.Text);
            ownCharacter.heal = int.Parse(textBoxHealNewCharacter.Text);

            charactersList.Add(ownCharacter); //dodanie nowego bohatera z wypisanymi wartościami przez gracza

            comboBoxCharactersFirst.Items.Add(charactersList[charactersList.Count - 1]); //wpisanie wszystkich danych do comboboxa 
            comboBoxCharacterSecond.Items.Add(charactersList[charactersList.Count - 1]);


        }

        private void textBoxTurn_TextChanged(object sender, EventArgs e)
        {
          

        }

        /// <summary>
        /// licznik rund
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxRound_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(textBoxRound.Text) > 60) //jeśli rund będzie więcej niż 60, gra się kończy
            { textBoxTurn.Text = "Koniec gry. Remis";
                textBoxRound.Text = "60";
                this.Hide();
            }
        }
    }
}
