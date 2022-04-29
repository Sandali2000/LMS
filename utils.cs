using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace WindowsFormsApp2
{
    public class utils
    {
        public static string hashpassword(string password)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();

            byte[] passord_byte = Encoding.ASCII.GetBytes(password);

            byte[] encrypted_bytes = sha1.ComputeHash(passord_byte);
            return Convert.ToBase64String(encrypted_bytes);
        }
    }
}
