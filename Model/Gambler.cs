namespace Model
{
    public abstract class Gambler
    {
        public string Name { get; }
        public int Score { get; protected set; } = 0;

        protected Gambler(string name)
        {
            this.Name = name;
        }

        public abstract void FetchNewNumber(object sender, int num);

    }
}
