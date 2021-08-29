using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class ShoppingCartModel
    {
        public delegate void MentionDiscount( decimal subtotal);
        public List<ProductModel> Items { get; set; } = new List<ProductModel>();
        
        public decimal GenerateTotal(MentionDiscount mentionSubtotal,
            Func<List<ProductModel>,decimal,decimal> calculateDiscountedTotal,
            Action<string> TellUserWeAreDiscounting)
        {
            decimal subTotal=Items.Sum(x=> x.Price);
            mentionSubtotal(subTotal);
            TellUserWeAreDiscounting("We are applying your Discount.");
           decimal total = calculateDiscountedTotal(Items, subTotal);
            return total;
        }
    }
}
