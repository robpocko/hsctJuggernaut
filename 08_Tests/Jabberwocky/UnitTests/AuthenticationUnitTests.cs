using System;
using System.Data.Entity;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Jabberwocky.EF.Library;
using Jabberwocky.EF.Library.DAL;
using Jabberwocky.EF.Library.Models;

namespace UnitTests
{
    [TestClass]
    public class AuthenticationUnitTests
    {
        private JabberwockyContext db = new JabberwockyContext();
        
        [TestMethod]
        public void TestMethod1()
        {
            var users = db.JuggernautUsers.OrderBy(u => u.Surname).ThenBy(u => u.GivenName).ToList();

            Assert.AreEqual(1, users.Count, "Wrong number of users returned");
            Assert.AreEqual("Rob", users[0].GivenName, "GivenName is not correct");
        }
    }
}
