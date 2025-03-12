# :gem:ASP.NET Core ile Admin ve Kullanıcı Panelli Portföy Sitesi
Bu repository, Murat Yücedağ'ın Udemy'de bulunan Asp.Net Core 5.0 ile Adım Adım Web Geliştirme kursunu içermektedir. Bu eğitimde bana yol gösteren Murat Yücedağ'a çok teşekkür ederim.

ASP.NET Core Web Application (.NET Core Framework) kullanarak dinamik bir Portföy sitesi oluşturdum. Bu projede N-Tier Architecture (N Katmanlı Mimari) ve MVC tabanlı bir yapı kullandım. SOLID prensiplerine ve dosya organizasyonuna uygun şekilde geliştirme yaparak kod tekrarını en aza indirmeye çalıştım. Entity Framework Core - Code First yaklaşımını kullanarak veritabanı bağlantılarını oluşturdum.

N-Tier Architecture (N Katmanlı Mimari), yazılım uygulamalarını birden fazla bağımsız katmana (layer) bölerek geliştirmeye olanak tanıyan bir yazılım mimari modelidir.
Bu mimari, uygulamanın farklı katmanlarını belirleyerek modülerlik, ölçeklenebilirlik ve bakım kolaylığı sağlar.

Genel anlamda 5 katman üzerinde projeyi oluşturdum. Presentation Layer (Sunum Katmanı), kullanıcının doğrudan etkileşimde bulunduğu katmandır. Burada HTML5, CSS3, Bootstrap ve JavaScript kullanarak web sayfaları oluşturdum. Business Logic Layer (İş Mantığı Katmanı), uygulamanın kurallarını ve iş mantığını barındırır. Service ve Manager olarak tüm entity'lerin metotlarını oluşturup kontrollerini yaptım. Data Access Layer (Veri Erişim Katmanı), veritabanı ile etkileşimi sağlar. Burada veri tabanındaki verileri gereken şekilde kullandım. Entity Layer (Varlık Katmanı), verileri saklayan katmandır. Burası Code-First yaklaşımının başlangıcıdır. Veri tabanındaki tablolar ve sütunlar yerine bu katmanda sınıflar ve property'ler kullandım. Son olarak da projeye en son örnek amaçlı eklediğim API katmanı. Bu katmanda uygulamanın diğer istemciler (web, mobil, masaüstü vb.) tarafından erişilebilecek şekilde veri sağlayan bir yapı olarak kullanılır. API Controller bu katmanda HTTP tabanlı istekleri (GET, POST, PUT, DELETE vb.) işleyerek veri alıp gönderen bileşenlerdir. Bu eğitim esnasında API katmanında Swagger ve Postman kullanarak API isteklerini deneme fırsatı buldum ve bu API konusunu daha iyi anlamama yardımcı oldu. Bunun dışında CRUD işlemleri sırasında örnek olarak Fluent Validation işlemlerini uyguladım ve bu sayede daha kontrollü ve profesyonel bir yapı elde ettim. Kullanıcı'ların yönetimini Identity ve Roller ile yaptım. ASP.NET Core Identity, kimlik doğrulama (authentication) ve yetkilendirme (authorization) işlemlerini yönetmek için kullanılan bir sistemdir. Kullanıcı giriş-çıkış işlemlerini, rollerle yetkilendirmeyi ve güvenli parola yönetimini kolaylaştırır. Yine aynı şekilde Entity Framework Core ile yaptığım CRUD işlemlerini AJAX ile de yaparak farklı işlemlerde deneyim kazandım. AJAX (Asynchronous JavaScript and XML), web sayfasını tam olarak yeniden yüklemeden asenkron olarak veri almak veya göndermek için kullanılan bir tekniktir. ASP.NET Core ile birlikte kullanılarak dinamik ve hızlı web uygulamaları geliştirilmesine yardımcı olur. Bu bir proejnin yanında bir eğitim olduğu için proejeyle entegre veya entegre olamayan yapılar içermektedir.

