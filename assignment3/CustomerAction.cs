using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    class CustomerAction
    {

        public static void Chooseoptions()
        {

            Console.WriteLine("Enter the action to be performed");
            Console.WriteLine("Press 1 for for your order ");
            Console.WriteLine("Press 2 for remove order");
            Console.WriteLine(" press 3 bill generation ");
            Console.WriteLine(" press 4 for exit ");
            Console.WriteLine(" \n");
            int action = Convert.ToInt32(Console.ReadLine());

            // int result = 0;

            Customer s = new Customer();
            switch (action)
            {
                case 1:
                    {
                        //   Console.WriteLine("Enter  type");
                        //   string name = (Console.ReadLine());
                        Console.WriteLine("Enter  quentity");
                        int q = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter  type");
                        //string planet1 = System.Console.ReadLine();
                        //Type type1 = (Type)Enum.Parse(typeof(Type), planet1);////
                        Type type1 = (Type)Convert.ToInt32(Console.ReadLine());
                        s.order(q, type1);
                        Chooseoptions();

                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter  type");
                        //string planet1 = System.Console.ReadLine();
                        //Type type1 = (Type)Enum.Parse(typeof(Type), planet1);////
                        Type type1 = (Type)Convert.ToInt32(Console.ReadLine());

                        s.remove_order(type1);

                        Chooseoptions();
                        break;
                    }

                case 3:
                    {

                        s.bill();
                         Chooseoptions();
                        break;

                    }
                case 4:
                    {
                  
                        break;
                    }
                default:
                    Console.WriteLine("Wrong action!! try again");
                    Chooseoptions();
                    break;


            }
        }
    }
}


