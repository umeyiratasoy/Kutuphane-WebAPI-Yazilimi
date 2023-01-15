using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {

       
        //Erişim İzni
        public static string AuthorizationDenied = "Yetkiniz Yok.";
        //Auth and Users
        public static string KullanıcıEklendi = "Kullanıcı Eklenmiştir.";
        public static string KullanıcıGüncellendi = "Kullanıcı Güncellenmiştir.";
        public static string KullanıcıSilindi = "Kullanıcı Silinmiştir.";
        public static string AccessTokenCreated = "Access Token Generated";
        public static string UserNotFound = "User Not Found";
        public static string PasswordError = "Şifre Hatalı";
        public static string SuccessfulLogin = "Giriş Başarılı";
        public static string UserRegistered = "Kullanıcı Kayıtlı";
        public static string MailAlreadyExists = "Kullanıcı zaten var";

        //Öğrenci
        public static string OgrenciEklendi = "Öğrenci Eklenmiştir.";
        public static string OgrenciGüncellendi = "Öğrenci Güncellenmiştir.";
        public static string OgrenciSilindi = "Öğrenci Silinmiştir.";
        public static string OgrenciListelendi = "Öğrenciler Listelendi.";
        public static string İstenilenOgrenciListelendi = "İstenilen Öğrenci Listelenmiştir.";

        //Tür
        public static string TurEklendi = "Yeni Tür Eklenmiştir.";
        public static string TurGuncellendi = "Tür Güncellenmiştir.";
        public static string TurSilindi = "Tür Silinmiştir.";
        public static string TurListelendi = "Türler Listelendi.";
        public static string İstenilenTurListelendi = "İstenilen Tür Listelendi.";

        //Kitap
        public static string KitapEklendi = "Kitap Eklenmiştir.";
        public static string KitapGüncellendi = "Kitap Güncellenmiştir.";
        public static string KitapSilindi = "Kitap Silinmiştir.";
        public static string KitapListelendi = "Kitaplar Listelendi";
        public static string İstenilenKitapListelendi = "İstenilen Kitap Listelendi.";

        //Yazar
        public static string YazarEklendi = "Yazar Eklenmiştir.";
        public static string YazarGüncellendi = "Yazar Güncellendi.";
        public static string YazarSilindi = "Yazar Silinmiştir.";
        public static string YazarListelendi = "Yazarlar Listelenmiştir.";
        public static string İstenilenYazarListelendi = "İstenilen Yazar Listelendi.";

        //Emanet
        public static string EmanetEklendi = "Emanet Eklenmiştir.";
        public static string EmanetGüncellendi = "Emanet Güncellendi.";
        public static string EmanetSilindi = "Emanet Silinmiştir.";
        public static string EmanetListelendi = "Emanetler Listelenmiştir.";
        public static string İstenilenEmanetListelendi = "İstenilen Emanet Listelendi.";

    }
}
