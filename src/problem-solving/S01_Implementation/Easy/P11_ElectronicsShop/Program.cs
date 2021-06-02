using System;

namespace P11_ElectronicsShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bnm = Console.ReadLine().Split(' ');

            int b = Convert.ToInt32(bnm[0]);

            int n = Convert.ToInt32(bnm[1]);

            int m = Convert.ToInt32(bnm[2]);

            int[] keyboards = Array.ConvertAll(
                Console.ReadLine().Split(' '), 
                keyboardsTemp => Convert.ToInt32(keyboardsTemp));

            int[] drives = Array.ConvertAll(
                Console.ReadLine().Split(' '), 
                drivesTemp => Convert.ToInt32(drivesTemp));

            int moneySpent = GetMoneySpent(keyboards, drives, b);

            Console.WriteLine(moneySpent);
        }

        static int GetMoneySpent(int[] keyboards, int[] drives, int b) 
        {
            var moneySpent = -1;

            foreach (var k in keyboards)
            {
                foreach (var d in drives)
                {
                    var tempMoneySpent = k + d;

                    if (tempMoneySpent <= b)
                    {
                        if (tempMoneySpent > moneySpent)
                        {
                            moneySpent = tempMoneySpent;
                        }
                    }
                }
            }

            return moneySpent;
        }
    }
}
