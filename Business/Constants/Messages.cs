using Entities.Concrete;
using System;
using System.Collections.Generic;
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
    }
}
