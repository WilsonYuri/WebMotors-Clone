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

        public User(int id, string firstname, string lastname, string email, string password, string phonenumber, string cpf, DateTime dateofbirth)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            Password = password;
            PhoneNumber = phonenumber;
            Cpf = cpf;
            DateOfBirth = dateofbirth;

        }
        public int Firstname
        {
            set { _firstname = value;  }
            get { return _firstname; }
        }
        public int Lastname
        {
            set { _lastname = value; }
            get { return _lastname; }
        }

        public int Email
        {
            set { _email = value; }
            get { return _email; }
        }
        public int Password
        {
            set { _password = value; }
            get { return _password; }
        }
        public int Password
        {
            set { _password = value; }
            get { return _password; }
        }
        public int PhoneNumber
        {
            set { _phoneNumber = value; }
            get { return PhoneNumber; }
        }
        public int Cpf
        {
            set { _cPF = value; }
            get { return _cPF; }
        }
        public int DateOfBirth
        {
            set { _dateOfBirth = value; }
            get { return _dateOfBirth; }
        }
    }
}
