using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class DiscountManager : IDiscountService
    {
        List<Discount> discountList;
        public DiscountManager()
        {
            discountList = new List<Discount>();
        }
        public void Add(Discount discount)
        {
            discountList.Add(discount);
        }

        public void Remove(Discount discount)
        {
            discountList.Remove(discount);
        }

        public void Update(Discount discount)
        {
            Console.WriteLine("Discount " + discount.DiscountId + " has been updated");
        }
        public void ShowListOfDiscounts()
        {
            foreach (Discount discount in discountList)
            {
                Console.WriteLine(discount.DiscountId+ " numbered "+ discount.DiscountName+ " has been added to the discount list");
            }
        }
    }
}
