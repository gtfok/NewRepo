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

        public Candy(string name, double weight, double sugar, double calories, TypeOfCandies candy)
        : base(name, weight, sugar, calories)
        {
            TypeOfCandies = candy;
        }

        public override string TypeOfSweetness => "Candy";
        
        public override string ItemInfo => string.Format(" {0}, weight: {1},sugar: {2},calories: {3}",Name,  Weight,SugarPerUnit,Calories);
    }

}
