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
        public Chocolate(string name, double weight, double sugar, double calories,  TypeOfChocolate typeofchoco )
            : base(name, weight, sugar, calories )
        {
            TypeOfChocolate = typeofchoco;
            
        }
        public override string TypeOfSweetness => "Chocolate";
        
        public override string ItemInfo => string.Format(" (0), weight: (1),sugar: (2),calories: (3)", Name, Weight, SugarPerUnit, Calories);
    }
}