Bu projede değiştirilmesi gereken bazı noktalar olabilir fakat burada asıl amaç Back-end Development anlamında .Net Core ile admin ve kullanıcı panelli bir sistem kurmaktır. Front-end anlamında düzeltmeler yapılabilir.

Projede genel anlamda 3 farklı bölüm bulunmaktadır;

1- Admin Paneli: Adminler'in giriş yapıp hakkımda, yetenekler, deneyimler, hizmetler, mesajlar gibi alanlar ile ilgili CRUD (Create, Read, Update, Delete) işlemlerinin yaptığı bölümdür.  
2- Kullanıcı Paneli: Kullanıcıların sisteme girip mesajlaşma, hesap yönetimi gibi işlemlerini yaptığı bölümdür.  
3- Ana Sayfa: Burada da Melih Çolak ve bu proje ile ilgili bilgiler yer alıyor. Yine tüm kullanıcılar herhangi bir Login işlemi yapmdan bu sayfayı görüntüleyebilir.

## :arrow_forward: Ana Sayfa
Bu eğitimde ilk olarak ana sayfayı oluşturdum. Her kullanıcı bu sayfayı herhangi bir giriş işlemi yapmadan görüntüleyebilir. Bu sayfada benimle ilgili bilgiler bulunmaktadır. Genel anlamda bu sayfa Öne Çıkan, Hakkımda, Hizmetler, Yeteneklerim, Projelerim, Deneyimlerim, Referanslarım ve İletişim bölümlerinden oluşmaktadır.

### :triangular_flag_on_post: Öne Çıkan Bölümü
Öne Çıkan bölümünde ismim, pozisyonum ve sosyal medya hesaplarım yer almaktadır. Bu sayfa, kullanıcıyı karşılayan giriş sayfası olarak düşünülebilir.
<div align="center">
  <img src="https://github.com/melihcolak0/NETCore_Portfolio/blob/c9017bd684dc5e65ee5a89186e79b84a93318a17/ss/showCaseFeature.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Hakkımda Bölümü
Hakkımda bölümünde kendim ile daha detaylı bir bilgi, fotoğrafım ve kişisel bilgilerim yer almaktadır. Telefon numaram, mail üzerinden iletişime geçildiğinde uygun görülürse verilecektir.
<div align="center">
  <img src="https://github.com/melihcolak0/NETCore_Portfolio/blob/c9017bd684dc5e65ee5a89186e79b84a93318a17/ss/showCaseAbout.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Hizmetler Bölümü
Hizmetler bölümünde bu projeyi yaparken kullandığım teknolojilerden bazılarını gösterdim.
<div align="center">
  <img src="https://github.com/melihcolak0/NETCore_Portfolio/blob/c9017bd684dc5e65ee5a89186e79b84a93318a17/ss/showCaseService.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Yeteneklerim Bölümü
Yeteneklerim bölümünde bugüne kadar yapmış olduğum projeler ve almış olduğum eğitimler sonucu kazandığım yetenkleri listeledim.
<div align="center">
  <img src="https://github.com/melihcolak0/NETCore_Portfolio/blob/c9017bd684dc5e65ee5a89186e79b84a93318a17/ss/showCaseSkill.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Projelerim Bölümü
Projelerim bölümünde bugüne kadar yaptığım projeleri listeledim. Buradan projelerin Github yollarına ulaşabiliriz.
<div align="center">
  <img src="https://github.com/melihcolak0/NETCore_Portfolio/blob/c9017bd684dc5e65ee5a89186e79b84a93318a17/ss/showCasePortfolio.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Deneyimlerim Bölümü
Deneyimlerim bölümünde bugüne kadar edinmiş olduğum deneyimler ile ilgili bilgiler yer almaktadır.
<div align="center">
  <img src="https://github.com/melihcolak0/NETCore_Portfolio/blob/c9017bd684dc5e65ee5a89186e79b84a93318a17/ss/showCaseExperience.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Referanslarım Bölümü
