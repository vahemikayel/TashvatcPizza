using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Console.WriteLine("Please Input Pizza Prices");
            List<int> PizzaTypes = new List<int>();
            // for(; ; )
            // {
            //    if (Console.ReadKey().KeyChar == '*')
            //        break;
            //   var input = Int32.Parse(Console.ReadLine());
            //   PizzaTypes.Add(input);

            // }  


            PizzaTypes.Add(2000);
            PizzaTypes.Add(3000);
            PizzaTypes.Add(4000);
            PizzaTypes.Add(5000);

           


            //Console.WriteLine("Please Input Employyes Count");
            int EmployeesCount = 5;


            PizzaOrder order = new PizzaOrder();
            order.SetPizzasPricies(PizzaTypes);
            order.GenerateOrder(EmployeesCount);



            List<int> WholPizza = order.GetTotalPizzaCount();

            foreach (var item in WholPizza)
                Console.WriteLine("\n" + item + " Hat");

            Console.WriteLine("*********************");
            List<int> TotalByPizza = order.GetListofPriceFromOrder(WholPizza);
            foreach (var item in TotalByPizza)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*********************");

            double Averge = order.GetAvergePrice(TotalByPizza);
            Console.WriteLine("Averge Sum is " + Averge);

            Console.ReadLine();
        }
    }
}
