using NY_gift.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NY_gift.Interfaces
{
    public interface INYGift
    {
        double GiftWeight { get; }
        int CountOfSweet { get; }
        string NameOfGift { get; }
        IEnumerable<ISweetness> Items { get; }
        IEnumerable<ISweetness> SortSweetnessByWeight();
        IEnumerable<ISweetness> FindSweetnessBySugar(double min, double max);

        void AddSweet(Sweet sweets);
        void DelSweet(Sweet sweets);

    }
}
