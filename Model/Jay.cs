namespace Model
{
    public class Jay : Gambler
    {
        public Jay() : base("Jay")
        {

        }

        public override void FetchNewNumber(object sender, int num)
        {
            if (num.IsEven())
                Score++;
        }
    }
}
