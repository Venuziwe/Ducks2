using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    public class Duck
    {
        public bool fly = true;
        public bool crack = true;
    }

    public class NormalDuck : Duck
    {
        public void normalCrack()
        {
            crack = true;
            fly = true;
            if((fly == true) && (crack == true))
            {
                Console.WriteLine("Crack-crack-crack");
            }
        }
    }
    public class WoodenDuck : Duck
    {
        public void unnormalCrack()
        {
            crack = false;
            fly = false;
            if ((fly == false) && (crack == false))
            {
                Console.WriteLine("silent");
            }
        }
    }


    public class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int normal = 0;
            int wooden = 0;
            int n = 0;
            var random = new Random();
            NormalDuck duck1 = new Ducks.NormalDuck();
            WoodenDuck duck2 = new Ducks.WoodenDuck();
            for (i = 0; i < 10; i++)
            {
                int isShot = random.Next(2);
                if (isShot == 1)
                {
                    duck1.normalCrack();
                    normal = normal + 1;
                }
                else
                {
                    duck2.unnormalCrack();
                    wooden = wooden + 1;
                }
            }
            Console.WriteLine($"Normal Ducks:  {normal}");
            Console.WriteLine($"Woooden Ducks:  {wooden}");
            Console.ReadKey();
        }
    }
}
