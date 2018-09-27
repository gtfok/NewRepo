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
        public double GiftWeight { get; }
        public int CountOfSweet { get; }
        public string NameOfGift { get; }

         void AddSweet(Sweet sweets)
        {

        }

        void INYGift.AddSweet(Sweet sweets)
        {
            throw new NotImplementedException();
        }

        void DelSweet(Sweet sweets)
        {

        }

        void INYGift.DelSweet(Sweet sweets)
        {
            throw new NotImplementedException();
        }
        public Gift( double weight, int count, string name)
        {
            GiftWeight = weight;
            CountOfSweet = count;
            NameOfGift = name;
        }
    }       
                

}
