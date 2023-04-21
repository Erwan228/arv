namespace arv
{
    class Boss : GameCharacter
    {
        private Random rand;
        public Boss() : base(400, 10)
        {
            rand = new Random();
        }
        public override void Fight(GameCharacter opponent)
        {
            opponent.LoseHealth(rand.Next(0, 31));
        }
    }
}
