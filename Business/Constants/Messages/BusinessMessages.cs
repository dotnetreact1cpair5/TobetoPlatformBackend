using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants.Messages
{
    public class BusinessMessages
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
        public static string NotNullableLessonStatusName = "Statü boş olamaz";
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
        public static string MinLengthError5 = "En az 5 karakter girmelisiniz!";
        public static string MaxLengthError300 = "En fazla 300 karakter girebilirsiniz!";
        public static string MaxLengthError30 = "En fazla 30 karakter girebilirsiniz!";
        public static string StartYearError = "Geçerli bir başlangıç yılı olmalıdır.";
        public static string GraduationYearError = "Geçerli bir mezuniyet yılı olmalıdır.";
        public static string InvalidUrlError = "Geçerli bir URL formatında olmalıdır.";
        public static string DateFormatError = "Tarih, 'dd.MM.yyyy' formatında olmalıdır.";
        public static string DateComparison = "Mezuniyet yılı, başlangıç yılından küçük olamaz.";
        public static string SameSkillNameError = "Aynı beceri eklenemez.";
        public static string SameCountryCodeError="Aynı ülke kodu.";
    }
}
