using NY_gift.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NY_gift.Classes
{
    public class Candy : Sweet
    {
        public TypeOfCandies TypeOfCandies;

        public Candy(string name, double weight, string item, double sugar, double calories, string typeOfSweetness, TypeOfCandies candy)
        : base(name, weight, item, sugar, calories, typeOfSweetness)
        {
            TypeOfCandies = candy;
            typeOfSweetness = "Candy";
        }
}

}
