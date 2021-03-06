# Rent A Car

## Backend with C#

Kurumsal, Katmanlı Mimari yapısı kullanılarak **SOLID** kuralları dahilinde oluşturulmuş, C# dili ile yazılmış Araba kiralama fikri üzerinden ilerlenmştir.

* [Angular for Frontend](https://github.com/sumeyyekaratekin/RentACar_Frontend)

### Kullanılan Teknolojiler

- .Net Core 3.1
- Restful API
- Result Türleri
- Interceptor
- Autofac
    - IoC Containers
    - AOP, Aspect Oriented Programming
        - Caching
        - Performance
        - Transaction
        - Validation
        - Logging
- Fluent Validation
- Cache yönetimi
- JWT Authentication
- Repository Design Pattern
- Cross Cutting Concerns
    - Caching
    - Validation
- Extensions
    - Claim
        - Claim Principal
    - Exception Middleware
    - Service Collection
    - Error Handling
        - Error Details
        - Validation Error Details

### Katmanlar

- **Core**: Projenin çekirdek katmanı, evrensel operasyonlar için kullanılmaktadır.
- **DataAccess**: Projenin, Veritabanı ile bağını kurmak için oluşturulmuştur.
- **Entities**: Veritabanındaki tablolarımızın projemizde nesne olarak kullanılması için oluşturulmuştur. DTO nesnelerinide
  barındırmaktadır.
- **Business**: Projemizin iş katmanıdır. Türlü iş kuralları; Veri kontrolleri, validasyonlar, IoC Container'lar ve yetki
  kontrolleri
- **WebAPI**: Projenin Restful API Katmanıdır. Kullanılan methodlar: Get, Post, Put, Delete

# Image Tables

Brand Request type
![ImageTables](https://github.com/sumeyyekaratekin/RentACarProject/blob/main/Screenshots/brand-add.png)
-
![ImageTables](https://github.com/sumeyyekaratekin/RentACarProject/blob/main/Screenshots/brand-delete.png)
- 
![ImageTables](https://github.com/sumeyyekaratekin/RentACarProject/blob/main/Screenshots/brand-update.png)