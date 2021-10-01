using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    
   public class Customer
    {

        public static List<CustomerField> customer_order = new List<CustomerField>();
        int Final_Bill = 0;
        public void  order(int quantity1,Type type5)
        {
         
            CustomerField data = new CustomerField { quantity = quantity1, type1 = type5 };
            var obj = RestroMenuFunction.input.FirstOrDefault(x => x.type == type5);
            if (obj != null)
            {
                customer_order.Add(data);
                  Final_Bill += quantity1*obj.price;
            }
        }
         public void  remove_order(Type type5)
        {
  customer_order.RemoveAll(x=>x.type1==type5);

           
        }

        
        public void bill()
        {



            int q = 0,s=0;
            foreach (var p in customer_order)
            {
                
                var obj = RestroMenuFunction.input.FirstOrDefault(x => x.type ==p.type1);
                if (obj != null) q =obj.price;
                Console.WriteLine(  p.quantity +"  " + p.type1+ " " + q);
                s = s + q;
            }

            Console.WriteLine("totalbill" + "    " +q);
        }

}
}
