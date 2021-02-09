using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            Console.WriteLine("Car_ID  |  Info");

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id + "          " + car.Description);
            }
        }
    }
}