Referanslarım bölümünde bugüne kadar edindiğim deneyimlerde bana çok yardımcı olan kişileri listeledim. Fakat gizliliklerini korumak için tam anlamıyla görüntülemek istemedim.
<div align="center">
  <img src="https://github.com/melihcolak0/NETCore_Portfolio/blob/c9017bd684dc5e65ee5a89186e79b84a93318a17/ss/showCaseTestimonial.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: İletişim Bölümü
İletişim bölümünde benim iletişim bilgilerim ve mesaj gönderme bölümü yer almaktadır. Eğer kullanıcı buradan bir mesaj gönderirse Admin bu mesajı görüntüleyip geri mesaj atabilmektedir.
<div align="center">
  <img src="https://github.com/melihcolak0/NETCore_Portfolio/blob/c9017bd684dc5e65ee5a89186e79b84a93318a17/ss/showCaseContact.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Kullanıcı Paneli Bölümü
Kullanıcı Paneli bölümüne tıklandığında kullanıcı, kullanıcı panelindeki Giriş Yapma sayfasına yönlendirilir.

## :arrow_forward: Kullanıcı Paneli
Sırada kullanıcı paneli bulumaktadır. Bu sayfada kullanıcılar giriş yapıp mesajlaşma ve hesap yönetimi gibi işlemler yapabilirler. Genel anlamda bu sayfa Dashboard, Mesajlar, Duyurular ve Profil Ayarları bölümlerinden oluşmaktadır.

### :triangular_flag_on_post: Register Bölümü
Register bölümünde kullanıcı eğer sisteme kayıtlı değilse kaydını yapabilir.
<div align="center">
  <img src="https://github.com/melihcolak0/NETCore_Portfolio/blob/c9017bd684dc5e65ee5a89186e79b84a93318a17/ss/UserRegister.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: LogIn Bölümü
LogIn bölümünde kullanıcı kaydını yaptıktan sonra sisteme giriş yapabilir.
<div align="center">
  <img src="https://github.com/melihcolak0/NETCore_Portfolio/blob/c9017bd684dc5e65ee5a89186e79b84a93318a17/ss/UserLogin.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Dashboard Bölümü
Dashboard bölümünde kullanıcı öncelikle İstanbul şehrinin hava durumunu görüntüleyebilir. Buradaki hava durumu OpenWeatherMap sitesi üzerinde eş zamanlı olarak gösterilir. Devamında kullanıcı bir hoş geldin mesajı ile beraber birkaç istatistik görüntüleyebilir.
<div align="center">
  <img src="https://github.com/melihcolak0/NETCore_Portfolio/blob/c9017bd684dc5e65ee5a89186e79b84a93318a17/ss/UserDashboard.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Mesajlar Bölümü
Mesajlar bölümünde kullanıcı üç farklı sayfa ile karşılaşır. Bunlar gelen mesajlar, gönderilen mesajlar ve yeni mesaj oluşturma sayfalarıdır.
<div align="center">
  <img src="https://github.com/melihcolak0/NETCore_Portfolio/blob/c9017bd684dc5e65ee5a89186e79b84a93318a17/ss/UserInbox.jpg" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/NETCore_Portfolio/blob/c9017bd684dc5e65ee5a89186e79b84a93318a17/ss/UserSendbox.jpg" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/NETCore_Portfolio/blob/c9017bd684dc5e65ee5a89186e79b84a93318a17/ss/UserNewMessage.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Duyurular Bölümü
Duyurular bölümünde admin tarafından oluşturulan duyurular görüntülenebilir.
<div align="center">
  <img src="https://github.com/melihcolak0/NETCore_Portfolio/blob/c9017bd684dc5e65ee5a89186e79b84a93318a17/ss/UserAnnouncement.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Profil Ayarları Bölümü
