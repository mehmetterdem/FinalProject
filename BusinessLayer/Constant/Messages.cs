using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Constant
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi gecersiz";
        public static string MaintenanceTime = "Sistem bakım zamanı";
        public static string ProductListed = "Ürünler listelendi";
        public static string ProductCountOfCategory="Bir kategoride en fazla 10 ürün bulunabilir";
        public static string ProductNameAlreadyExists="Ürün ismi mevcut ";
        public static string CategoryLimiteExceded="Kategori limiti aşıldığı için yeni kategori eklenemiyor";
        public static string AuthorizationDenied="Yetkiniz Yok";
        public static string UserRegistered="kullanıcı kaydedildi";
        public static string UserNotFound ="kullanıcı bulunamadı";
        public static string PasswordError ="şifre hatalı";
        public static string UserAlreadyExists="kullanıcı zaten var";
        public static string SuccessfulLogin="giriş basarılı";
        public static string AccessTokenCreated="token olusturuldu";
    }
}
