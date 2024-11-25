# CarBook - Araç Kiralama Projesi

## Proje Hakkında

**CarBook**, kullanıcıların araç kiralama işlemleri yapabileceği, araçların detaylarına ulaşabileceği, lokasyona göre fiyatları görüntüleyebileceği ve kiralama işlemlerini kolayca gerçekleştirebileceği bir platformdur. Admin paneli üzerinden araçlar, lokasyonlar, bloglar, referanslar ve diğer içerikler yönetilebilir. Ayrıca, kullanıcılar araçlarla ilgili yorumlar yapabilir ve bu yorumları inceleyebilirler. 

Bu proje, **ASP.NET Core 8.0 Web API** ve **MVC** ile geliştirilmiştir ve **Onion Architecture** mimarisi kullanılarak yapılandırılmıştır. **CQRS**, **Mediator**, **Repository** design pattern'ları ile uygulamanın sürdürülebilirliği ve ölçeklenebilirliği artırılmıştır. **JWT**, **SignalR** ve **FluentValidation** gibi teknolojiler ile güvenlik, canlı veri takibi ve doğrulama işlemleri yapılmaktadır.

## Kullanılan Teknolojiler
- **ASP.NET Core 8.0** - Web API ve MVC
- **MSSQL** - Veritabanı yönetimi
- **Entity Framework Code First** - ORM aracı
- **SignalR** - Gerçek zamanlı veri iletişimi
- **Json Web Token (JWT)** - Kullanıcı kimlik doğrulama ve güvenliği
- **Swagger** - API dokümantasyonu
- **Postman** - API test aracı
- **HTML**, **CSS**, **JavaScript**, **Bootstrap** - Frontend teknolojileri
- **Onion Architecture** - Mimari yapı
- **CQRS** - Command Query Responsibility Segregation
- **Mediator** - İç iletişim yönetimi
- **Repository Design Pattern** - Veritabanı işlemlerinin yönetimi

## Öne Çıkan Özellikler
- **Lokasyona Göre Araç Filtreleme ve Kiralama**: Kullanıcılar, araçları lokasyona göre filtreleyip kiralayabilirler.
- **Araç Detaylarını Görüntüleme**: Seçilen aracın tüm özellikleri ve fiyat bilgisi gösterilebilir.
- **Admin Paneli**: Admin, araç bilgilerini, lokasyonları, blogları, referansları ve diğer içerikleri yönetebilir.
- **SignalR ile Canlı Veri Takibi**: Gerçek zamanlı veri takibi ve bildirimler.
- **JWT ile Kimlik Doğrulama**: Kullanıcı güvenliği sağlanır.
- **İstatistik ve Dashboard**: Admin panelinde proje ile ilgili detaylı istatistik ve grafikler.
- **Yabancı Dil Desteği**: Çok dilli kullanım desteği.

## Teknik Özellikler
- **MSSQL Veritabanı**: Veritabanı işlemleri için SQL Server kullanılmıştır.
- **ASP.NET Core 8.0**: Uygulama backend'i ASP.NET Core 8.0 ile geliştirilmiştir.
- **Swagger & Postman**: API dokümantasyonu ve test işlemleri için kullanılmıştır.
- **Onion Architecture**: Uygulama, bağımsız katmanlar ve veri akışları kullanılarak tasarlanmıştır.
- **CQRS ve Mediator**: Komutlar ve sorgular için ayrı veri akışları sağlanmış, uygulama içi iletişim Mediator kullanılarak yönetilmiştir.
- **SignalR**: Gerçek zamanlı verilerin aktarılması için SignalR entegrasyonu yapılmıştır.
- **Json Web Token (JWT)**: Kullanıcıların güvenliğini sağlamak amacıyla kimlik doğrulama işlemleri JWT ile yapılmıştır.

## Ekran Goruntuleri
![Ekran görüntüsü 2024-11-25 024425](https://github.com/user-attachments/assets/6718e2a5-5c5d-46d1-9a92-da6704e7ab16)
![Ekran görüntüsü 2024-11-25 025013](https://github.com/user-attachments/assets/bd75f0e2-01ba-4017-ab86-50e51ef4670c)
![Ekran görüntüsü 2024-11-25 025556](https://github.com/user-attachments/assets/d8412b05-224a-45df-b16f-7e0655b80f1a)
![Ekran görüntüsü 2024-11-25 025322](https://github.com/user-attachments/assets/93ada41d-ac1c-493a-b144-c1b651d08ace)
![Ekran görüntüsü 2024-11-25 025105](https://github.com/user-attachments/assets/6bc15b5a-65e0-4ad8-b0fc-49bda359917c)
![Ekran görüntüsü 2024-11-25 025734](https://github.com/user-attachments/assets/db41660c-c2ee-443e-b448-2c1bc70101fa)
![Ekran görüntüsü 2024-11-25 025707](https://github.com/user-attachments/assets/f7405eca-4ded-43d9-bbe2-cd25f139034e)
![Ekran görüntüsü 2024-11-25 025634](https://github.com/user-attachments/assets/1971ba42-1af9-40b8-ac0e-573fb3dd1c04)
![Ekran görüntüsü 2024-11-25 030219](https://github.com/user-attachments/assets/2b2d4d2f-8adf-474c-9227-0b1eea941e30)
![Ekran görüntüsü 2024-11-25 033246](https://github.com/user-attachments/assets/a98f0d68-7d6f-402a-806c-922cdcc8ed99)
![Ekran görüntüsü 2024-11-25 033219](https://github.com/user-attachments/assets/45950a5d-e7bc-4e01-afd1-7c1c53a2f9f1)
![Ekran görüntüsü 2024-11-25 033142](https://github.com/user-attachments/assets/2048bf6e-77ab-4021-97e1-9793dd9b5dbc)
![Ekran görüntüsü 2024-11-25 033052](https://github.com/user-attachments/assets/83f50a7d-7c3d-4083-a330-59a05b73276d)
![Ekran görüntüsü 2024-11-25 033303](https://github.com/user-attachments/assets/cb9bb932-b540-4efd-9a40-97764fb6b2f7)



