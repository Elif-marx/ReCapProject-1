using System.Runtime.Serialization;
using Core.Entities.Concrete;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Business.Constants
{
    public class Messages
    {
        public static string CarRecorded = "Car recorded.";
        public static string CarDescInvalid = "Car Descriptions Invalid !!";
        public static string CarDeleted = "Car deleted.";
        public static string MaintenanceTime = "System Maintenance Time";
        public static string CarListed = "Car Listed.";
        public static string GetAll = "GetAll";
        public static string CarUpdated = "Car Updated";
        public static string BrandRecorded = "Brand Record";
        public static string BrandNameInvalid = "Brand Name Invalid!!";
        public static string BrandDeleted="Brand Deleted";
        public static string BrandUpdated="Brand Updated";
        public static string BrandListed="Brand Listed";
        public static string ColorNameInvalid = "Color Name Invalid!!";
        public static string ColorRecorded="Color Recorded";
        public static string ColorDeleted="Color Deleted";
        public static string ColorListed="Color Listed";
        public static string ColorUpdated="Color Updated";
        public static object CustomerAdded="Customer Added";
        public static string CustomerRecorded="Customer Recorded";
        public static string CustomerNameInvalid="Customer Name Invalid";
        public static string CustomerDeleted="Customer Deleted";
        public static string CustomerUpdated="Customer Updated";
        public static string CustomerGetAll="Customer GetAll";
        public static string RentalDateNull="Rental Date Null";
        public static string RentalRecorded="Rental Recorded";
        public static string RentalDeleted="Rental Deleted";
        public static string RentalUpdated="Rental Updated";
        public static string RentalGetAll="Rental GetAll";
        public static string UserFirstNameInvalid="User FirstName Invalid";
        public static string UserRecorded="User Recorded";
        public static string UserDeleted="User Deleted";
        public static string UserUpdated="User Updated";
        public static string UserGetAll="User GetAll";
        public static string UserListed="User Listed";
        public static string FailedRentalAddOrUpdate= "Failed Rental Add Or Update";
        public static string AddedRental= "Added Rental";
        public static string CarImagesUpdated= "Car Images Updated";
        public static string CarImagesAdded= "Car Images Added";
        public static string CarImagesDelete= "Car Images Delete";
        public static string ImageLimitPerCar= "ImageLimitPerCar";
        public static string CarImagesServicesAdded= "CarImagesServicesAdded";
        public static string CarImagesServicesUpdated= "CarImagesServicesAdded";
        public static string CarImagesServicesDeleted= "CarImagesServicesDeleted";
        public static string FailAddedImageLimit= "FailAddedImageLimit";
        public static string CarImageAdded= "Car Image Added";
        public static string UserRegistered= "User Registered";
        public static string UserNotFound = "User Not Found";
        public static string PasswordError = "Password Error";
        public static string SuccessfulLogin = "Successful Login";
        public static string UserAlreadyExists = "User Already Exists";
        public static string AccessTokenCreated = "Access Token Created";
        public static string AuthorizationDenied= "Authorization Denied";
        public static ModelStateDictionary NullImagePath;
    }
}
