using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {

        //Car
        public static string CarAdded = "Car Added.";
        public static string CarRemoved = "Car Removed.";
        public static string CarUpdated = "Car Updated.";
        public static string CarListed = "Car Listed.";
        public static string CarNameAlreadyExists = "Car Name Already Exists";
        public static string UpdateSuccessful = "Update Successful";

        //Brand
        public static string BrandAdded = "Brand Added";
        public static string BrandRemoved = "Brand Removed";
        public static string BrandUpdated = "Brand Updated";
        public static string BrandListed = "Brand Listed";

        //Color
        public static string ColorAdded = "Color Added";
        public static string ColorRemoved = "Color Removed";
        public static string ColorUpdated = "Color Updated";
        public static string ColorListed = "Color Listed";

        //Customer
        public static string CustomerAdded = "Customer Added";
        public static string CustomerRemoved = "Customer Removed";
        public static string CustomerUpdated = "Customer Updated";
        public static string CustomerListed = "Customer Listed";
        public static string CustomerInvalid = "Customer Invalid";

        //Rental
        public static string RentalAdded = "Rental Added";
        public static string RentalRemoved = "Rental Removed";
        public static string RentalUpdated = "Rental Updated";
        public static string RentalListed = "Rental Listed";
        public static string RentalInvalid = "Rental Invalid";

        //User
        public static string UserNameInvalid = "User Name Invalid.";
        public static string UserAdded = "User Added.";
        public static string UserDeleted = "User Removed.";
        public static string UserUpdated = "User Updated.";
        public static string UserListed = "User Listed.";

        //CarImage
        public static string CarImageUpdated = "Car Image Updated";
        public static string CarImageDeleteError = "Car Image Deleted Error";
        public static string CarImageDeleteSuccess = "Car Image Deleted Success";
        public static string CarImageAdded = "Car Image Added";

        //Erişim İzni
        public static string AuthorizationDenied = "You are not authorized.";
        //Auth
        public static string AccessTokenCreated = "Access Token Generated";
        public static string UserNotFound = "User Not Found";
        public static string PasswordError = "Password Error";
        public static string SuccessfulLogin = "Successful Login";
        public static string UserRegistered = "User Registered";
        public static string MailAlreadyExists = "User Already Exists";
        public static string ClaimsListed = "Claims Listed";

        public static string CarDetailsListed = "Araç Detayları Listelendi";
    }
}
