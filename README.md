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


# N KATMANLI MİMARİ

### Entities Katmanı
Dikey mimaride çalışır.

### DataAccess Katmanı
Abstract klasörü içerisinde tanımlı veritabanı nesneli repository'den implemente interface'dir. Ayrıca DTO nesneleri imzalarını barındırır.
Concrete klasöründe yine ayrıca kullanılan teknolojiye bağlı olarak veritabanı nesnesi ve veritabanı context nesnesini tutan base repository inherit - DTO nesnelerini tutan interface'i imlemente class barındırır.

### Core Katmanı
DataAccess katmanında operasyon sınıfları genel olarak birbirini tekrarlayandır. Bunun önüne geçmek için Repository Dizayn Paterni kullanılır.  Generic tipte TEntity kısıtlamaları tanımlı olarak yazılır. Yani TEntity referans tipte veritabanı nesnesi ve newlenebilir somut bir sınıf olmalıdır. İçerisinde operasyonlara kullanıcı parametre vermek isterse Linq expresion ile filtreleme yapacak şekilde IEntityRepository imza interface si oluşturulur. Buna generic constraint denir.
Generic tipte TEntity ve database  genellemesi TContext için base sınıf yine aynı şekilde tiplere kısıtlamalar verilerek oluşturulur. 

Base'de Add(),Update(),Delete() operasyonlarında buna abone ol / refere et 

eklenecek/güncellenecek/silinecek olarak işaretle 

veritabanında ekleme/güncelleme/silme kodunu çalıştır ve SaveChanges metoduyla burada UnitOfDizayn Paterni imlemente ederek onu gerçekleştirmiş olacağız.

Dahada genelleme yapılarak core katmanında ilgili teknoloji klasörü içerisinde tutulur. Bütün CRUD işlemlerimiz için böylece metodlarımızı yazmış oluruz.

### Bussines Katmanı
İş kodlarının tutulduğu katmandır.

### UI Katmanı
Refactory işlemleriyle benzer operasyonler metod veya sınıf olarak tanımlanır.Tekrar tekrar kullanılır.
Programlama tekniklerinden Intelligence programing / Niyet güdümlü programlama : Olmayan metod yazılır. Genereate Metod(sağ click) ile otomatik metodu oluşturur. Test First Devolopment / Önce test yap sonra programını yaz yaklaşımı yapılır. F12 ile progrm içinde gezilir. Refactoring işlemlerinde code generide edilmesi rSharper ile daha rahat oluyor. Solution Buid edilerek çıkan hataya tıklanır. Interface'lerden implemente sınıf yeni kod için tekrar implemente edilir. new'li Dal katmanı içinde yeni delege tanımlanır.


# Programcının Adımları
## I.Adım:
Entities/Concrate'de veritabanı nesnesi IEntity'den inherit gerekli propertileri verilerek oluşturulur.
## II.Adım:
DataAccess/Concrete/EntityFramework'de Teknoloji EntityFramework olduğunu düşünürsek NorthwindContext'de temel mappingi DbSet için propertisi tanımlanır.
## III.Adım:
DataAccess/Abstract'da ilgili nesneden generic olan IEntityRepository'den implemente interface tanımlanır.
## IV.Adım:
DataAccess/Concrete/EntityFramework'de ilgili veritabanı ile context nesneleri verilmiş base sınıftan ve ayrıca III.Adımda oluşturulan interface'den inherit class oluşturulur.

Artık bu çerçevede temel CRUD operasyonları için katmanlı yapım hazırdır.
## V.Adım:
İş katmanında Business/Abstract'de ilgili nesne için service interface'si yazılır. Sadece işe özel metodlar yazılır.
## VI.Adım:
Business/Concrete'de ilgili nesne için interface'inden implemente manager class'ı yazılır. Bu class ilgili nesnenin DataAccess katmanında interface'den implementedir.

# Hata Yönetimi Süreçleri
----


# Best Practice
## UI katmanında nesne isimleri mutlaka değiştirilerek yeniden verilmelidir.(Ör:gbxCategory)

# Not
### İmplemente:
İnterface'ler implementasyon
### İnherit:
Abstract Class'lar ve Normal Class'lar inheritince'dır.
