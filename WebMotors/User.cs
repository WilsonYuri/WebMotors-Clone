using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMotors
{
    internal class User
    {
        private int _id;
        private string _firstname;
        private string _lastname;
        private string _email;
        private string _password;
        private string _phoneNumber;
        private string _cPF;
        private DateTime _dateOfBirth;

        public User(/*int id,*/ 
            string firstname, 
            string lastname, 
            string email, 
            string password, 
            string phonenumber, 
            string cpf, 
            DateTime dateofbirth)
        {
             //ID = id;
             Firstname = firstname;
             Lastname = lastname;
             Email = email;
             PassWord = password;
             PhoneNumber = phonenumber;
             Cpf = cpf;
             DateOfBirth = dateofbirth;

        }

        public int ID
        {
            set{ _id = value; }
            get { return _id; }
        }
        public String Firstname
        {
            set { _firstname = value;  }
            get { return _firstname; }
        }
        public String Lastname
        {
            set { _lastname = value; }
            get { return _lastname; }
        }

        public String Email
        {
            set { _email = value; }
            get { return _email; }
        }
        public String PassWord
        {
            set { _password = value; }
            get { return _password; }
        }
        public String Password
        {
            set { _password = value; }
            get { return _password; }
        }
        public String PhoneNumber
        {
            set { _phoneNumber = value; }
            get { return PhoneNumber; }
        }
        public String Cpf
        {
            set { _cPF = value; }
            get { return _cPF; }
        }
        public DateTime DateOfBirth
        {
            set { _dateOfBirth = value; }
            get { return _dateOfBirth; }
        }
    }
}
