using Microsoft.VisualStudio.TestTools.UnitTesting;
using P045_Generics.Domain.Interfaces;
using P045_Generics.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P045_Generics.Domain.Models.Tests
{
    [TestClass()]
    public class EntityRepositoryTests
    {
        [TestMethod()]
        public void Add_addingNewUse_returnsTest()
        {


            int expected = 2;
           
            //arrange
            IEntityRepository<IUser> repository = new EntityRepository<IUser>();
            
            IUser fakePrivateClient = new PrivateClient();
            IUser fakeBusinessClient = new BusinessClient();

            //act
            repository.Add(fakePrivateClient);
            repository.Add(fakeBusinessClient);
            int actual = repository.Fetch().Count();

            //assert
            
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RemoveTest()
        {

            int expected = 1;

            //arrange
            IEntityRepository<IUser> repository = new EntityRepository<IUser>();

            IUser fakePrivateClient = new PrivateClient();
            IUser fakeBusinessClient = new BusinessClient();

            //act
            repository.Add(fakePrivateClient);
            repository.Add(fakeBusinessClient);
            repository.Remove(fakePrivateClient);
            int actual = repository.Fetch().Count();

            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FetchTest()
        {
            int expected = 3;

            //arrange
            IEntityRepository<IUser> repository = new EntityRepository<IUser>();

            IUser fakePrivateClient = new PrivateClient();
            IUser fakeBusinessClient = new BusinessClient();

            //act
            repository.Add(fakePrivateClient);
            repository.Add(fakeBusinessClient);
            repository.Remove(fakePrivateClient);
            repository.Add(fakeBusinessClient);
            repository.Add(fakeBusinessClient);
            int actual = repository.Fetch().Count();

            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Fetch_CreatingWithCtr_ReturnsSameList()
        {
            //Arrange
            IUser fakePrivateClient = new PrivateClient();
            IUser fakeBusinessClient = new BusinessClient();
            List<IUser> expected = new List<IUser>()
            { fakePrivateClient, fakeBusinessClient};
            List<IUser> fakeUsers = new List<IUser>()
            { fakePrivateClient, fakeBusinessClient };
            EntityRepository<IUser> repository = new EntityRepository<IUser>(fakeUsers);

            //Act
            List<IUser> actual = repository.Fetch();

            //Assert
            CollectionAssert.AreEqual(expected, actual);
            Assert.AreEqual(expected[0].Name, actual[0].Name);
            Assert.AreEqual(expected[1].Name, actual[1].Name);
        }

        [TestMethod()]
        public void Remove_CreatingWithCtr_ReturnsSmallerList()
        {
            //Arrange
            IUser fakePrivateClient = new PrivateClient();
            IUser fakeBusinessClient = new BusinessClient();
            List<IUser> expected = new List<IUser>()
            { fakePrivateClient};
            List<IUser> fakeUsers = new List<IUser>()
            { fakePrivateClient, fakeBusinessClient };
            EntityRepository<IUser> repository = new EntityRepository<IUser>(fakeUsers);

            //Act
            repository.Remove(fakeBusinessClient);
            List<IUser> actual = repository.Fetch();

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

    }
}