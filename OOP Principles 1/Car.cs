using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles_1
{
    //1. Implement a Car class which has fields to store teh car's make, model, registration, year, and current value.
    public class Car
    {
        //Member Variables
        private string _make;
        private string _model;
        private string _registration;
        private int _year;
        private double _value;

        //2. Implement a constructor for the Car class which takes parameters corresponding to each of the fields above and constructs an object with these values.
        //Constructor
        public Car(string Make, string Model, string Registration, int Year, int Value)
        {
            _make = Make;
            _model = Model;
            _registration = Registration;
            _year = Year;
            _value = Value;
        }

        //3. Implement a method which returns the current value of the car, and one that returns the year of the car.
        //Methods
        public double carValue()
        {
            return _value;
        }

        public int carYear()
        {
            return _year;
        }

        //4. Override ToString() to return a string containing full information about the car.
        public override string ToString()
        {
            return String.Format("Car Make: {0}\n" + "Car Model: {1}\n" + "Car Registration: {2}\n" + "Car Year: {3}\n" + "Car Value: {4}", _make, _model, _registration, _year, _value );
        }

    }
}
