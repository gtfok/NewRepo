using NY_gift.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NY_gift
{
    class Program
    {
        static void Main(string[] args)
        {
            Candy candy = new Candy("bears in raspberry", 10, 45, 300,  Enum.TypeOfCandies.Caramel);
            Candy candy2 = new Candy("crazy bee", 6, 60, 250,  Enum.TypeOfCandies.Zhele);
            Candy candy3 = new Candy("up",5,  20,  220,  Enum.TypeOfCandies.Lollipop);
            Candy candy4 = new Candy("chupa chups",20, 70, 150,  Enum.TypeOfCandies.Lollipop);
            Candy candy5 = new Candy("cow", 10,  80, 500,  Enum.TypeOfCandies.Caramel);
            Candy candy6 = new Candy("bears in raspberry", 10,  45, 300,  Enum.TypeOfCandies.Caramel);
            Chocolate chocolate = new Chocolate("alpen gold", 100,  40, 540,  Enum.TypeOfChocolate.Milk);

            Console.WriteLine(candy.ItemInfo);
            Console.WriteLine(candy2.ItemInfo);
            Console.ReadKey();


        }
    }
}
