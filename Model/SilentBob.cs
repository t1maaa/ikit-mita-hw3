namespace Model
{
    public class SilentBob : Gambler
    {
        public SilentBob() : base("SilentBob")
        {

        }

        public override void FetchNewNumber(object sender, int num)
        {
            if (!num.IsEven())
                Score++;
        }
    }
}
