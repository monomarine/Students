using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    public abstract class User
    {
        protected int _id;
        protected string _login;
        protected string _password;

        public int ID
        {
            get => _id;
        }

        public string Login
        {
            get => _login;
            set
            {
                if( value.Length  < 5)
                {
                    throw new ArgumentException("некорректная длина логина (не менее 5 символов)");
                }
                else 
                    _login = value; 
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                if (value.Length  < 5)
                {
                    throw new ArgumentException("некорректная длина логина (не менее 5 символов)");
                }
                else
                    _password = value;
            }
        }
    }
}