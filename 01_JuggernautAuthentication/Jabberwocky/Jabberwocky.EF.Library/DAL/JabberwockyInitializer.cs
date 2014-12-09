using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Jabberwocky.EF.Library.Models;
using Crypto;

namespace Jabberwocky.EF.Library.DAL
{
    public class JabberwockyInitializer : DropCreateDatabaseIfModelChanges<JabberwockyContext>
    {
        protected override void Seed(JabberwockyContext context)
        {
            AddDefaultUsers(context);
        }

        private void AddDefaultUsers(JabberwockyContext db)
        {
            var users = new List<JuggernautUser>
            {
                new JuggernautUser
                {
                    GivenName = "Rob",
                    Surname = "Pocklington",
                    UserName = "pocko",
                    PasswordHash = PasswordProtector.GenerateHash("123456", PasswordProtector.GenerateSaltValue()),
                    ActiveFrom = DateTime.Parse("1 December 2014")
                },
                new JuggernautUser
                {
                    GivenName = "Janette",
                    Surname = "Pocklington",
                    UserName = "jnetp",
                    PasswordHash = PasswordProtector.GenerateHash("123456", PasswordProtector.GenerateSaltValue()),
                    ActiveFrom = DateTime.Parse("1 December 2014")
                }
            };

            users.ForEach(u => db.JuggernautUsers.Add(u));
            db.SaveChanges();
        }
    }
}
