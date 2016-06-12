using System;
using System.Collections;
using System.ServiceModel;
using System.Threading;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceReference1.GoodStockServiceClient proxy = new ServiceReference1.GoodStockServiceClient("GoodStockService"))
            {
                Console.WriteLine(proxy.GetStockPrice("MSFT"));
            }
            using (ServiceReference1.GreatStockServiceClient proxy = new ServiceReference1.GreatStockServiceClient("BetterStockService"))
            {
                Console.WriteLine(proxy.GetStockPriceFast("MSFT"));
            }
            using (ServiceReference1.GreatStockServiceClient proxy = new ServiceReference1.GreatStockServiceClient("BestStockService"))
            {
                Console.WriteLine(proxy.GetStockPriceFast("MSFT"));
            }
            using (ServiceReference1.AllStockServicesClient proxy = new ServiceReference1.AllStockServicesClient("AllStockServices"))
            {
                Console.WriteLine(proxy.GetStockPriceFast("MSFT"));
            }

            Console.ReadLine();
        }
    }
}


