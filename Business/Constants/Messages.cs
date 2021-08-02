using Core.Entities.Concrete;
using System.Runtime.Serialization;

namespace Business.Constants
{
    /// <summary>
    /// DevRentACar Project Constant Messages
    /// </summary>
    public static class Messages
    {
        #region General Messages 
        public static string MaintenanceTime = "The system is under maintenance";
        #endregion

        #region Car Messages 
        public static string CarAdded        = "The car was added";
        public static string CarsListed      = "Cars were listed";
        public static string CarUpdated      = "The car was updated ";
        public static string CarDeleted      = "The car was deleted";
        public static string CarListed       = "The Car was listed";
        public static string CarNameInvalid  = "The car name was entered incorrectly";
        public static string CarNameAlreadyExists = "Car Name Already Exists";
        #endregion

        #region Brand Messages 
        public static string BrandListed     = "The brand was listed";
        public static string BrandsListed    = "Brands were listed";
        public static string BrandAdded      = "The brand was added";
        public static string BrandUpdated    = "The brand was updated";
        public static string BrandDeleted    = "The brand was deleted";
        #endregion

        #region Color Messages 
        public static string ColorListed     = "The color was listed";
        public static string ColorsListed    = "Colors were listed";
        public static string ColorAdded      = "The color was added";
        public static string ColorUpdated    = "The color was updated";
        public static string ColorDeleted    = "The color was deleted";

        #endregion

        #region User Messages 
        public static string UsersListed = "The user was listed";
        public static string UserListed = "Users were listed";
        public static string UserAdded = "The user was added";
        public static string UserUpdated = "The user was updated";
        public static string UserDeleted = "The user was deleted";
        #endregion

        #region Customer Messages 
        public static string CustomersListed = "The customer was listed";
        public static string CustomerListed = "Customers were listed";
        public static string CustomerAdded = "The customer was added";
        public static string CustomerUpdated = "The customer was updated";
        public static string CustomerDeleted = "The customer was deleted";
        #endregion

        #region Rental Messages 
        public static string RentalsListed = "The rental was listed";
        public static string RentalListed = "Rentals were listed";
        public static string RentalAdded = "The rental was added";
        public static string RentalUpdated = "The rental was updated";
        public static string RentalDeleted = "The rental was deleted";
        public static string RentalIsInvalid = "Car cannot be rented";

        #endregion

        #region CarImage Messages 

        public static string CarImagesListed = "The Car Images were listed";
        public static string CarImageListed = "The Car Image was listed";
        public static string CarImageAdded = "The Car Image was added";
        public static string CarImageDeleted = "The Car Image was deleted";
        public static string CarImageLimitExceeded = "More than 5 images cannot be added";
        public static string NoCarImages = "The car does NOT have any images";

        #endregion

        #region Other

        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered = "Kayıt Oldu.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Password hatası.";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserAlreadyExists = "Kullanıcı zaten mevcut";
        public static string AccessTokenCreated = "Kullanıcı girişi başarılı oldu.";
        public static string CreditCardAdded = "Kredi kartı eklendi.";
        public static string CreditCarDeleted = "Kredi kartı silindi.";
        public static string CreditCardUpdated = "Kredi kartı güncellendi.";
        public static string CarImageNotFound;
        public static string CarImageUpdated;
        public static string OverflowCarImageMessage;

        #endregion
    }
}
