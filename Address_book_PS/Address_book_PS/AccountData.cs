using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_book_PS
{
    internal class AccountData1
    {
        private string username;
        private string password;

        public AccountData1(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public string Username
            { get { return username; } set { username = value; } }

        public string Password
            { get { return password; } set { password = value; } }


    }



    internal class AccountData
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
