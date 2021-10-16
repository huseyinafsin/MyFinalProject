using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Bakım saati olduğundan ürünler "+DateTime.Now.Hour+ "'de listelenemez";
        public static string ProductListed = "Ürünler başarı ile listelendi";
        public static string ProductCountOfCategoryError = "Ürün eklerken her bir kategori içerisinde en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists = "Ürün zaten ekli";
        public static string CheckIfCategoryLimitExceded = "Mevcut kategori sayısı 15'i geçtiyse ürün eklenemez";
    }
}