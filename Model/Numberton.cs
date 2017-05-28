using System;

namespace Model
{
    public class Numberton
    {
        public event EventHandler<int> NewNumber;

        Random rand = new Random((int)DateTime.Now.Ticks);

        public void Generate()
        {
            var num = rand.Next();
            NewNumber?.Invoke(this, num);
        }
    }
}
