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
            //CarGetAll();
            //CarGetById();
            //BrandAdd();
            //BrandDelete();
            //BrandUpdate();
            //BrandGetAll();
            //BrandGetById();
            //ColorAdd();
            //ColorDelete();
            //ColorUpdated();
            //ColorGetAll();
            //ColorGetById();
            //DtoBirleşimi();

        }

        private static void DtoBirleşimi()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.BrandName + "/" + car.ModelName + "/" + car.ColorName + "/" + car.DailyPrice);
            }
        }

        private static void ColorGetById()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.GetById(1);
        }

        private static void ColorGetAll()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.Id + " " + color.Name);
            }
        }

        private static void ColorUpdated()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Update(new Color { Id = 2, Name = "Blue" });
            Console.WriteLine("Color Updated");
        }

        private static void ColorDelete()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Delete(new Color { Id = 4, Name = "Blue" });
            Console.WriteLine("Color removed.");
        }

        private static void ColorAdd()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { Id = 5, Name = "Yellow" });
                Console.WriteLine("Color Added.");
        }

        private static void CarGetById()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.GetById(1);
        }

        private static void CarGetAll()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id + " " + car.DailyPrice + " " + car.Descriptionn /* + eklenebilir. */);
            }
        }

        private static void BrandGetById()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.GetById(1);
        }

        private static void BrandGetAll()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.Id + " " + brand.Name);
            }
        }

        private static void BrandUpdate()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Update(new Brand { Id = 2, Name = "Honda" });
                Console.WriteLine("Brand updated.");
        }

        private static void BrandDelete()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Delete(new Brand { Id = 4, Name = "Honda" });
                Console.WriteLine("Brand removed.");
        }

        private static void BrandAdd()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { Id = 4, Name = "Honda" });
                Console.WriteLine("Brand added.");
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
            CarManager carService = new CarManager(new EfCarDal());
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
