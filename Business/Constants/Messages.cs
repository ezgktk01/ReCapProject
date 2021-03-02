using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string AddedCar = "Araba eklendi";
        public static string DeletedCar = "Araba silindi";
        public static string UpdatedCar = "Araba güncellendi";
        public static string FailedCar = "Lütfen günlük fiyat kısmını 0'dan büyük giriniz.";

        public static string AddedBrand = "Model eklendi";
        public static string DeletedBrand = "Model silindi";
        public static string UpdatedBrand = "Model güncellendi";
        public static string FailedBrand = "Lütfen marka isminin uzunluğunu 2 karakterden fazla giriniz.";

        public static string AddedColor = "Renk eklendi";
        public static string DeletedColor = "Renk silindi";
        public static string UpdatedColor = "Renk güncellendi";

        public static string AddedCustomer = "Müşteri eklendi.";
        public static string DeletedCustomer = "Müşteri silindi.";
        public static string UpdatedCustomer = "Müşteri güncellendi.";

        public static string AddedUser = "Kullanıcı eklendi";
        public static string DeletedUser = "Kullanıcı silindi";
        public static string UpdatedUser = "Kullanıcı güncellendi";

        public static string AddedRental = "Araba kiralama işlemi gerçekleşti";
        public static string DeletedRental = "Araba kiralama işlemi iptal edildi.";
        public static string UpdatedRental = "Araba kiralama işlemi güncellendi";
        public static string FailedRental = "Bu araba henüz teslim edilmediği için kiralayamazsınız";
        public static string ReturnedRental = "Kiraladığınız araç teslim edildi";

        public static string AddedCarImage = "Araba için yüklenilen resim başarıyla eklendi.";
        public static string DeletedCarImage = "Arabanın resmi başarıyla silindi.";
        public static string UpdatedCarImage = "Araba için yüklenilen resim başarıyla güncellendi.";
        public static string FailedCarImageAdd = "Bir araba 5'den fazla resme sahip olamaz.";
        public static string AuthorizationDenied = "Yetkiniz yok.";
    }
}
