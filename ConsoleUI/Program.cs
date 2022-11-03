using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //VeriDondurme();

            //GetCarsByBrandId();
            //GetCarsByColorId();
            //CarAdd();
            //CarDelete();
            //CarUpdate();

        }

        private static void GetCarsByColorId()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarsByColorId(1);
            foreach (var car in result)
            {
                Console.WriteLine(result);
            }
        }

        private static void CarUpdate()
        {
            ICarService carService = new CarManager(new EfCarDal());
            carService.Update(new Car() { Id = 1, Descriptionn = "updated", DailyPrice = 2247, ModelYear = 1999, });
            Console.WriteLine("Güncellendi!");
        }

        private static void CarDelete()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Delete(new Car { Id = 55, Descriptionn = "Mercedes", DailyPrice = 1200, ModelYear = 2008 });
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Descriptionn + "Silindi");
            }
        }

        private static void CarAdd()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { Id = 55, Descriptionn = "Mercedes", DailyPrice = 1200, ModelYear = 2008 });
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Descriptionn + "Eklendi!");
            }
        }

        private static void GetCarsByBrandId()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarsByBrandId(1);
            foreach (var car in result)
            {
                Console.WriteLine(result);
            }
        }

        private static void VeriDondurme()
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id);
                Console.WriteLine(car.ModelYear);
                Console.WriteLine(car.DailyPrice);
                Console.WriteLine(car.Descriptionn);
                Console.WriteLine("---------------------");
            }
        }
    }
}
