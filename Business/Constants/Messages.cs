using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Mehsul elave edildi.";
        public static string ProductNameInvalid = "Mehsul adi ugursuz.";
        public static string MaintenanceTime="Application Bakimdadir.";
        public static string ProductListed="Mehsul siralandi";
        public static string ProductDeleted="Mehsul silindi";
        public static string ProductUpdated="Mehsul yenilendi";
        public static string ProductCountOfCategoryError="Eyni mehsuldan 15-den artiq ola bilmez";
        public static string ProductNameAlreadyExists="Eyni mehsul adi artiq var";
        public static string? AuthorizationDenied="Icazeniz yoxdur";
        internal static string UserAlreadyExists;
        internal static string AccessTokenCreated;
        internal static string SuccessfulLogin;
        internal static User PasswordError;
        internal static User UserNotFound;
        internal static string UserRegistered;
    }
}
