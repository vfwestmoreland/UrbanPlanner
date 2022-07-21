namespace UrbanPlanner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building myHouse = new Building("709 Nowhere Lane");
            myHouse.Width = 45;
            myHouse.Depth = 54;
            myHouse.Stories = 3;

            Building herHouse = new Building("2909 Cornwallis");
            herHouse.Width = 29.1;
            herHouse.Depth = 21.9;
            herHouse.Stories = 2;

            Building hisHouse = new Building("1106 Grayland");
            hisHouse.Width = 15.9;
            hisHouse.Depth = 10.7;
            hisHouse.Stories = 1;

            Building theirHouse = new Building("1 Park Glenn");
            theirHouse.Width = 25.3;
            theirHouse.Depth = 75.8;
            theirHouse.Stories = 2;

            myHouse.Construct();
            herHouse.Construct();
            hisHouse.Construct();
            theirHouse.Construct();

            myHouse.Purchase("Mikelon");
            herHouse.Purchase("Jeff Wheyzos");
            hisHouse.Purchase("Wesser Weasel");
            theirHouse.Purchase("Logie Lox");

            myHouse.printInfo();
            Console.WriteLine();
            herHouse.printInfo();
            Console.WriteLine();
            hisHouse.printInfo();
            Console.WriteLine();
            theirHouse.printInfo();
            


        }
    }
}