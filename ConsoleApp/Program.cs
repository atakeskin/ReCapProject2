using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            Designer.ShowWindow(Designer.ThisConsole, 3);
            Console.Clear();

            CarTest(carManager, brandManager, colorManager);

            //BrandTest(brandManager);

            //ColorTest(colorManager);


            Console.ReadKey();
        }

        private static void ColorTest(ColorManager colorManager)
        {
            Designer.Baslik("Color All Lists");
            Designer.PrintRow("Brand ID", "Brand Name");

            foreach (var color in colorManager.GetAll())
            {
                Designer.PrintRow(color.Id.ToString(), color.Name);
            }

            Designer.Baslik("New Color Add");
            colorManager.Add(new Color
            {
                Name = "Blue"
            });
        }

        private static void BrandTest(BrandManager brandManager)
        {
            Designer.Baslik("Brand All Lists");
            Designer.PrintRow("Brand ID", "Brand Name");

            foreach (var brand in brandManager.GetAll())
            {
                Designer.PrintRow(brand.Id.ToString(), brand.Name);
            }

            Designer.Baslik("New Brand Add");
            brandManager.Add(new Brand
            {
                Name = "Kia"
            });

        }

        private static void CarTest(CarManager carManager, BrandManager brandManager, ColorManager colorManager)
        {
            Designer.Baslik("Tümünü Liste");
            Designer.PrintRow("Car ID", "Brand Name", "Color Name", "Model Year", "Daily Price", "Description");

            foreach (var car in carManager.GetAll())
            {
                Designer.PrintRow(car.Id.ToString(), brandManager.GetById(car.BrandId).Name,
                    colorManager.GetById(car.ColorId).Name, car.ModelYear.ToString(), car.DailyPrice.ToString(),
                    car.Description);
            }

            Designer.Baslik("Yeni Araba Ekleme");
            carManager.Add(new Car
            {
                BrandId = 1,
                ColorId = 1,
                Name = "Renault Megan",
                PlakaNo = "34AS245",
                DailyPrice = 150,
                Description = "3 teker",
                ModelYear = new DateTime(2019, 02, 12)
            });

            //Console.WriteLine($"-------------Araba Güncelleme--------------------");
            //carManager.Update(new Car
            //{
            //    Id = 9,
            //    BrandId = 1,
            //    ColorId = 1,
            //    PlakaNo = "52PUK451",
            //    DailyPrice = 150,
            //    Description = "Hibrit",
            //    ModelYear = new DateTime(2019, 02, 12)
            //});

            //Console.WriteLine($"-------------Arabayı Sistemden Silme--------------------");
            //carManager.Delete(new Car
            //{
            //    Id = 2
            //});

            //Console.WriteLine("-------------MarkayaId'ye Göre Liste---------------------");
            //foreach (var car in carManager.GetCarsByBrandId(1))
            //{
            //    Console.WriteLine($"Id:{car.Id} " +
            //                      $"PlakaNo:{car.PlakaNo} " +
            //                      $"DailyPrice:{car.DailyPrice} " +
            //                      $"Description:{car.Description} " +
            //                      $"ModelYear:{car.ModelYear.Year}");
            //}


            //Console.WriteLine("-------------ColorId'ye Göre Liste---------------------");
            //foreach (var car in carManager.GetCarsByColorId(1))
            //{
            //    Console.WriteLine($"Id:{car.Id} " +
            //                      $"PlakaNo:{car.PlakaNo} " +
            //                      $"DailyPrice:{car.DailyPrice} " +
            //                      $"Description:{car.Description} " +
            //                      $"ModelYear:{car.ModelYear.Year}");
            //}

            //Console.WriteLine("-------------(100TL-200TL)Fiyat aralığına Göre Liste---------------------");
            //foreach (var car in carManager.GetByDailyPrice(100,400))
            //{
            //    Console.WriteLine($"Id:{car.Id} " +
            //                      $"PlakaNo:{car.PlakaNo} " +
            //                      $"DailyPrice:{car.DailyPrice} " +
            //                      $"Description:{car.Description} " +
            //                      $"ModelYear:{car.ModelYear.Year}");
            //}


            //Console.WriteLine("-------------2020 Model Arabaları Liste---------------------");
            //foreach (var car in carManager.GetByModelYear(2020))
            //{
            //    Console.WriteLine($"Id:{car.Id} " +
            //                      $"PlakaNo:{car.PlakaNo} " +
            //                      $"DailyPrice:{car.DailyPrice} " +
            //                      $"Description:{car.Description} " +
            //                      $"ModelYear:{car.ModelYear.Year}");
            //}

            //Console.WriteLine("-------------Detay Tüm Liste---------------------");
            //foreach (var car in carManager.GetCarDetails())
            //{
            //    Console.WriteLine($"Id:{car.Id} " +
            //                      $"Plaka No:{car.PlakaNo} " +
            //                      $"Brand:{car.BrandName} " +
            //                      $"Color Name:{car.ColorName} " +
            //                      $"Daily Price:{car.DailyPrice}");
            //}
        }
    }
}
