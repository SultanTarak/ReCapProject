using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string Added = "Ekleme başarılı";
        public static string NameInvalid = "Eksik veya hatalı bilgi";

        public static string Updated = "Güncelleme başarılı";
        public static string UpdatedInvalid = "Güncelleme başarısız";
        
        public static string Deleted = "Silme başarılı";
        public static string DeletedInvalid = "Silme başarısız";
        
        public static string Listed = "Ürünler listelendi.";
        
        public static string DailyPriceInvalid = "Birim fiyatı 0'dan büyük olmalıdır.";
        
        public static string CarCountOfBrandError = "Bir markada en fazla 10 araç olabilir";
        
        public static string CarNameAlreadyExists = "Aynı isimde başka bir araç mevcuttur";
        
        public static string BrandLimitExceded= "Marka limiti aşıldığı için yeni araç eklenemiyor";

        public static string CarRental = "Araç kiralandı";
        
        public static string CarImageLimitExceded = "Resim limiti aşıldığı için yeni resim eklenemiyor";
        public static string CarImageNull = "Araç görüntüsü eklenmelidir";

        public static string AuthorizationDenied= "Yetkiniz yok.";

        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
    }
}
