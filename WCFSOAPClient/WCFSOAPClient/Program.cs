using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFSOAPClient.ServiceReference1;

namespace WCFSOAPClient
{
    class Program
    {
        static void Main(string[] args)
        {
            DistributorServiceClient client = new DistributorServiceClient();
            var distributors = client.GetAllDistributors();
            foreach (var d in distributors)
            {
                Console.WriteLine(d.BODS_Id);
                Console.WriteLine(d.BODS_FullName);                
                Console.WriteLine(d.BODS_Status);
            }
            Console.ReadLine();
        }
    }
}
