namespace Game
{
    internal class Rey : Characters
    {

        public override string ToString()
        {
            return name;
        }
        public Rey(string name, int life, int strenght, int heal) //ustawianie wartości początkowej
        {
            this.life = life;
            this.strenght = strenght;
            this.name = name;
            this.heal = heal;
        }
    }
}