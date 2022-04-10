namespace DIO.AbstraindoUmJogoRPGComOOCSharp.src.Entities
{
    public class Knight : ClassBase
    {
        public Knight(string name, int level, string heroType) : base(name, level, heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " double slashed attack with " + Bonus + " damage points";
            }
            else
            {
                return this.Name + " single slashed attack with " + Bonus + " damage points";
            }
        }
    }
}