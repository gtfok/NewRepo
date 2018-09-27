using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NY_gift.Interfaces
{

   public  interface ISweetness
    {
        double SugarPerUnit { get; }
        string Name { get; }
        double Calories { get; }
        string TypeOfSweetness { get; }
        double Weight { get; }
        string ItemInfo { get; }

    }
}
