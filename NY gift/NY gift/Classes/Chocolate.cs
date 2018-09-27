using NY_gift.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NY_gift.Classes
{
    public class Chocolate : Sweet
    {
        public TypeOfChocolate TypeOfChocolate;
        public Chocolate(string name, double weight, string item, double sugar, double calories, string typeOfSweetness, TypeOfChocolate typeofchoco )
            : base(name, weight, item, sugar, calories, typeOfSweetness)
        {
            TypeOfChocolate = typeofchoco;
            typeOfSweetness = "Chocolate";
        }
    }
}
