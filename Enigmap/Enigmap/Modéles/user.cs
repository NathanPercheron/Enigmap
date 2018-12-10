using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Enigmap.Modéles
{
    class user
    {
        private string _username;
        private string _password;

        public static ArrayList CollClassUser = new ArrayList();



        public user(string username, string password)
        {
            _username = username;
            _password = password;
        }

        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
    }
}
