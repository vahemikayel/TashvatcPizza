using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsTraining
{
    public class PizzaOrder
    {
        private int _employeesCount;
        private List<int> _pizzaTypes;
        private List<Tuple<int, int, int>> _employyeePizzaPairs;
        

        public PizzaOrder()
        {
           
        }
        public void GenerateOrder(int EmployeesCount)
        {
            _employyeePizzaPairs = new List<Tuple<int, int, int>>();
            Random rnd = new Random();
            for (int i = 0; i < EmployeesCount; i++)
            {
                string c1 = Console.ReadLine();
                int i1 = Int32.Parse(c1);
                string c2 = Console.ReadLine();
                int i2 = Int32.Parse(c2);
                _employyeePizzaPairs.Add(new Tuple<int, int, int>(i,i1, i2));
                
            }
            foreach(var item in _employyeePizzaPairs)
            Console.WriteLine(item);
        }

        public void SetEemployyeePizzaPairs(List<Tuple<int, int, int>> tuples)
        { _employyeePizzaPairs = tuples; }

        public void SetPizasPricies(List<int> pizzaTypes)
        { _pizzaTypes = pizzaTypes; }
        public void SetEmployeesCount(int count)
        { _employeesCount = count; }
        public List<int> GetTotalPizzaCount()
        {
            int[] result = new int[_pizzaTypes.Count()];
            
            foreach (var peac in _employyeePizzaPairs)
            {
                for (int i = 0; i < _pizzaTypes.Count(); i++)
                {
                    if (peac.Item2 == i)
                    {
                        result[i] += 1;
                    }
                    if (peac.Item3 == i)
                    {
                        result[i]+=1;
                    }
                }

            }
            List<int> verjnakan = new List<int>();
            for(int i=0;i<result.Count();i++)
            {
                int res = result[i] / result.Count();
                    if (result[i] % result.Count() > 0)
                    verjnakan.Add(res + 1);
                    else
                    verjnakan.Add(res);
            }
            return verjnakan;
        }


        //    foreach (var piza in order1)
        //    {
        //        foreach(var item in PizzaTypes)
        //        {
                   

        //        }
        //        switch (piza.Item2)
        //        {
        //            case 0: piza1 += 1; break;
        //            case 1: piza2 += 1; break;
        //            case 2: piza3 += 1; break;
        //        }
        //        switch (piza.Item3)
        //        {
        //            case 0: piza1 += 1; break;
        //            case 1: piza2 += 1; break;
        //            case 2: piza3 += 1; break;
        //        }

        //    }

        //    int pizza1Total = piza1 / count;
        //    if (piza1 % count > 0)
        //        Result.Add(pizza1Total + 1);
        //    else
        //        Result.Add(pizza1Total);

        //    int pizza2Total = piza2 / count;
        //    if (piza2 % count > 0)
        //        Result.Add(pizza1Total + 1);
        //    else
        //        Result.Add(pizza2Total);

        //    int pizza3Total = piza3 / count;
        //    if (piza3 % count > 0)
        //        Result.Add(pizza3Total + 1);
        //    else
        //        Result.Add(pizza3Total);

        //    return Result;
        //}
        public int GetAvergePrice(List<int> WholePizzaPrices,int EmployeesCount)
        {
            return WholePizzaPrices.Sum() / EmployeesCount;
        }
       
       
        public List<int> GetListofPriceFromOrder(List<int> list)
        {
            List<int> OrderPriceByItems = new List<int>();
            for (int i = 0; i < list.Count(); i++)
            {
                OrderPriceByItems.Add(_pizzaTypes[i] * list[i]);
            }
            return OrderPriceByItems;
        }


        //public List<int> GetTotalPizzaCountNew(List<int>Products)
        //{ 
        //    int piza1 = 0, piza2 = 0, piza3 = 0;
        //    foreach (var piza in order1)
        //    {
        //        switch (piza.Item2)
        //        {
        //            case 0: piza1 += 1; break;
        //            case 1: piza2 += 1; break;
        //            case 2: piza3 += 1; break;
        //        }
        //        switch (piza.Item3)
        //        {
        //            case 0: piza1 += 1; break;
        //            case 1: piza2 += 1; break;
        //            case 2: piza3 += 1; break;
        //        }

        //    }


        //    int pizza1Total = piza1 / count;
        //    if (piza1 % count > 0)
        //        Result.Add(pizza1Total + 1);
        //    else
        //        Result.Add(pizza1Total);

        //    int pizza2Total = piza2 / count;
        //    if (piza2 % count > 0)
        //        Result.Add(pizza1Total + 1);
        //    else
        //        Result.Add(pizza2Total);

        //    int pizza3Total = piza3 / count;
        //    if (piza3 % count > 0)
        //        Result.Add(pizza3Total + 1);
        //    else
        //        Result.Add(pizza3Total);

        //    return Result;
        //}
    }
}
