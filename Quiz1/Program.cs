using System;

namespace Quiz1
{
    class GravForceBetweenTwoObjs
    {
        public double MassObj1 { get; set; }
        public double MassObj2 { get; set; }
        public double DistOfObjs { get; set; }

        private double G = (6.67408 * Math.Pow(10 ,-11));
        public double GravForce
        {
            get { return (G * ((MassObj1 * MassObj2) / (DistOfObjs * DistOfObjs))); }
            private set { }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool gameState = true;
            while (gameState == true)
            {
                GravForceBetweenTwoObjs userForce = new GravForceBetweenTwoObjs();

                Console.WriteLine("Hello!");
                Console.WriteLine("Please enter the mass of your first object in Kilograms: ");
                userForce.MassObj1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter the mass of your second object in Kilograms: ");
                userForce.MassObj2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter the distance between your objects in Meters: ");
                userForce.DistOfObjs = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("The Gravitational force of your objects is {0} newtons!", userForce.GravForce);

                bool varPolice1 = true;
                Console.WriteLine("Would you like to go again? [1] - Yes [0] - NO");
                while (varPolice1 == true)
                {
                    string input = Console.ReadLine();
                    if (input == "1")
                    {
                        varPolice1 = false;
                        break;
                    }
                    if (input == "0")
                    {
                        Console.WriteLine("See Ya LATER");
                        varPolice1 = false;
                        gameState = false;
                    }
                    else
                    {
                        Console.WriteLine("TRY AGAIN :");
                    }
                }
            }
        }
    }
}
