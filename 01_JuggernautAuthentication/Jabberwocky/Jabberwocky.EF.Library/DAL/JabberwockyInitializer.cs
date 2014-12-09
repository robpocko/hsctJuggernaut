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
            var user = new List<JuggernautUser>
            {
                new JuggernautUser
                {
                    GivenName = "Rob",
                    Surname = "Pocklington",
                    UserName = "pocko",
                    Password = PasswordProtector. "123456" + PasswordProtector.GenerateSaltValue(),
                    ActiveFrom = DateTime.Parse("1 December 2014")
                }
            };

            user.ForEach(u => db.JuggernautUsers.Add(u));
            db.SaveChanges();
        }
    }
}
