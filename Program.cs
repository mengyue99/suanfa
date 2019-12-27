using System;

namespace muji
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            for (int x = 0; x <= 20; x++)
            {
                for (int y = 0; y <= 100 / 3; y++)
                {
                    int z = 100 - x - y;
                    if (5 * x + 3 * y + z / 3 == 100 && z % 3 == 0)
                    {
                        Console.WriteLine("公鸡{0}只，母鸡{1}只，小鸡{2}只", x, y, z);
                    }
                }
            }
        }
    }
}