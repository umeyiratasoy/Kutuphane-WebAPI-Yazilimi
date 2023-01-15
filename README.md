# <p align="center">Kütüphane-WebAPI</p>
Kütüphanelerin Öğrenciler ve Görevli arasında iletişim sağlayıp kitapların alışveriş verilerini saklayacağı HTTP Tabanlı Rest-Ful Servisli WebAPI Yazılımı </div>

<div align="center">
   <a href = "https://www.linkedin.com/in/umeyir-atasoy/"><img  src = "https://marka-logo.com/wp-content/uploads/2020/04/Linkedin-Logo.png" width = "85" height = "50" alt = "My Linkedin Profile"/></a>
</div>

## Belgeler

Bu projenin ön yüzü [Kutuphane-WebAPI-Yazilimi-Frontend](#) | To be done later.
Bu projenin öncesinde sistem analizi ve tasarım yapılıp Scrum Metodolojisi(kurgu) şeklinde kodlanmıştır.
   Gerekli belgelere tıklayıp ulaşabilirsiniz. [Belgeler](https://github.com/umeyiratasoy/Kutuphane-WebAPI-Yazilimi/tree/Kutuphane-WebAPI-Yazilimi/Documents)


## Teknolojiler, Çerçeveler ve En İyi Uygulamalar

  * ASP.Net 
  * OOP
  * SQL Server
  * N Layered Architecture (Entity, Data Access, Business, WebAPI, Core)
  * Desing Patterns
  * Entity Framework 
  * IoC
  * Autofac
  * FluentValidation (for building validation rules)
  * JWT (Authentication), Hashing and Salting

## Getting Started

### Kurulum

1. Depoyu klonlayın::

   ```sh
   git clone https://github.com/umeyiratasoy/Kutuphane-WebAPI-Yazilimi.git
   ```
2. `Kütüphane-WebAPI.sln` dosyasını `Visual Studio` ile açın.
3. `Kütüphane-WebAPI.sql` dosyasını veri tabanına entegre edin.
4. `DataAccess.Concrete.EntityFramework` klasöründeki `KütüphaneWebAPIContext.cs` dosyasını açın ve kendi veritabanı bağlantı dizginizi girin
5. "Çözüm Gezgini"nden "WebAPI" projesine (katman) sağ tıklayın ve "Başlangıç Projesi Olarak Ayarla"yı seçin
6. Projeyi Visual Studio'da "IIS Express" ile başlatın. Web API hazır ve çalışıyor!

### Kullanım
 
Web API'sini çalıştırdıktan sonra, aşağıdaki gibi HTTP istekleri yapabilirsiniz:
   

 
    "CONTROLLER_NAME" => "WebAPI.Controllers" klasöründe bulunan her bir .cs dosyası (Örneğin, "OgrencilerController" için CONTROLLER_NAME: ogrenciler )
    "METHOD_NAME" => "WebAPI.Controllers" klasöründeki her bir .cs dosyasındaki tüm yöntemler
 
#### Örnek HTTP GET istekleri

1. Tüm kitapları listele:
   ```sh
   https://localhost:44317/api/kitaplar/getall
   ```
2. Bir kitabı detaylı listeleyin:
   ```sh
   https://localhost:44317/api/kitaplar/getbyid?id=1
   ```
3. Ödünç alınan kitapları detaylı listeleyin:
   ```sh
   https://localhost:44317/api/emanetler/getemanetdetaylar
   ```
4. Kitap eklemek:
   ```sh
   https://localhost:44317/api/kitaplar/add
   ```

## Teknik Yığın
| Teknoloji / Kütüphane | Sürüm |
| ------------- | ------------- |
| .NET | 5.0 |
| Autofac | 6.2.0 |
| Autofac.Extensions.DependencyInjection | 7.1.0 |
| Autofac.Extras.DynamicProxy | 6.0.0 |
| FluentValidation | 10.3.0 |
| Microsoft.AspNetCore.Authentication.JwtBearer | 5.0.9 |
| Microsoft.AspNetCore.Http | 2.2.2 |
| Microsoft.AspNetCore.Http.Abstractions | 2.2.0 |
| Microsoft.AspNetCore.Features | 5.0.9 |
| Microsoft.EntityFrameworkCore.Design | 5.0.8 |
| Microsoft.EntityFrameworkCore.SqlServer | 5.0.8 |
| Microsoft.EntityFrameworkCore.Configuration | 5.0.0 |
| Microsoft.EntityFrameworkCore.Configuration.Binder | 5.0.0 |
| Microsoft.IdentityModel.Tokens | 6.12.2 |
| Mime-Detective | 22.7.16 |
| Newtonsoft.Json | 10.0.1 |


## İlişkili Proje

Bu projenin ön yüzü [Kutuphane-WebAPI-Yazilimi-Frontend](#) | Daha sonra yapılacak.
