using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotlyNote
{
    public class MyUser
    {
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserPassword { get; set; }    
        public int UserId { get; set; }
        public DateTime UserCreated { get; set; }
        public string UserPhoneNumber { get; set; }

        private string _UserEmail;
        public string UserEmail 
        {
            get { return _UserEmail; }
            set
            {
                if(value.Contains("@"))
                {
                    _UserEmail = value;
                }
                else
                {
                    throw new Exception("Invalid Email Address");
                }
            }
                
        }



        public MyUser()
        {
            UserFirstName = "Untitled";
            UserLastName = "User";
            UserPassword = "password";
        }

        public MyUser(string FirstName, string LastName, string Password, string Email)
        {
            UserFirstName = FirstName;
            UserLastName = LastName;
            UserPassword = Password;
            UserEmail = Email;
        }
        public bool IsEmailValid()
        {
            if (!Email.Contains('@'))
                return true;
            else return false;

        }


    }
}
