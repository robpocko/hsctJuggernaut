using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Crypto
{
    public class PasswordProtector
    {
        private PasswordProtector() { }

        public static string GenerateSaltValue()
        {
            return BCrypt.Net.BCrypt.GenerateSalt(8);
        }

        public static string GenerateHash(string rawPassword, string salt)
        {
            return BCrypt.Net.BCrypt.HashPassword(rawPassword, salt);
        }

        public static bool VerifyPassword(string rawPassword, string hash)
        {
            return BCrypt.Net.BCrypt.Verify(rawPassword, hash);
        }
        
    }
}
