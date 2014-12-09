using System;
using System.Data.Entity;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Jabberwocky.EF.Library;
using Jabberwocky.EF.Library.DAL;
using Jabberwocky.EF.Library.Models;
using Crypto;

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

            Assert.AreEqual(2, users.Count, "Wrong number of users returned");
            Assert.AreEqual("Janette", users[0].GivenName, "GivenName is not correct");
            Assert.IsTrue(PasswordProtector.VerifyPassword("123456", users[0].PasswordHash), "Password is incorrect");

        }
    }
}
