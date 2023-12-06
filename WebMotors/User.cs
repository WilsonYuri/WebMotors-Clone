using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
        private string _plate;
        private string _color;
        private string _brand;
        private string _model;
        private string _year;

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

        public User(
            string plate,
            string color,
            string brand,
            string model,
            string year)
        {
            //ID = id;
            Plate = plate;
            Color = color;
            Brand = brand;
            Model = model;
            Year = year;
        }

        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        public String Firstname
        {
            set { _firstname = value; }
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
            get { return _phoneNumber; }
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
        public String Plate
        {
            set { _plate = value; }
            get { return _plate; }
        }
        public String Color
        {
            set { _color = value; }
            get { return _color; }
        }

        public String Brand
        {
            set { _brand = value; }
            get { return _brand; }
        }
        public String Model
        {
            set { _model = value; }
            get { return _model; }
        }
        public String Year
        {
            set { _year = value; }
            get { return _year; }
        }
    }
}
