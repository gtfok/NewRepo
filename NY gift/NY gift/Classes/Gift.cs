using NY_gift.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NY_gift.Classes
{
    public class Gift : INYGift
    {
        private ICollection<ISweetness> swetnessitems; 
        public IEnumerable<ISweetness>Items
        {
            get { return swetnessitems; }
        }
        public double GiftWeight { get; }
        public int CountOfSweet { get; }
        public string NameOfGift { get; }

        public  void AddSweet(Sweet sweets)
        {
            swetnessitems.Add(sweets);
        }

       
        public void DelSweet(Sweet sweets)
        {

        }

        public IEnumerable<ISweetness> SortSweetnessByWeight()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ISweetness> FindSweetnessBySugar(int min, int max)
        {
            throw new NotImplementedException();
        }

        public Gift(string name, ICollection<ISweetness> items)

        {
            
            NameOfGift = name;
            swetnessitems = items;
        }
    
    }       
                

}
