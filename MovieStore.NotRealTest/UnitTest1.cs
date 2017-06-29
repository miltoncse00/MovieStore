using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieStore.Data.EntityF.DbEntity;
using MovieStore.Data.EntityF.DbManager;

namespace MovieStore.NotRealTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var dbContext = new MoveStoreDbContext();
            var list = dbContext.Producer.List;

        }
    }
}
