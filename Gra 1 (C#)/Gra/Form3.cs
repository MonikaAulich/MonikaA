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
    public partial class FormTrueGame : Form
    {
        WindowsMediaPlayer music = new WindowsMediaPlayer(); // zmienna pozwalająca odtwarzać muzukę  

        int counter; //zmienna licznikowa
        
       
        //nazwa okienka z grą
        public FormTrueGame()
        {
            InitializeComponent();
            music.URL = "Music.mp3"; //odtwarzana ścieżka
            timerLicznik.Start();//rozpoczęcie odliczania

        }

        /// <summary>
        /// włączanie i pauzowanie muzyki
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMusic_Click(object sender, EventArgs e)
        {
            counter++; //licznik
            if (counter % 2 == 0) //jeśli kliknie się raz, muzyka się pauzuje, jeśli 0, 2, 4 etc. to się włącza
                music.controls.play();
            else
                music.controls.pause();

        }



        /// <summary>
        /// powrót do menu - ukrywanie danego okienka i włączanie okienka z menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBackToMenu_Click(object sender, EventArgs e)
        {
            FormMain menu = new FormMain(); // deklaracja nowego okienka 
            menu.Show(); //włączanie okienka
            music.controls.pause(); //pauzowanie muzyki, by nie grały 2 ścieżki w tle
            this.Hide(); // ukrywanie okienka gry 
        }



        /// <summary>
        /// licznik czasu=licznik dni. Tutaj znajdują się również wszystkie komendy dot. gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void timerLicznik_Tick(object sender, EventArgs e)
        {

            counter++; //licznik 
            textBoxDay.Text = counter.ToString(); //przypisanie licznika jako odliczanie dni
            int woda = int.Parse(textBoxWoda.Text); //zmiana na int i  przypisanie wartości. Ilość wody
            int jedzenie = int.Parse(textBoxJedzenie.Text); //Ilość jedzenia
            int ludzie = int.Parse(textBoxPeople.Text);//Ilość ludzi
            int morale = int.Parse(textBoxMorale.Text); //Wysokość morali
            int dzien = int.Parse(textBoxDay.Text); //Liczba dni


            //utworzenie pętli. i<1 aby max 1 liczbę odejmowano "na dzień"
            for (int i = 0; i < 1; i++) 
            {
                woda = woda - 1; //odejmowanie liczby wody
                jedzenie = jedzenie - 1; // odejmowanie liczby jedzenia 
                textBoxWoda.Text = woda.ToString(); //wpisanie nowej wartości do okienka zamieniając ją na string
                textBoxJedzenie.Text = jedzenie.ToString();
                morale = morale - 1;
                textBoxMorale.Text = morale.ToString();
              
            }



            // co gdy woda i jedzenie spadnie poniżej 80
            if ( jedzenie <80 )
            {
                textBoxStory.Text = "Widać pierwsze braki w zapasach żywności. W szale 2 osoby zaczęły się kłócić o swoje racje żywnościowe. Od teraz wszystkie zapasy tracone są 2x szybciej";
                woda = woda - 1;
                jedzenie = jedzenie - 1;
                morale = morale - 1;
                textBoxWoda.Text = woda.ToString();
                textBoxJedzenie.Text = jedzenie.ToString();
                textBoxMorale.Text = morale.ToString();
            }
           

            //co gdy woda i jedzenie spadnie poniżej 40
            if(woda<40 && jedzenie <40)
            {
                morale = morale - 10;
                textBoxMorale.Text = morale.ToString();
                textBoxStory.Text = "Ludzie zaczynają zauważać zmniejszającą się ilość pożywienia i wody. Morale od teraz spadają o 10 dziennie";
            }
            
            


            //co gdy przekroczymy dzień 20
            if (dzien > 20 && dzien < 25) //warunek dniowy
            {
                textBoxStory.Text = "Minęło już ponad 20 dni. Ciasnota tego miejsca przyprawia niektórych o klaustrofobię - jedna z osób postanowiła w tajemnicy zabrać 15 sztuk jedzenia i wody i wyjść na zewnątrz. Morale spadają o 30";
                morale = morale - 30; //wypełnienie warunku z opisu
                textBoxMorale.Text = morale.ToString();
                jedzenie = jedzenie - 15; //wypełnienie warunku z opisu
                textBoxJedzenie.Text = jedzenie.ToString();
                woda = woda - 15; //wypełnienie warunku z opisu
                textBoxWoda.Text = woda.ToString();
                ludzie = ludzie - 1;
                textBoxPeople.Text = ludzie.ToString();
                dzien = 26;
                textBoxDay.Text = dzien.ToString();

            }


            //co gdy liczba wody wzrośnie do 120
            if (woda > 120)
            {
                jedzenie = jedzenie - 40;
                morale = morale - 30;
                textBoxJedzenie.Text = jedzenie.ToString();
                textBoxMorale.Text = morale.ToString();
                textBoxStory.Text = "Przez zbyt dużą ilość wypijanej wody rury nie wytrzymały i zrobił się bałagan. Ucierpiało 40 racji jedzenia. Morale spadły o 30.";
            }



            //co gdy liczba wody spadnie poniżej 10
            if (woda < 10)
            {
                jedzenie = jedzenie + 3;
                morale = morale - 10;
                textBoxJedzenie.Text = jedzenie.ToString();
                textBoxMorale.Text = morale.ToString();
                textBoxStory.Text = "Kończą się zapasy wody. Zaczęto osczędzać racje żywnościowe, dzięki czemu dziennie przybywa ich 3, jednak od tej pory codziennie morale spadają o 10.";
            }

            // co gdy liczba jedzenia wzrośnie powyżej 120
            if (jedzenie > 120) //warunek
            {
                textBoxStory.Text = "Skonczyło się miejsce w schowku na jedzenie, przez co zaczęto je rozdawać i wywiązała się wielka awantura. Ilość jedzenia spada o 30, morale spadają o 10";
                jedzenie = jedzenie - 30; //wypełnienie warunku z opisu
                morale = morale - 10; //wypełnienie warunku z opisu
                textBoxJedzenie.Text = jedzenie.ToString();
                textBoxMorale.Text = morale.ToString();
            }


            // co gdy morale wzrosną powyżej 120
            if (morale>120)
            {
                textBoxStory.Text = "Ludzie bardzo się rozluźnili i urządzili imprezę, wyczerpując 30 zapasów jedzenia i wody. 3 z nich wyszła z kryjówki i już nie wróciła. Morale spadają do 100.";
                ludzie = ludzie - 3;
                jedzenie = jedzenie - 30;
                woda = woda - 30;
                morale = 100;
                textBoxPeople.Text = ludzie.ToString();
                textBoxJedzenie.Text = jedzenie.ToString();
                textBoxWoda.Text = woda.ToString();
                textBoxMorale.Text = morale.ToString();
            }

            //co gdy będzie dzień między 40 a 45
            if (dzien>40 && dzien<45)
            {
                textBoxStory.Text = "Przyszła dostawa! Tajemniczy i miły nieznajomy przynosi zapasy jedzenia oraz Monopoly! Morale wzrastają o 20, jedzenie i woda o 15";
                morale = morale + 20;
                jedzenie = jedzenie + 15;
                woda = woda + 15;
                ludzie = ludzie + 1;
                textBoxPeople.Text = ludzie.ToString();
                textBoxJedzenie.Text = jedzenie.ToString();
                textBoxWoda.Text = woda.ToString();
                textBoxMorale.Text = morale.ToString();
                dzien = 46;
                textBoxDay.Text = dzien.ToString();
            }


            //co gdy morale spadną poniżej 25
            if (morale<25)
            {
                textBoxStory.Text = "Morale spadły bardzo nisko, przez co z grupy odchodzi dziennie 1 osoba";
                ludzie = ludzie - 1;
                textBoxPeople.Text = ludzie.ToString();

            }


            // gdy minie 60 dzień
            if(dzien>60 )
            {
                textBoxStory.Text = "Wygląda zaczynać to coraz gorzej. Monopoly się już wszystkim znudziło. Zaczyna panować anarchia. Od dzisiaj morale spadają o dodatkowe 5 punktów dziennie. ";
                morale = morale - 5;
                textBoxMorale.Text = morale.ToString();
            }


            //gdzy minie 80 dzień
            if (dzien>80)
            {
                textBoxStory.Text = "Ludzie buntują się coraz bardziej. Od dzisiaj jedzenie i woda kończą się 2x szybciej";
                jedzenie = jedzenie - 1;
                woda = woda - 1;
                textBoxJedzenie.Text = jedzenie.ToString();
                textBoxWoda.Text = woda.ToString();
            }

            //zakończenie gry po 100 dniach
            if (dzien > 100)
                textBoxStory.Text = "Udało Ci się dotrwać, w nieco okrojonym składzie, do końca. Przyszli po Was ratownicy. Jesteście już bezpieczni i nie musicie się o nic martwić. Koniec gry.";
        }


        /// <summary>
        /// liczba osób
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void textBoxPeople_TextChanged(object sender, EventArgs e)
        {
            int koniec = int.Parse(textBoxPeople.Text); //gdy kończy się gra
            if (koniec <= 0)
            {
                timerLicznik.Stop();
                textBoxStory.Text = "Przetrwałeś jako jedyny. Koniec gry";

            }

        }


        /// <summary>
        /// ilość zapasów wody
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void textBoxWoda_TextChanged(object sender, EventArgs e)
        {
            int koniec = int.Parse(textBoxWoda.Text); //gdy kończy się gra
            if (koniec <= 0)
            {
                timerLicznik.Stop();
                textBoxStory.Text = "Ilość wody spadła do zera. Koniec gry";
            }
                      
        }


        /// <summary>
        /// ilość jedzenia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void textBoxJedzenie_TextChanged(object sender, EventArgs e)
        {
           
           
            int koniec = int.Parse(textBoxJedzenie.Text); //gdy kończy się gra
            if (koniec <= 0)
            {
                timerLicznik.Stop();
                textBoxStory.Text = "Jedzenie spadło do zera. Koniec gry";


            }
        }



        /// <summary>
        /// ilość morali
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void textBoxMorale_TextChanged(object sender, EventArgs e)
        {
            int koniec = int.Parse(textBoxMorale.Text); //gdy kończy się gra
            if (koniec <= 0)
            {
                timerLicznik.Stop();
                textBoxStory.Text = "Morale spadły do zera. Koniec gry";

            }
        }


        /// <summary>
        /// liczba dni=licznik czasowy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void textBoxDay_TextChanged(object sender, EventArgs e)
        {
           
        }

        /// <summary>
        /// tekst wyświetlający się w trakcie gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void textBoxStory_TextChanged(object sender, EventArgs e)
        {
        
        }

        /// <summary>
        /// wzrost wartości wody i czasu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWoda_Click(object sender, EventArgs e)
        {
            int woda = int.Parse(textBoxWoda.Text);
            woda = woda + 2;
            textBoxWoda.Text = woda.ToString();
            counter++;
        }



        /// <summary>
        /// wzrost wartości jedzenia i czasu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonJedzenie_Click(object sender, EventArgs e)
        {
            int jedzenie = int.Parse(textBoxJedzenie.Text);
            jedzenie = jedzenie + 2;
            textBoxJedzenie.Text = jedzenie.ToString();
            counter++;
        }



        /// <summary>
        /// wzrost wartości morali i czasu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMorale_Click(object sender, EventArgs e)
        {
            int morale = int.Parse(textBoxMorale.Text);
            morale = morale + 2;
            textBoxMorale.Text = morale.ToString();
            counter++;
            
        }

        private void FormTrueGame_Load(object sender, EventArgs e)
        {

        }
    }
}
