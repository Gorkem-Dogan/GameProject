using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    public interface IDiscountService
    {
        void Add(Discount discount);
        void Remove(Discount discount);
        void Update(Discount discount);
        void ShowListOfDiscounts();

    }
}
