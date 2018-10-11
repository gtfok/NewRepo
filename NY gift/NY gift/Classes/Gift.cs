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
       
        public string NameOfGift { get; }

        public  void AddSweet(Sweet sweets)
        {
            swetnessitems.Add(sweets);
        }

       
        public void DelSweet(Sweet sweets)
        {
            swetnessitems.Remove(sweets);

        }
        public int CountOfSweet
        {
            get {return swetnessitems.Count();}

        }
        public double GiftWeight
            {
            get {
                if (swetnessitems != null)
                    {
                        return swetnessitems.Sum(x=> x.Weight);

                    }
                else{
                        throw new InvalidOperationException("Container cannot be full");
                    }
                }
            }

        public IEnumerable<ISweetness> SortSweetnessByWeight()
        {
            var temp = swetnessitems.OrderBy(x => x.Weight).ToArray();
            return temp;
        }

        public IEnumerable<ISweetness> FindSweetnessBySugar(double min, double max)
        {
            return swetnessitems.Where(x =>(x.SugarPerUnit >= min)
            && (x.SugarPerUnit <= max)).ToList();
        }

        public Gift(string name, ICollection<ISweetness> items)

        {
            
            NameOfGift = name;
            swetnessitems = items;
        }

    
    }       
                

}
