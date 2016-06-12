using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Configuration;
using System.Threading;
using System.Messaging;

namespace EssentialWCF
{
    [ServiceContract]
    public interface IGoodStockService
    {
        [OperationContract]
        double GetStockPrice(string ticker);
    }
    [ServiceContract]
    public interface IGreatStockService
    {
        [OperationContract]
        double GetStockPriceFast(string ticker);
    }

    [ServiceContract]
    public interface IAllStockServices : IGoodStockService, IGreatStockService { };

    public class AllStockServices : IAllStockServices
    {
        public double GetStockPrice(string ticker)
        {
            Thread.Sleep(5000);
            return 100.00;
        }
        public double GetStockPriceFast(string ticker)
        {
            return 100.00;
        }
    }

    public class program
    {
        // Host the service within this EXE console application.
        public static void Main()
        {
            using (ServiceHost serviceHost = new ServiceHost(typeof(AllStockServices)))
            {
                // Open the ServiceHostBase to create listeners and start listening for messages.
                serviceHost.Open();

                Console.WriteLine("Service endpoints:");
                ServiceDescription desc = serviceHost.Description;
                foreach (ServiceEndpoint endpoint in desc.Endpoints)
                {
                    Console.WriteLine("Endpoint - address:  {0}", endpoint.Address);
                    Console.WriteLine("           binding:  {0}", endpoint.Binding.Name);
                    Console.WriteLine("           contract: {0}", endpoint.Contract.Name);
                }

                // The service can now be accessed.
                Console.WriteLine("The service is ready.");
                Console.WriteLine("Press <ENTER> to terminate.\n\n");
                Console.ReadLine();

                // Close the ServiceHostBase to shutdown the service.
                serviceHost.Close();
            }
        }
    }

}
