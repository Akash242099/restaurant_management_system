using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    class Restaurantmenu
    {
        public static void Chooseoption()
        {

            Console.WriteLine("action to be performed by restaurant ");
            Console.WriteLine("Press 1 for insert type  in menu");
            Console.WriteLine("Press 2 for delete type  in menu");
            Console.WriteLine(" press 3 for update current status of menu");
            Console.WriteLine(" press 4 for show current status of menu to customer ");
            Console.WriteLine(" press 5 sent the waiter to the customer ");
            Console.WriteLine(" \n");
            int action = Convert.ToInt32(Console.ReadLine());

            // int result = 0;

            RestroMenuFunction p = new RestroMenuFunction();
            switch (action)
            {
                case 1:
                    {
                     //   Console.WriteLine("Enter  type");
                     //   string name = (Console.ReadLine());
                        Console.WriteLine("Enter  price");
                        int price = Convert.ToInt32(Console.ReadLine()); 
                        Console.WriteLine("Enter  type");
                        //string planet1 = System.Console.ReadLine();
                        //Type type1 = (Type)Enum.Parse(typeof(Type), planet1);////
                        Type type1 = (Type)Convert.ToInt32(Console.ReadLine());
                        p.AddData(price, type1);
                        Chooseoption();

                        break;
                    }
                case 2:
                    {

                        p.RemoveData();

                        CustomerAction.Chooseoptions();
                        break;
                    }

                case 3:
                    {

                        
                        Console.WriteLine("Enter  type");
                        Type type2 = (Type)Convert.ToInt32(Console.ReadLine());

                        //  Type type2 = (Type)Convert.ToInt32(planet1);

                        //string planet1 = System.Console.ReadLine();
                        // Type type2 = (Type)Enum.Parse(typeof(Type), planet1);
                        //  Type type2 = (Type)Console.ReadLine();
                        Console.WriteLine("Enter  price");
                            int price1 = Convert.ToInt32(Console.ReadLine());
                       
                        p.AddData(price1, type2);
                        Chooseoption();
                        break;

                    }
                case 4:
                    {
                        for (int i = 0; i < RestroMenuFunction.input.Count; i++)
                        {
                            //  if(i == index){
                            //Console.WriteLine("hi");
                            Console.WriteLine(RestroMenuFunction.input[i].price + "," + RestroMenuFunction.input[i].type);
                        }


                        Chooseoption();
                        break;
                    }
                case 5:
                    {
                        CustomerAction.Chooseoptions();
                        break;
                    }
                default:
                    Console.WriteLine("Wrong action!! try again");
                    Chooseoption();
                    break;


            }
        }
    }
}
