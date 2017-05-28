namespace Model
{
    public static class IntExtension
    {
        public static bool IsEven(this int num)
        {
            return num % 2 == 0;
        }
    }
}
