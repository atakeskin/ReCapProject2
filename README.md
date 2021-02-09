# DevRentACar

## Takdim
Başta bu kampı bizlere hediye eden [Engin DEMİROĞ](https://github.com/engindemirog) hocama çok çok teşekkür ederim. Hiçbir maddi ve manevi fedakarlığından vazgeçmeden bizleri spaghetti kodlamadan best practice lerle dolu programcılığa çıkarma arzusunu hayranlıkla izlemekteyim. Sizin derslerdeki enerjiniz bizleri ilerki kodlama hayatımız için şevklendiriyor.
## Ön Söz
Burası mümkün olduğunca Code Smell / Kötü kokan kodlardan arındırılmış olacaktır. SOLID Prensiplere uyulmaya çalışılmıştır.


# Dikkat!!!
Aşağıdaki yazılar ile beyin kısa devre yapabilir. Spaghetti Kodlama yazanları uzak tutunuz. :)) Engin Hoca öğrencilerine serbestir.


## SOLID Prensipler Nedir?
### Single Responsibility Principle:

### Open/Closed Principle:
Bir uygulama yeni bir özellik eklendiğinde (burada değişiklikten bahsedilmiyor) konfigürasyon hariç mevcutta olan kodlara dokunulmaz.

### Liskov ‘s Substitution Principle:

### Interface Segregation Principle:

### Dependency Inversion Principle:
En kaba tabir ile bir katman diğer katmanı new'leyemez. Bağımlılıkların azaltımıdır. 
Dependency Injection(DI) Deseni kullanılır. Gereken nesnenin ya Constructor’dan ya da Setter metoduyla parametre olarak alınması gerektiğini vurgulamaktadır. Böylece iki classı birbirinden izole ederiz. Örneğin IProductDall Interface ini bu desen ile sınıfın yapıcı metodu içerisinde kullandığımda aynı implementasyondan oluşan ve iş kodları kendilerine özgü olan teknojileri(Ör:Entity Framework,NHibernate vb.) bağımlılığım olmadan çağırabilmiş olurum.
Bu olay micro servis yazımına kadar gider. İş katmanında başka bir iş katmanını dahi newleyemessiniz.

## KURALLAR

### Hangi teknolojiyi kullanıyorsak onunla ilgili Concrete klasörü altına klasör açılır.
İçindeki dosyalar bu klasörleme yapısına göre Namespace adı verilir.
Aynı şey dosya isimleri içinde geçerlidir. Teknolojiye bağlı olarak dosya ismi verilir.(Ör: EfProductDall gibi)

### Çıplak Class kalmasın.
Bir Class'ın base'inin veya implementasyonunun olması gerekir.
O yüzden Abstract klasöründe implementasyonlar yazılır.
İlgili Classımızın imzaları bu Interface'den inherid edilmesi sağlanır.
Aynı zamanda yeni bir teknoloji(Entity Framework,NHibernate vb.) kullandığımızda Classımız bu Interface üzerinden miras alır. Ve böylece bağımlılığn önüne geçilmiş olunacaktır.
Veritabanı tablo nesne karşılığı olan class'larımız için burada;
IEntity : Veritabanı nesnesi olduğunu belirten imzadır(boş bir interface)
IDto : Veritabanı nesnesi olan sınıfların join edilerek birleşiminden oluşmuş nesneyi belirten imzadır.

### Katmanlar arası iletişim için Public belirtecinden faydalanılınır.
### DataAccess Katmanı
Abstract klasörü içerisinde tanımlı veritabanı nesneli repository'den implemente interface'dir. Ayrıca DTO nesneleri imzalarını barındırır.
Concrete klasöründe yine ayrıca kullanılan teknolojiye bağlı olarak veritabanı nesnesi ve veritabanı context nesnesini tutan base repository ile DTO nesnelerini tutan interface'i inherit eder.
### Core Katmanı
DataAccess katmanında operasyon sınıfları genel olarak birbirini tekrarlayandır. Bunun önüne geçmek için Repository Dizayn Paterni kullanılır.  Generic tipte TEntity kısıtlamaları tanımlı olarak yazılır. Yani TEntity referans tipte veritabanı nesnesi ve newlenebilir somut bir sınıf olmalıdır. İçerisinde operasyonlara kullanıcı parametre vermek isterse Linq expresion ile filtreleme yapacak şekilde IEntityRepository imza interface si oluşturulur. Buna generic constraint denir.
Generic tipte TEntity ve database  genellemesi TContext için base sınıf yine aynı şekilde tiplere kısıtlamalar verilerek oluşturulur. Dahada genelleme yapılarak core katmanında ilgiliteknoloji klasörü içerisinde tutulur.

