namespace Game
{
    internal class Shazam : Characters
    {
        public override string ToString()
        {
            return name;
        }
        public Shazam(string name, int life, int strenght, int heal) //ustawianie wartości początkowej
        {
            this.life = life;
            this.strenght = strenght;
            this.name = name;
            this.heal = heal;
        }
       
    }
}