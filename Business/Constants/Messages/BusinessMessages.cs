using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants.Messages
{
    public static class BusinessMessages
    {
        public static string SameAccountSocialMediaLinkError = "Eklemeye çalıştığınız link mevcuttur!";
        public static string SameUniversityNameError = "Eklemeye çalıştığınız üniversite mevcuttur!";
        public static string SameProgramNameError = "Eklemeye çalıştığınız bölüm mevcuttur!";
        public static string OrganizationRuleError = "Hata!";
        public static string SameSocialMediaNameError = "Eklemeye çalıştığınız sosyal medya platformu mevcuttur!";
        public static string ExperienceRuleError = "Aynı!";
        public static string SameCountryNameError = "Eklemeye çalıştığınız ülke ismi mevcut!";
        public static string SameCityNameError = "Aynı ülkede aynı şehirler olamaz!";
        public static string ExperienceCannotBeEmpty = "Bu alan veya alanlar boş bırakılamaz!";
        public static string AccountApplicationCannotBeEmpty = "Bu alan veya alanlar boş bırakılamaz!";
        public static string AccountEducationCannotBeEmpty = "Bu alan veya alanlar boş bırakılamaz!";
        public static string FileFormatControl = "Sadece image/jpeg, image/png, application/pdf yükleyebilirsiniz";
        public static string NotNullableFileName = "Dosya adı boş olamaz";
        public static string TooLongFileName = "Dosya adı çok uzun";
        public static string NotValidCharactersInFileName = "Dosya adında [<>:\"/\\\\|?*] karakterler bulunamaz";
        public static string RequiredAccountForCertificate = "Geçerli bir kullanıcı için dosya yükleyiniz";
        public static string RequiredAccountForCourse = "Geçerli bir kullanıcı için kayıt yapınız";
        public static string RequiredCourse = "Geçerli bir eğitim için kayıt yapınız";
        public static string NotNullableContentTypeName = "İçerik tipi boş olamaz";
        public static string NotNullableCategoryName = "Kategori boş olamaz";
        public static string NotNullableContentName = "İçerik adı boş olamaz";
        public static string RequiredContentType = "Geçerli bir içerik tipi için kayıt yapınız";
        public static string RequiredContent = "Geçerli bir içerik adı için kayıt yapınız";
        public static string NotNullableLessonName = "Ders adı boş olamaz";
        public static string RequiredLesson = "Geçerli bir ders için kayıt yapınız";
        public static string RequiredLessonStatus = "Geçerli bir ders statüsü bulunamadı";
        public static string NotNullableCourseName = "Kurs adı boş olamaz";
        public static string NotNullableImagePath = "Fotoğraf yüklenmelidir";
        public static string RequiredCourseCategory = "Geçerli bir kategori için kayıt yapınız";
        public static string RequiredOrganization = "Geçerli bir kurum için kayıt yapınız";
        public static string NotNullableLanguage = "Dil adı boş olamaz"; //burayı güncelle; lang id kullanılmalı 
        public static string NotNullableSubType = "Alt tip boş olamaz";
        public static string NotNullableOrganizationName = "Kurum boş olamaz";
        public static string NotNullableContactNumber = "İletişim numarası boş olamaz";
        public static string RequiredAddress = "Geçerli bir adres için kayıt yapınız";
        public static string NationalIdValue = "TC 11 haneli olmalıdır!";
        public static string RequiredField = "Doldurulması zorunlu alan!";
        public static string MinLengthError2 = "En az 2 karakter girmelisiniz!";
        public static string MaxLengthError50 = "En fazla 50 karakter girebilirsiniz!";
        public static string MaxLengthError100 = "En fazla 100 karakter girebilirsiniz!";
        public static string MinLengthError5 = "En az 5 karakter girmelisiniz!";
        public static string MaxLengthError300 = "En fazla 300 karakter girebilirsiniz!";
        public static string MaxLengthError30 = "En fazla 30 karakter girebilirsiniz!";
        public static string StartYearError = "Geçerli bir başlangıç yılı olmalıdır.";
        public static string GraduationYearError = "Geçerli bir mezuniyet yılı olmalıdır.";
        public static string InvalidUrlError = "Geçerli bir URL formatında olmalıdır.";
        public static string DateFormatError = "Tarih, 'dd.MM.yyyy' formatında olmalıdır.";
        public static string DateComparison = "Mezuniyet yılı, başlangıç yılından küçük olamaz.";
        public static string SameSkillNameError = "Aynı beceri eklenemez.";
        public static string SameCountryCodeError = "Aynı ülke kodu.";
        public static string AccessDenied = "Yetki Reddedildi";

        /* Course Messages*/
        public static string SameCourseNameError = "Aynı isimli Kurs Adı bulunmaktadır.";
        public static string SameLessonNameError = "Aynı isimli Ders Adı bulunmaktadır.";
        public static string SameLessonStatusNameError = "Aynı isimli Ders Statü Adı bulunmaktadır.";
        public static string NotNullableLessonStatusName = "Ders Statü Adı boş olamaz";
        public static string SameContentNameError = "Aynı isimli İçerik Adı bulunmaktadır.";
        public static string SameContentTypeNameError = "Aynı isimli İçerik Tipi Adı bulunmaktadır.";
        public static string SameCoursePageNameError = "Kurs Sayfasında aynı isimli kurs adı bulunmaktadır.";
        public static string SameCategoryNameError = "Aynı isimli Kurs Kategori Adı bulunmaktadır.";
        public static string? SameSessionRecordNameError = "Aynı isimli Oturum Kayıt Adı bulunmaktadır.";

        /*User Messages*/
        public static string RegistrationSuccessfully = "Kayıt işlemi başarıyla gerçekleşti.";
        public static string UserOrEmailNotFound = "Kayıtlı Kullanıcı Adı veya Email Bulunamadı.";
        public static string PasswordError = "Parola Hatası.";
        public static string SuccessfullEntry = "Başarılı Giriş yapıldı.";
        public static string UserIsValid = "Bu Kullanıcı Mevcuttur";
        public static string TokenCreated = "Token Oluşturuldu";
        public static string PasswordResetLinkHasBeenSentToYourEmailAddress = "Şifre sıfırlama linki mail adresinize gönderilmiştir.";
        public static string ThisEmailAddressIsNotRegisteredInTheSystem = "Sistemde bu mail adresi kayıtlı degildir.";

        /*Survey Messages*/
        public static string SameSurveyLinkError = "Bu Anket Linki sistemde bulunmaktadır.";

        public static string SameOrganizationNameError = "Aynı isimli Organizasyon Adı bulunmaktadır.";
    }
}