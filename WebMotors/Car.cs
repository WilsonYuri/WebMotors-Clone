using System;

namespace WebMotors
{
    internal class Car
    {
        private int _id;
        private string _plate;
        private string _color;
        private string _brand;
        private string _model;
        private string _year;

        public Car(/*int id,*/
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

