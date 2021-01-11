using System;
using TimothyHsu_Interfaces.Interfaces;

namespace TimothyHsu_Interfaces.Models
{
    public class Transaction : Bank, ITransaction
    {
        private readonly string _code;
        private readonly string _date;
        private readonly double _amount;
        private double _commission;

        public Transaction(string code, string date, double amount)
        {
            _code = code;
            _date = date;
            _amount = amount;
        }
        public double GetAmount()
        {
            if (_amount > 100)
            {
                _commission = _amount * (0.5 / 100);
                Console.WriteLine("You will BE charged with extra commission " + _commission);
                return _amount;
            }
            else
            {
                Console.WriteLine("Your account will NOT be charged");
                return _amount;
            }
        }
        public string ShowBankName()
        {
            Console.WriteLine(BankName);
            return BankName;
        }

        public void ShowTransaction()
        {
            Console.WriteLine($"{BankName}\n{Address}");
            Console.WriteLine($"Transaction : {_code}");
            Console.WriteLine($"Date : {_date}");
            Console.WriteLine($"Amount : {_amount}");
            GetAmount();
        }
    }
}
