using System.Xml.Linq;

namespace Bossfight2
{
    internal class Program
    {
        public static Hero Kratos = new Hero(200, "Kratos", 20, 40);
        public static Boss Zeus = new Boss(400, "Zeus", 10);
        static void Main()
        {
            Bossfight();
        }

        public static void Bossfight()
        {
            while (Kratos.gethealth() > 0 && Zeus.gethealth() > 0)
            {
                if (Kratos.getstamina() >= 10)
                {
                    Kratos.Fight(Zeus);
                }
                else{Kratos.Recharge();}

                if (Zeus.getstamina() >= 10)
                {
                    Zeus.Fight(Kratos);
                }
                else {Zeus.Recharge();}
                                
                Thread.Sleep(1000);
               
            }

            if (Kratos.gethealth() <= 0)
            {
                Console.WriteLine($"{Zeus.getname()} is the winner!");
            }
            else if (Zeus.gethealth() <= 0)
            {
                Console.WriteLine($"{Kratos.getname()} is the winner!");
            }
        }
    }
}