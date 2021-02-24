using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi gecersiz";
        public static string MaintenanceTime="Sistem bakımda";
        public static string ProductsListed="Ürünler Listelendi";

        public static string ProductCountOfCategoryError = "Ekleme yapılamaz en fazla 10 urun";
        public static string ProductNameAlreadyExists = "Bu isimde baska urun var";
        public static string CategoryLimitExceded="Kategory limiti asıldıgı icin yeni urun eklenemiyor";
    }
}
