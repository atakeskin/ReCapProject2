# DevRentACar

## Takdim
Başta bu kampı bizlere hediye eden [Engin DEMİROĞ](https://github.com/engindemirog) hocama çok çok teşekkür ederim. Hiçbir maddi ve manevi fedakarlığından vazgeçmeden bizleri spaghetti kodlamadan best practice lerle dolu programcılığa çıkarma arzusunu hayranlıkla izlemekteyim. Sizin derslerdeki enerjiniz bizleri ilerki kodlama hayatımız için şevklendiriyor.
## Ön Söz
Burası mümkün olduğunca Code Smell / Kötü kokan kodlardan arındırılmış olacaktır. SOLID Prensiplere uyulmaya çalışılmıştır.

## SOLID Prensipler Nedir?
### Single Responsibility Principle:

### Open/Closed Principle:
Bir uygulama yeni bir özellik eklendiğinde (burada değişiklikten bahsedilmiyor) konfigürasyon hariç mevcutta olan kodlara dokunulmaz.

### Liskov ‘s Substitution Principle:

### Interface Segregation Principle:

### Dependency Inversion Principle:
En kaba tabir ile bir katman diğer katmanı new'leyemez. Bağımlılıklar artar. 
Dependency Injection(DI) Deseni kullanılır. Gereken nesnenin ya Constructor’dan ya da Setter metoduyla parametre olarak alınması gerektiğini vurgulamaktadır. Böylece iki classı birbirinden izole ederiz. Örneğin IProductDall Interface ini bu desen ile sınıfın yapıcı metodu içerisinde kullandığımda aynı implementasyondan oluşan ve iş kodları kendilerine özgü olan teknojileri(Ör:Entity Framework,NHibernate vb.) bağımlılığım olmadan çağırabilmiş olurum.
Bu olay micro servis yazımına kadar gider. İş katmanında başka bir iş katmanını dahi newlememesiniz.

## KURALLAR

### Hangi teknolojiyi kullanıyorsak onunla ilgili Concrete klasörü altına klasör açılır.
İçindeki dosyalar bu klasörleme yapısına göre Namespace adı verilir.
Aynı şey dosya isimleri içinde geçerlidir. Teknolojiye bağlı olarak dosya ismi verilir.(Ör: EfProductDall gibi)

### Çıplak Class kalmasın.
Bir Class'ın base'inin veya iplementasyonunun olması gerekir.
O yüzden Abstract klasöründe implementasyonlar yazılır.
İlgili Classımızın imzaları bu Interface'den inherid edilmesi sağlanır.
Aynı zamanda yeni bir teknoloji(Entity Framework,NHibernate vb.) kullandığımızda Classımız bu Interface üzerinden miras alır. Ve böylece bağımlılığn önüne geçilmiş olunacaktır.
Veritabanı tablo nesne karşılığı olan class'larımız için burada;
IEntity : Veritabanı nesnesi olduğunu belirten imzadır(boş bir interface)
IDto : Veritabanı nesnesi olan sınıfların join edilerek birleşiminden oluşmuş nesneyi belirten imzadır.

### Katmanlar arası iletişim için Public belirtecinden faydalanılınır.

### Core Katmanı
DataAccess katmanında operasyon sınıfları genel olarak birbirini tekrarlayandır. Bunun önüne geçmek için Repository Dizayn Paterni kullanılır. İçerisinde operasyonlar içerisinde kullanıcı parametre vermek isterse Linq expresion ile filtreleme yaper. Generic tipte TEntity ve databese  genellemesi TContext için base sınıf oluşturulur ve core katmanında tutulur.
