using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WCFSOAPService.Model;
using System.Collections.Generic;

namespace WCFSOAPService.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetAllDistributor_Valid()
        {
            //arrange
            IDistributorService service = new DistributorService();
           
            //Act
            var actual = service.GetAllDistributors();

            //Assert
            Assert.AreEqual(3, actual.Count);
        }

        [TestMethod]
        public void AddDistributor_Valid()
        {
            //arrange
            IDistributorService service = new DistributorService();
            var distributor = new Distributor();
            distributor.BODS_FullName = "Agung Pradnya";
            distributor.BODS_Id = new Guid("617dba9d-391b-4ca7-aeeb-0703ca526709");
            distributor.BODS_Status = 1;

            //Act
            var actual = service.Add(distributor);

            //Assert
            Assert.AreEqual("Agung Pradnya", actual.BODS_FullName);
        }

        [TestMethod]
        public void EditDistributor_Valid()
        {
            //arrange
            var distributorUpdated = new Distributor
            {
                BODS_Id = Guid.Parse("5df458a8-a743-4e81-bf0d-bd874f6f0cd3"),
                BODS_FullName = "Edit Full Name",
                BODS_Status = 3
            };
            IDistributorService service = new DistributorService();

            //Act
            var response = service.Edit(new List<Distributor> { distributorUpdated });
            var distributor = ((List<Distributor>)response).Find(x => x.BODS_Id == new Guid(("5df458a8-a743-4e81-bf0d-bd874f6f0cd3")));

            //Assert
            Assert.AreEqual("Edit Full Name", distributor.BODS_FullName);

        }
    }
}
