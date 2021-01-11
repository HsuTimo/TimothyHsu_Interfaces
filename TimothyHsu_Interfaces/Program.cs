using System;
using TimothyHsu_Interfaces.Models;

namespace TimothyHsu_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Transaction transaction1 = new Transaction("0001","30/12/2019",50);
            Transaction transaction2 = new Transaction("0002","31/12/2019",376);
            transaction1.ShowTransaction();
            Console.WriteLine("-----------------------------");
            transaction2.ShowTransaction();
        }
    }
}
