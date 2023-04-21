namespace arv
{
    class Hero : GameCharacter
    {
        public Hero() : base(100, 20)
        {
            Strength = 20;
        }
        public override void Fight(GameCharacter opponent)
        {
            opponent.LoseHealth(this.Strength);
        }
    }
}
