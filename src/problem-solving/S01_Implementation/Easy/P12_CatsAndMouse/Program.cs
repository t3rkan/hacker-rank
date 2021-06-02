using System;

namespace P12_CatsAndMouse
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++) {
                string[] xyz = Console.ReadLine().Split(' ');

                int x = Convert.ToInt32(xyz[0]);

                int y = Convert.ToInt32(xyz[1]);

                int z = Convert.ToInt32(xyz[2]);

                string result = CatAndMouse(x, y, z);

                Console.WriteLine(result);
            }
        }
        static string CatAndMouse(int x, int y, int z)
        {
            if (Math.Abs(x - z) < Math.Abs(y - z))
            {
                return "Cat A";
            }
            else if (Math.Abs(x - z) > Math.Abs(y - z))
            {
                return "Cat B";
            }
            else
            {
                return "Mouse C";
            }
        }
    }
}
