using System.Collections.Generic;
using System.ServiceModel;
using WCFSOAPService.Model;

namespace WCFSOAPService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDistributorService" in both code and config file together.
    [ServiceContract]
    public interface IDistributorService
    {
        [OperationContract]
        List<Distributor> GetAllDistributors();

        [OperationContract]
        Distributor Add(Distributor e);

        [OperationContract]
        List<Distributor> Edit(List<Distributor> e);
     
    }
}
