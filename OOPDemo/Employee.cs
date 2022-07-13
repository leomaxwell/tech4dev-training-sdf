#nullable disable

namespace OOPDemo
{
    public class Employee
    {
        private string _name;
        private double _hourlyRate;
        private double _hoursWorked;
        private double _pay;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double HourlyRate
        {
            get { return _hourlyRate; }
            set { _hourlyRate = value; }
        }

        public double HoursWorked
        {
            get { return _hoursWorked; }
            set { _hoursWorked = value; }
        }

        public double GetPay()
        {
            _pay = _hourlyRate * _hoursWorked;
            return _pay;
        }
    }
}