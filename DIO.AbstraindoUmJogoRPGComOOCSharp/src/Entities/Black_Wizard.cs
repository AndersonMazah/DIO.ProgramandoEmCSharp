namespace DIO.AbstraindoUmJogoRPGComOOCSharp.src.Entities
{
    public class Black_Wizard : ClassBase
    {
        public Black_Wizard(string name, int level, string heroType) : base(name, level, heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }

        public override string Attack()
        {
            return this.Name + " casted black magic!";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " casted superefective black magic with" + Bonus + " damage points.";
            }
            else
            {
                return this.Name + " casted weak black magic with " + Bonus + " damage points.";
            }
        }
    }
}