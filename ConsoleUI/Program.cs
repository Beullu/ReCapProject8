using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;
using System.ComponentModel.DataAnnotations;

namespace ConsoleUI
{
    //SOLID
    //OPEN CLOSED PRINCIPLE
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var item in carManager.GetByDailyPrice(1000,20000))
            {
                Console.WriteLine(item.CarDescription);
            }
        }
    }
}
