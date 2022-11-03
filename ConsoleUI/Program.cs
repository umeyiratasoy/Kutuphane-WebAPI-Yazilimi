using Business.Abstract;
using Business.Concrete;
using Business.Constants;
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
            var result = carManager.GetCarDetails();
            foreach (var car in result.Data)
            {
                Console.WriteLine(car.BrandName + "/" + car.ModelName + "/" + car.ColorName + "/" + car.DailyPrice);
            }
        }

        private static void ColorGetById()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.GetById(1);
            Console.WriteLine(result.Message);
        }

        private static void ColorGetAll()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.GetAll();
            foreach (var color in result.Data)
            {
                Console.WriteLine(color.Id + " " + color.Name);
            }
        }

        private static void ColorUpdated()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var color = new Color { Id = 2, Name = "Blue" };
            var result = colorManager.Update(color);
            Console.WriteLine(Messages.ColorUpdated);
        }

        private static void ColorDelete()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var color = new Color { Id = 4, Name = "Blue" };
            var result = colorManager.Delete(color);
            Console.WriteLine(Messages.ColorRemoved);
        }

        private static void ColorAdd()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var color = new Color { Id = 5, Name = "Yellow" };
            var result = colorManager.Add(color);
            Console.WriteLine(Messages.ColorAdded);
        }

        private static void CarGetById()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetById(1);
            Console.WriteLine(result.Message);
        }

        private static void CarGetAll()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetAll();
            foreach (var car in result.Data)
            {
                Console.WriteLine(car.Id + " " + car.DailyPrice + " " + car.Descriptionn /* + eklenebilir. */);
            }
        }

        private static void BrandGetById()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetById(1);
            Console.WriteLine(result.Data);

        }

        private static void BrandGetAll()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetAll();
            foreach (var brand in result.Data)
            {
                Console.WriteLine(brand.Id + " " + brand.Name);
            }
        }

        private static void BrandUpdate()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var brand = new Brand { Id = 2, Name = "Honda" };
            var result = brandManager.Update(brand);
            Console.WriteLine(Messages.BrandUpdated);
        }

        private static void BrandDelete()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var brand = new Brand { Id = 4, Name = "Honda" };
            var result = brandManager.Delete(brand);
            Console.WriteLine(Messages.BrandRemoved);
        }

        private static void BrandAdd()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var brand = new Brand { Id = 4, Name = "Honda" };
            var result = brandManager.Add(brand);
            Console.WriteLine(Messages.BrandAdded);
        }

        private static void GetCarsByColorId()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarsByColorId(1);
            foreach (var car in result.Data)
            {
                Console.WriteLine(result);
            }
        }

        private static void CarUpdate()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var car = new Car() { Id = 1, Descriptionn = "updated", DailyPrice = 2247, ModelYear = 1999, };
            var result = carManager.Update(car);
            Console.WriteLine(Messages.CarUpdated);
        }

        private static void CarDelete()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var car = new Car { Id = 55, Descriptionn = "Mercedes", DailyPrice = 1200, ModelYear = 2008 };
            var result = carManager.Delete(car);
            Console.WriteLine(car.Descriptionn + Messages.CarRemoved);
        }

        private static void CarAdd()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var car = new Car { Id = 55, Descriptionn = "Mercedes", DailyPrice = 1200, ModelYear = 2008 };
            var result = carManager.Add(car);
            Console.WriteLine(car.Descriptionn + Messages.CarAdded);
        }
        
        private static void GetCarsByBrandId()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarsByBrandId(1);
            foreach (var car in result.Data)
            {
                Console.WriteLine(result);
            }
        }

        private static void VeriDondurme()
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            var result = carManager.GetAll();
            foreach (var car in result.Data)
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
