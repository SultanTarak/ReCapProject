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
    }
}