Kullanıcı buradan kendine ait bilgileri güncelleyebilir ve resim ekleyebilir.
<div align="center">
  <img src="https://github.com/melihcolak0/NETCore_Portfolio/blob/c9017bd684dc5e65ee5a89186e79b84a93318a17/ss/UserProfile.jpg" alt="image alt">
</div>

## :arrow_forward: Admin Paneli
Sırada admin paneli bulumaktadır. Bu sayfada admin ana sayfadaki ve kullanıcı panelindeki tüm CRUD (Create, Read, Update, Delete) işlemlerini yapabilir. Genel anlamda bu sayfa Dashboard, Hakkımda, Yetenekler, Deneyimler, Hizmetler, Projeler, Mesajlar, İletişim, Referanslar, Öne Çıkanlar, Sosyal Medya ve Güvenlik bölümlerinden oluşmaktadır.

### :triangular_flag_on_post: Dashboard Bölümü
Dashboard bölümünde admin, birçok bilgiye erişebilir. Bunlar; çeşitli istatistiki bilgiler, projeler, mesajlar, yapılacaklar listesi gibi yapılardır.
<div align="center">
  <img src="https://github.com/melihcolak0/NETCore_Portfolio/blob/c9017bd684dc5e65ee5a89186e79b84a93318a17/ss/adminDashboard.jpg" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/NETCore_Portfolio/blob/c9017bd684dc5e65ee5a89186e79b84a93318a17/ss/adminDashboard2.jpg" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/NETCore_Portfolio/blob/c9017bd684dc5e65ee5a89186e79b84a93318a17/ss/adminDashboard3.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Hakkımda Bölümü
Hakkımda bölümünde admin, ana sayfada bulunan hakkımda kısmını düzenleyebilmektedir.
<div align="center">
  <img src="https://github.com/melihcolak0/NETCore_Portfolio/blob/c9017bd684dc5e65ee5a89186e79b84a93318a17/ss/adminAbout.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Yetenekler Bölümü
Yetenekler bölümünde admin, ana sayfada bulunan yetenekler kısmı ile ilgili Listeleme, Silme, Güncelleme ve Yeni Ekleme işlemlerini yapabilmektedir.
<div align="center">
  <img src="https://github.com/melihcolak0/NETCore_Portfolio/blob/c9017bd684dc5e65ee5a89186e79b84a93318a17/ss/adminSkill.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Deneyimler ve Deneyimler AJAX Bölümü
Deneyimler bölümünde admin, ana sayfada bulunan deneyimler kısmı ile ilgili Listeleme, Silme, Güncelleme ve Yeni Ekleme işlemlerini yapabilmektedir. Deneyimler AJAX bölümünde ise Listeleme, Silme, Güncelleme ve Yeni Ekleme işlemlerini AJAX üzerinden yaptım.
<div align="center">
  <img src="https://github.com/melihcolak0/NETCore_Portfolio/blob/c9017bd684dc5e65ee5a89186e79b84a93318a17/ss/adminExperience.jpg" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/NETCore_Portfolio/blob/c9017bd684dc5e65ee5a89186e79b84a93318a17/ss/adminExperienceAdd.jpg" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/NETCore_Portfolio/blob/c9017bd684dc5e65ee5a89186e79b84a93318a17/ss/adminExperienceUpdate.jpg" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/NETCore_Portfolio/blob/c9017bd684dc5e65ee5a89186e79b84a93318a17/ss/adminExperienceAjax.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Siteye Git Bölümü
Siteye Git bölümünde admin, ana sayfayı görüntüleyebilmektedir.

### :triangular_flag_on_post: Hizmetler Bölümü
Hizmetler bölümünde admin, ana sayfada bulunan hizmetler kısmı ile ilgili Listeleme, Silme, Güncelleme ve Yeni Ekleme işlemlerini yapabilmektedir.
<div align="center">
  <img src="https://github.com/melihcolak0/NETCore_Portfolio/blob/c9017bd684dc5e65ee5a89186e79b84a93318a17/ss/adminService.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Projeler Bölümü
