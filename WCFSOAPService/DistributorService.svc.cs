using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using WCFSOAPService.DAL;
using WCFSOAPService.Model;

namespace WCFSOAPService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DistributorService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select DistributorService.svc or DistributorService.svc.cs at the Solution Explorer and start debugging.
    public class DistributorService : IDistributorService
    {
        public Distributor Add(Distributor e)
        {
            Distributor Distributor = new Distributor();
            Distributor.BODS_Id = e.BODS_Id;
            Distributor.BODS_FullName = e.BODS_FullName;
            Distributor.BODS_Status = e.BODS_Status;

            return Distributor;
        }

        public List<Distributor> Edit(List<Distributor> distributors)
        {         
            foreach (DataRow row in TestDataSource.DataTable.Rows)
            {
                var item = distributors.FirstOrDefault(x => x.BODS_Id == row.Field<Guid>("BODS_Id"));
                if (item != null)
                {
                    row.SetField("BODS_FullName", item.BODS_FullName);
                    row.SetField("BODS_Status", item.BODS_Status);
                }
            }
            return distributors;
        }

        public List<Distributor> GetAllDistributors()
        {
            var table = TestDataSource.DataTable.AsEnumerable();
            var distributorList = (from row in table
                                   select new Distributor
                                   {
                                       BODS_Id = row.Field<Guid>("BODS_Id"),
                                       BODS_FullName = row.Field<string>("BODS_FullName"),
                                       BODS_Status = row.Field<byte>("BODS_Status")
                                   }).ToList();
            return distributorList;
        }      
    }
    
}
