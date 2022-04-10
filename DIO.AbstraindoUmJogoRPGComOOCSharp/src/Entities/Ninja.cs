namespace DIO.AbstraindoUmJogoRPGComOOCSharp.src.Entities
{
    public class Ninja : ClassBase
    {
        public Ninja(string name, int level, string heroType) : base(name, level, heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }

        public override string Attack()
        {
            return this.Name + " threw nunchakus!";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " threw all nunchakus on target with " + Bonus + " damage points.";
            }
            else
            {
                return this.Name + " threw only one nunchaku on target with " + Bonus + " damage points.";
            }
        }
    }
}