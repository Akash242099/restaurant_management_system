using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{

    class RestroMenuFunction
    {
        public static List<ReatroMenuField> input = new List<ReatroMenuField>()
        //{

        //        new MenuField() { price = 200, type=(Type)Enum.Parse(typeof(Type), "Chicken_Biryani") } ,
        //        new MenuField() { price = 300, type=(Type)Enum.Parse(typeof(Type), "Punjabi_Chicken") } ,
        //        new MenuField() { price = 100,type=(Type)Enum.Parse(typeof(Type), "Paneer_Sahi") }


        //};
        {


                       new ReatroMenuField() { price = 200, type=Type.Chicken_Biryani } ,
               new ReatroMenuField() { price = 300, type=Type.Punjabi_Chicken } ,
               new ReatroMenuField() { price = 100,type=Type.Paneer_Sahi}








        };





    public void AddData(int price, Type types)
        {
            ReatroMenuField data = new ReatroMenuField { price = price,  type =types };
                 input.Add(data);
        }
        public void RemoveData()
        {
           // Class1.Book bookdata = new Class1.Book { name = names, auther = authornames, booktype = booktypes };
                 input.RemoveAt(input.Count - 1);
        }

        public void Update(int price1, Type types1)
        {

            var obj = RestroMenuFunction.input.FirstOrDefault(x => x.type == types1);
            if (obj != null) obj.price = price1;
        }

    }
}
