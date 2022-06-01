using System;
using System.Collections.Generic;
using System.Text;

namespace _2iyun
{
    internal class User
    {
        private string _userName;
        private string _password;

        public User(string userName)
        {
            UserName = userName;

        }

        public string UserName
        {
            get { return _userName; }
            set
            {
                if (value.Length > 5 && value.Length < 26)
                {
                    _userName = value;
                }

            }

        }
        public string Password
        {
            get { return _password; }
            set
            {

                if (value.Length > 7 && value.Length < 25)
                {
                    if (HasDigit(value) && HasUpper(value) && HasLower(value))
                    {
                        _password = value;

                    }
                }
            }
        }
        public bool HasUpper(string word)
        {
            bool check = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (Char.IsUpper(word[i]))
                {
                    check = true;
                    break;
                }

            }
            return check;
        }
        public bool HasLower(string word)
        {
            bool check = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (Char.IsLower(word[i]))
                {
                    check = true;
                    break;
                }

            }
            return check;
        }
        public bool HasDigit(string word)
        {
            bool check = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (Char.IsDigit(word[i]))
                {
                    check = true;
                    break;
                }

            }
            return check;
        }
    }


}
