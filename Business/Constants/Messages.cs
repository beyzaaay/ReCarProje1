using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi.";
        public static string CarDeleted = "Araba silindi.";
        public static string CarUpdated = "Araba güncellendi.";
        public static string CarNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime="Sistem bakımda";
        public static string CarsListed="Ürünler listelendi";

        public static string BrandAdded = "Marka başarıyla veritabanına eklendi.";
        public static string BrandUpdate = "Marka başarıyla güncellendi.";
        public static string BrandsListed = "Markalar Listeleniyor.";
        public static string BrandDeleted = "Marka başarıyla veritabanından silindi.";

        public static string ColorAdded = "Renk Eklendi.";
        public static string ColorUpdate = "Renk Güncellendi";
        public static string ColorListed = "Renkler Listeleniyor.";
        public static string ColorDeleted = "Renk Silindi.";

        public static string UserAdded = "Kullanıcı Eklendi.";
        public static string FirstNameLastNameInvalid = "Ürün ismi geçersiz.";
        public static string UserDeleted = "Kullanıcı Silindi.";
        public static string UserNotDeleted = "Kullanıcı Silinemedi.";
        public static string UserUpdated = "Kullanıcı Güncellendi.";
        public static string UsersListed = "Kullanıcılar Listeleniyor.";

        public static string CustomerAdded = "Müşteri Eklendi.";
        public static string CustomerNotAdded = "Müşteri Eklenemedi.";
        public static string CustomerDeleted = "Müşteri Silindi.";
        public static string CustomerNotDeleted = "Müşteri Silinemedi.";
        public static string CustomerUpdated = "Müşteri Güncellendi.";
        public static string CustomersListed = "Müşteriler Listeleniyor.";

        public static string RentalAdded = "Kiralama Bilgisi Eklendi.";
        public static string RentalAddedError = "Araç teslim edilmediği için tekrar kiraya verilemez.";
        public static string RentalUpdateReturnDate = "Araç Teslim Alındı";
        public static string RentalUpdateReturnDateError = "Araç Teslim Alınmış.";
        public static string RentalUpdated = "Kiralama Bilgisi Güncellendi.";
        public static string RentalListed = "Kiralama Bilgileri Listeleniyor.";
        public static string RentalDeleted = "Kiralama Bilgisi Silindi.";
    }
}
