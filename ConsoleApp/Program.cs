using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    /// <summary>
    /// DevRentACar Test
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {


            #region Business Instances And Tables Design
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            UserManager userManager = new UserManager(new EfUserDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            Designer.ShowWindow(Designer.ThisConsole, 3);
            Console.Clear();
            #endregion

            #region CarTest
            //CarTest(carManager, brandManager, colorManager);
            #endregion

            #region BrandTest
            //BrandTest(brandManager);
            #endregion

            #region ColorTest
            //ColorTest(colorManager);
            #endregion

            #region UserTest
            //UserAddTest(userManager);
            //UserGetAllTest(userManager);
            #endregion

            #region CustomerTest
            //CustomerAddTest(customerManager);
            //CustomerGetAllTest(customerManager, userManager);
            #endregion

            #region RentalTest
            RentalAddTest(rentalManager);
            RentalGetAllTest(rentalManager);
            #endregion




            Console.ReadKey();
        }

        #region ColorTest Methods
        //private static void ColorTest(ColorManager colorManager)
        //{
        //    Designer.Baslik("Color All Lists");
        //    Designer.PrintRow("Brand ID", "Brand Name");

        //    foreach (var color in colorManager.GetAll().Data)
        //    {
        //        Designer.PrintRow(color.Id.ToString(), color.Name);

        //    }

        //    //var result2 = colorManager.Add(new Color
        //    //{
        //    //    Name = "Blue"
        //    //});
        //}
        #endregion

        #region BrandTest Methods

        //private static void BrandTest(BrandManager brandManager)
        //{
        //    Designer.Baslik("Brand All Lists");
        //    Designer.PrintRow("Brand ID", "Brand Name");

        //    foreach (var brand in brandManager.GetAll().Data)
        //    {
        //        Designer.PrintRow(brand.Id.ToString(), brand.Name);
        //    }

        //    Designer.Baslik("New Brand Add");
        //    brandManager.Add(new Brand
        //    {
        //        Name = "Kia"
        //    });

        //}

        #endregion

        #region UserTest Methods
        //private static void UserGetAllTest(UserManager userManager)
        //{
        //    Designer.Baslik("User All Lists");
        //    Designer.PrintRow("User ID", "FirstName", "User LastName", "Email", "Password");

        //    foreach (var user in userManager.GetAll().Data)
        //    {
        //        Designer.PrintRow(user.Id.ToString(),
        //            user.FirstName,
        //            user.LastName,
        //            user.Email,
        //            user.Password);
        //    }

        //}

        //private static void UserAddTest(UserManager userManager)
        //{
        //    Designer.Baslik("New User Add");
        //    var userAdded = userManager.Add(new User
        //    {
        //        FirstName = "Ahmet Arif",
        //        LastName = "Keskin",
        //        Email = "aarifkeskin@gmail.com",
        //        Password = "12345"
        //    });
        //    Designer.Baslik(userAdded.Message.ToString());

        //}

        #endregion

        #region CarTest Methods

        //private static void CarTest(CarManager carManager, BrandManager brandManager, ColorManager colorManager)
        //{
        //    Designer.Baslik("Tümünü Liste");
        //    Designer.PrintRow("Car ID", "Brand Name", "Color Name", "Model Year", "Daily Price", "Description");

        //    foreach (var car in carManager.GetAll())
        //    {
        //        Designer.PrintRow(car.Id.ToString(), brandManager.GetById(car.BrandId).Name,
        //            colorManager.GetById(car.ColorId).Name, car.ModelYear.ToString(), car.DailyPrice.ToString(),
        //            car.Description);
        //    }

        //Designer.Baslik("Yeni Araba Ekleme");
        //carManager.Add(new Car
        //{
        //    BrandId = 1,
        //    ColorId = 1,
        //    Name = "Renault Megan",
        //    PlakaNo = "34AS245",
        //    DailyPrice = 150,
        //    Description = "3 teker",
        //    ModelYear = new DateTime(2019, 02, 12)
        //});

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
        #endregion

        #region CustomerTest Methods
        //private static void CustomerGetAllTest(CustomerManager customerManager, UserManager userManager)
        //{
        //    Designer.Baslik("Customer All Lists");
        //    Designer.PrintRow("ID", "User FullName", "Company Name");

        //    foreach (var customer in customerManager.GetAll().Data)
        //    {
        //        Designer.PrintRow(customer.Id.ToString(),
        //            GetCustomerFullNameById(customer.UserId, userManager),
        //            customer.CompanyName);
        //    }
        //}

        private static string GetCustomerFullNameById(int userId, UserManager userManager)
        {
            var user = userManager.GetById(userId).Data;
            return $"{user.FirstName} {user.LastName}";
        }

        private static int GetUserIdById(int customerId, CustomerManager customerManager)
        {
            var customer = customerManager.GetById(customerId).Data;
            return customer.UserId;
        }

        //private static void CustomerAddTest(CustomerManager customerManager)
        //{
        //    Designer.Baslik("New Customer Add");
        //    var customerAdded = customerManager.Add(new Customer
        //    {
        //        UserId = 3,
        //        CompanyName = "Dardanell"
        //    });
        //    Designer.Baslik(customerAdded.Message.ToString());

        //}
        #endregion

        #region RentalTest Methots
        private static void RentalGetAllTest(RentalManager rentalManager)
        {
            Designer.Baslik("Rental All Lists");
            Designer.PrintRow("ID", "Car Name", "User First Name", "User Last Name", "Company Name", "Email", "Car Plaka No", "Rent Date", "Return Date");

            foreach (var rental in rentalManager.RentalDetails().Data)
            {
                Designer.PrintRow(rental.Id.ToString(),
                    rental.CarName,
                    rental.UserFirstName,
                    rental.UserLastName,
                    rental.CompanyName,
                    rental.Email,
                    rental.CarPlakaNo,
                    rental.RentDate.ToString(),
                    rental.ReturnDate.ToString());
            }
        }


        private static void RentalAddTest(RentalManager rentalManager)
        {
            Designer.Baslik("New Rental Add");
            var rentalAdded = rentalManager.Add(new Rental()
            {
                CustomerId = 2,
                CarId = 15,
                RentDate = new DateTime(2021, 02, 13),
                ReturnDate = new DateTime(2021, 02, 15),
            });
            Designer.Baslik(rentalAdded.Message.ToString());

        }
        #endregion


    }
}
