# :gem:.NET Core ile Admin ve Kullanıcı Panelli Portföy Sitesi
Bu repository, Murat Yücedağ'ın Udemy'de bulunan Asp.Net Core 5.0 ile Adım Adım Web Geliştirme kursunu içermektedir. Bu eğitimde bana yol gösteren Murat Yücedağ'a çok teşekkür ederim.

ASP.NET Core Web Application (.NET Core Framework) kullanarak dinamik bir Portföy sitesi oluşturdum. Bu projede N-Tier Architecture (N Katmanlı Mimari) ve MVC tabanlı bir yapı kullandım. SOLID prensiplerine ve dosya organizasyonuna uygun şekilde geliştirme yaparak kod tekrarını en aza indirmeye çalıştım. Entity Framework Core - Code First yaklaşımını kullanarak veritabanı bağlantılarını oluşturdum.

N-Tier Architecture (N Katmanlı Mimari), yazılım uygulamalarını birden fazla bağımsız katmana (layer) bölerek geliştirmeye olanak tanıyan bir yazılım mimari modelidir.
Bu mimari, uygulamanın farklı katmanlarını belirleyerek modülerlik, ölçeklenebilirlik ve bakım kolaylığı sağlar.

Genel anlamda 5 katman üzerinde projeyi oluşturdum. Presentation Layer (Sunum Katmanı), kullanıcının doğrudan etkileşimde bulunduğu katmandır. Burada HTML5, CSS3, Bootstrap ve JavaScript kullanarak web sayfaları oluşturdum. Business Logic Layer (İş Mantığı Katmanı), uygulamanın kurallarını ve iş mantığını barındırır. Service ve Manager olarak tüm entity'lerin metotlarını oluşturup kontrollerini yaptım. Data Access Layer (Veri Erişim Katmanı), veritabanı ile etkileşimi sağlar. Burada veri tabanındaki verileri gereken şekilde kullandım. Entity Layer (Varlık Katmanı), verileri saklayan katmandır. Burası Code-First yaklaşımının başlangıcıdır. Veri tabanındaki tablolar ve sütunlar yerine bu katmanda sınıflar ve property'ler kullandım. Son olarak da projeye en son örnek amaçlı eklediğim API katmanı. Bu katmanda uygulamanın diğer istemciler (web, mobil, masaüstü vb.) tarafından erişilebilecek şekilde veri sağlayan bir yapı olarak kullanılır. API Controller bu katmanda HTTP tabanlı istekleri (GET, POST, PUT, DELETE vb.) işleyerek veri alıp gönderen bileşenlerdir.

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
Deneyimlerim bölümünde bugüne kadar edinmiş olduğum deneyimler ile iligi bilgiler yer almaktadır.
<div align="center">
  <img src="https://github.com/melihcolak0/NETCore_Portfolio/blob/c9017bd684dc5e65ee5a89186e79b84a93318a17/ss/showCaseExperience.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Referanslarım Bölümü
Referanslarım bölümünde bugüne kadar edindiğim deneyimlerde bana çok yardımcı olan kişileri listeledim. Fakat gizliliklerini korumak için tam anlamıyla görüntülemek istemedim.
<div align="center">
  <img src="https://github.com/melihcolak0/NETCore_Portfolio/blob/c9017bd684dc5e65ee5a89186e79b84a93318a17/ss/showCaseTestimonial.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: İletişim Bölümü
İletişim bölümünde benim iletişi bilgilerim ve mesaj gönderme bölümü yer almaktadır. Eğer kullanıcı buradan bir mesaj gönderirse Admin bu mesajı görüntüleyip geri mesaj atabilmektedir.
<div align="center">
  <img src="https://github.com/melihcolak0/NETCore_Portfolio/blob/c9017bd684dc5e65ee5a89186e79b84a93318a17/ss/showCaseContact.jpg	" alt="image alt">
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


