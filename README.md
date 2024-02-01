
# Glosy Proje Dökümanı

- Proje `.Net 6` ile oluşturulmuştur veri tabanı olarak `MSSQL` kullanılmıştır.
- Proje çalışmadan önce `appsettings.json`'da bulunan `ConnectionString` bilgilerinin kontrol edilip ona göre projenin çalıştırılması önerilir.
- Proje ilk kez çalıştırmadan önce migration işlemi yapılması gereklidir.
- Projenin en makul çalışması için multiple şeklinde winform uygulamasıyla beraber çalıştırılması önerilir.
- Bunlara ek olarak Client tarafında `Angular 15.2.0` kullanılmıştır(Node Version 18.19.0).


## Kullanılan Teknolojiler

  EntityFrameworkCore, AutoMapper, SignalR, Autofac.

  
## API Kullanımı

#### Tüm ürünleri listeler

```https
  GET Product/api/Product/products
```

#### Ürün ekler

```https
  POST Product/api/Product/add-product
```

#### Ürün günceller

```https
  UPDATE Product/api/Product/update-product
```

#### Ürün siler

```https
  DELETE Product/api/Product/add-product
```





  
