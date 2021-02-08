using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            
            Console.WriteLine("-------------Tüm Liste---------------------");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Id:{0,-3:D} PlakaNo:{1} DailyPrice:{0,-4:D} Description:{3} ModelYear:{4}",
                    car.Id, car.PlakaNo, car.DailyPrice, car.Description, car.ModelYear.Year);
            }


            Car car1 = carManager.GetById(7);
            Console.WriteLine($"-------------{car1.Id}-Nolu Araba Bilgileri--------------------");
            Console.WriteLine($"Id:{car1.Id} " +
                              $"PlakaNo:{car1.PlakaNo} " +
                              $"DailyPrice:{car1.DailyPrice} " +
                              $"Description:{car1.Description} " +
                              $"ModelYear:{car1.ModelYear.Year}");

            Console.WriteLine($"-------------Sisteme Araba Ekleme--------------------");
            carManager.Add(new Car
            {
                BrandId = 1,
                ColorId = 1,
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

            Console.WriteLine("-------------MarkayaId'ye Göre Liste---------------------");
            foreach (var car in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine($"Id:{car.Id} " +
                                  $"PlakaNo:{car.PlakaNo} " +
                                  $"DailyPrice:{car.DailyPrice} " +
                                  $"Description:{car.Description} " +
                                  $"ModelYear:{car.ModelYear.Year}");
            }



            Console.WriteLine("-------------ColorId'ye Göre Liste---------------------");
            foreach (var car in carManager.GetCarsByColorId(1))
            {
                Console.WriteLine($"Id:{car.Id} " +
                                  $"PlakaNo:{car.PlakaNo} " +
                                  $"DailyPrice:{car.DailyPrice} " +
                                  $"Description:{car.Description} " +
                                  $"ModelYear:{car.ModelYear.Year}");
            }

            Console.WriteLine("-------------(100TL-200TL)Fiyat aralığına Göre Liste---------------------");
            foreach (var car in carManager.GetByDailyPrice(100,400))
            {
                Console.WriteLine($"Id:{car.Id} " +
                                  $"PlakaNo:{car.PlakaNo} " +
                                  $"DailyPrice:{car.DailyPrice} " +
                                  $"Description:{car.Description} " +
                                  $"ModelYear:{car.ModelYear.Year}");
            }


            Console.WriteLine("-------------2020 Model Arabaları Liste---------------------");
            foreach (var car in carManager.GetByModelYear(2020))
            {
                Console.WriteLine($"Id:{car.Id} " +
                                  $"PlakaNo:{car.PlakaNo} " +
                                  $"DailyPrice:{car.DailyPrice} " +
                                  $"Description:{car.Description} " +
                                  $"ModelYear:{car.ModelYear.Year}");
            }

            Console.WriteLine("-------------Detay Tüm Liste---------------------");
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine($"Id:{car.Id} " +
                                  $"Plaka No:{car.PlakaNo} " +
                                  $"Brand:{car.BrandName} " +
                                  $"Color Name:{car.ColorName} " +
                                  $"Daily Price:{car.DailyPrice}");
            }
        }
    }
}