Projeler bölümünde admin, ana sayfada bulunan projeler kısmı ile ilgili Listeleme, Silme, Güncelleme ve Yeni Ekleme işlemlerini yapabilmektedir.
<div align="center">
  <img src="https://github.com/melihcolak0/NETCore_Portfolio/blob/c9017bd684dc5e65ee5a89186e79b84a93318a17/ss/adminPortfolio.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Mesajlar Bölümü
Mesajlar bölümünde admin, kullanıcıların kullanıcı paneli üzerinden admin@gmail.com mail adresine gönderdiği mesajları görüntüleyebilir. Aynı şekilde kendi gönderdiği mesajları da görüntüleyebilir. Yine aynı şekilde bir de yeni mesaj yazma sayfasına da buradan erişebilir.
<div align="center">
  <img src="https://github.com/melihcolak0/NETCore_Portfolio/blob/c9017bd684dc5e65ee5a89186e79b84a93318a17/ss/adminInbox.jpg" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/NETCore_Portfolio/blob/c9017bd684dc5e65ee5a89186e79b84a93318a17/ss/adminSendbox.jpg" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/NETCore_Portfolio/blob/c9017bd684dc5e65ee5a89186e79b84a93318a17/ss/adminNewMessage.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: İletişim Bölümü
İletişim bölümünde admin, ana sayfada bulunan iletişim kısmındaki Mesaj Gönderme sistemi ile göderilen mesajları burada görüntüler.
<div align="center">
  <img src="https://github.com/melihcolak0/NETCore_Portfolio/blob/c9017bd684dc5e65ee5a89186e79b84a93318a17/ss/adminContact.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: İletişim Bilgileri Bölümü
İletişim Bilgileri bölümünde admin, ana sayfada bulunan iletişim kısmındaki iletişim bilgilerini düzenleyebilir.
<div align="center">
  <img src="https://github.com/melihcolak0/NETCore_Portfolio/blob/c9017bd684dc5e65ee5a89186e79b84a93318a17/ss/adminContact2.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Referanslar Bölümü
Referanslar bölümünde admin, ana sayfada bulunan referanslar kısmı ile ilgili Listeleme, Silme, Güncelleme ve Yeni Ekleme işlemlerini yapabilmektedir. Fakat yine burada gizliliklerini korumak için tam anlamıyla görüntülemek istemedim.
<div align="center">
  <img src="https://github.com/melihcolak0/NETCore_Portfolio/blob/c9017bd684dc5e65ee5a89186e79b84a93318a17/ss/adminTestimonial.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Öne Çıkanlar Bölümü
Öne Çıkanlar bölümünde admin, ana sayfada bulunan öne çıkanlar kısmımini düzenleyebilir.
<div align="center">
  <img src="https://github.com/melihcolak0/NETCore_Portfolio/blob/c9017bd684dc5e65ee5a89186e79b84a93318a17/ss/adminFeature.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Sosyal Medya Bölümü
Sosyal Medya bölümünde admin, ana sayfada bulunan sosyal medya ikonları üzerinde Listeleme, Silme, Güncelleme ve Yeni Ekleme işlemlerini yapabilmektedir.
<div align="center">
  <img src="https://github.com/melihcolak0/NETCore_Portfolio/blob/c9017bd684dc5e65ee5a89186e79b84a93318a17/ss/adminSocailMedia.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Güvenlik Bölümü
Güvenlik bölümünde admin, hata sayfalarını, kullanıcı panelindeki LogIn ve Register sayfalarını görüntüleyebilir.
<div align="center">
  <img src="https://github.com/melihcolak0/NETCore_Portfolio/blob/c9017bd684dc5e65ee5a89186e79b84a93318a17/ss/admin401page.jpg" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/NETCore_Portfolio/blob/c9017bd684dc5e65ee5a89186e79b84a93318a17/ss/admin404page.jpg" alt="image alt">
</div>

