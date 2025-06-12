# Pratik - Constructor Ödevi (C#)

Bu proje, C# dilinde constructor (yapıcı metotlar) kullanımını pekiştirmek amacıyla hazırlanmıştır. Ödevin temel amacı, bir `Bebek` sınıfı oluşturarak iki farklı constructor (yapıcı metot) ile nesne üretimini sağlamaktır.

## 🎯 Amaç

* Constructor (yapıcı metot) mantığını kavramak
* Overload (aşırı yükleme) ile bir sınıfın farklı şekillerde başlatılabileceğini görmek
* Nesne tabanlı programlama yaklaşımını pekiştirmek

## 🧠 Açıklama

`Bebek` adında bir sınıf oluşturulmuştur. Bu sınıfın aşağıdaki özellikleri bulunmaktadır:

* `Ad` : Bebeğin adı
* `SoyAd` : Bebeğin soyadı
* `DogumTarihi` : Bebeğin doğum tarihi (constructor çalıştığında otomatik atanır)

Her iki constructor da çalıştığında konsola "INGAAAAA" mesajı yazdırır.

## 🔧 Uygulama Senaryosu

1. **Varsayılan Constructor ile Bebek Oluşturma:**

   * Parametresiz şekilde nesne oluşturulur.
   * Sonradan `Ad` ve `SoyAd` property'lerine değer atanır.
   * `DogumTarihi` otomatik olarak atanır.
   * "INGAAAAA" mesajı konsola yazdırılır.

2. **Parametreli Constructor ile Bebek Oluşturma:**

   * `Ad` ve `SoyAd` değerleri constructor üzerinden atanır.
   * `DogumTarihi` yine otomatik atanır.
   * "INGAAAAA" mesajı konsola yazdırılır.

3. Oluşturulan iki nesneye ait bilgiler `Console.WriteLine` ile konsola yazdırılır.

## ⚠️ Dikkat Edilecek Noktalar

* `DogumTarihi` bilgisini her iki constructor da atar, dışarıdan manuel atama yapmaya gerek yoktur.
* İkinci bebeği yazdırırken yanlışlıkla birinci nesnenin (`bebek`) bilgilerini yazarsanız, hatalı sonuç alırsınız.

## ✅ Kazanımlar

* Constructor kullanımı ve overload işlemi
* Nesne oluşturma ve property atama
* `DateTime` kullanımı ve `Console.WriteLine` pratiği
