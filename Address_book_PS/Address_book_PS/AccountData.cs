using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_book_PS
{
    

    public class AccountData
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public AccountData(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

    }

}
