namespace DIO.AbstraindoUmJogoRPGComOOCSharp.src.Entities
{
    public abstract class ClassBase
    {
        public string Name { get; set; } = "";
        public int Level { get; set; } = 0;
        public string HeroType { get; set; } = "";

        public ClassBase(string name, int level, string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

        public virtual string Attack()
        {
            return this.Name + " attacked with the sword!";
        }
    }
}