# DevRentACar

## Takdim :
Başta bu kampı bizlere hediye eden [Engin DEMİROĞ](https://github.com/engindemirog) hocama çok çok teşekkür ederim. Hiçbir maddi ve manevi fedakarlığından vazgeçmeden bizleri spaghetti kodlamadan best practice lerle dolu programcılığa çıkarma arzusunu hayranlıkla izlemekteyim. Sizin derslerdeki enerjiniz bizleri ilerki kodlama hayatımız için şevklendiriyor.

## Ön Söz :
Burası mümkün olduğunca Code Smell / Kötü kokan kodlardan arındırılmış olacaktır. SOLID Prensiplere uyulmaya çalışılmıştır.

## Tanımlar :
Bazı kelimeleri aşağıdaki manaları ile anlamlandırınız. 
- Teknoloji = EntityFramework,NHibernate,Dapper vb.
- Database = MsSQL,ORAGLE,MySQL vb.
- Katmanlar = Business,DataAccess,Entitiy,Core,UI vb.

# Dikkat!!!
Aşağıdaki yazılar ile <div>Icons made by <a href="https://www.freepik.com" title="Freepik">Freepik</a> from <a href="https://www.flaticon.com/" title="Flaticon">www.flaticon.com</a></div>beyin kısa devre yapabilir. Spaghetti Kodlama yazanları uzak tutunuz. :)) Engin Hoca öğrencilerine serbestir.
Veritabanında aşırı Normalizasyon(var olan 5 seviyenin 3. seviyesinde bırakılır) programlamada aşırı tasarım'dan kaçınılmalıdır.
Programın (Handel)üstesinden gelemeyiz. İyi programcı hemen hemen hiç new yazmaz.

# Programcılığın ABC'si
## Sabitler
- Enum programcılıkta en fazla suistimal edilen konuların başında gelir. Gerçekten ona ihtiyaç var mı? Dikkat.
## Karar Verme Mekanizmaları
- İf'ler koşullu yönlendirmeler için kullanılır. Sadece lojik anlamında dağılım(Dallanmak) için kullanılır. Birbirin alternatifi olan işler için kullanılmaz.
 
# Clean Code

Araç:[sonarqube](https://www.sonarqube.org/)

## 1-İsimlendirme Kuralları
İsimlendirme yeterince açıklayıcı Common Language içerisinde olmalıdır.

## 2-Fonksiyonlar
Fonksiyonlar tek sorumluluk prensibine uygun olmalıdır.
Nesnel bir dili fonksiyonel kullanmaya çalışılırsa zafiyetler yaşanır.
Bir çok operasyon parçalanabilir ve metod içerisinde çarılmalıdır.
Bu parçalar başka bir yerdede kullanılabilinir.
Koda devamlı Refactoring ReSharper gibi araçlar kullanılır.

## 3-Yorumlar-Comments
Fonksiyonun içerisine comment yazılmaz.
Bir ölçüye kadar fonksiyonun üzerine intelizans desteği için yazılır.
Kurumsal hafıza için yazılır.

## 4-Soyutlama
Çıplak kılas kalmasın. Open/Closed Principle uygun olmalıdır.

## 5-SOLID İmplementasyonu

### SOLID Prensipler Nedir?
SOLID isimlendirmesi beş tane prensibin ilk harferinden oluşur.
Yazılımda sürdürülebilirliği ve temiz kod yazımı sağlıyor.
Bir değişiklik geldiğinde yazılım direnç göstermiyor ise SOLID prensibe uygundur denir.

#### Single Responsibility Principle:
Tek sorumluluk prensibine göre her bloğun, her metodun, her classın ve her katmanın sadece bir görevi vardır.
Arayüz UI : MVC Mimari ile => MobilUI|WebUI|MasaüstüUI / Business / DataAccess / Entities
Örneğin Katman anlamında Controllerin içerisinde Business kodu yazılmaz. Veya Business'in içerisinde DataAccess kodu yazılmaz.
Kodsal anlamda bir metodun içerisinde iki farklı iş kodu yazılmaz.

#### Open/Closed Principle:
Bir uygulama yeni bir özellik eklemeye açık. Değiştirmeye kapalı olmalıdır. Konfigürasyon hariç mevcuttaki tek bir satır koda dokunulmaz.
Örneğin: Yeni bir teknoloji veya database sisteme ekleme yaparken soyutlamadan faydalanılır. Gevşek bağlılık olmalıdır.
#### Liskov ‘s Substitution Principle:

#### Interface Segregation Principle:

#### Dependency Inversion Principle:
En kaba tabir ile bir katman diğer katmanı new'leyemez. Bağımlılıkların azaltımıdır. 
Dependency Injection(DI) Deseni kullanılır. Gereken nesnenin ya Constructor’dan ya da Setter metoduyla parametre olarak alınması gerektiğini vurgulamaktadır. Böylece iki classı birbirinden izole ederiz. Örneğin IProductDall Interface ini bu desen ile sınıfın yapıcı metodu içerisinde kullandığımda aynı implementasyondan oluşan ve iş kodları kendilerine özgü olan teknojileri bağımlılığım olmadan çağırabilmiş olurum.
Bu olay micro servis yazımına kadar gider. İş katmanında başka bir iş katmanını dahi newleyemessiniz.

## 6-(AOP) Aspect Oriented Programming
Bir çok araç ile yapılabilinir.
+ IoC Container
+ Sarmallama Tekniği
Örneğin; Add operasyonu üzerinde {Validasyon}{Tansaction-Unit of work}{Caching}{Loglama}{Authorized}{Perforance} Aspec'ler yazılarak Single Responsibility Principle uyulur.


# OOP
...
##### Encapsulation: 
Bir nesnenin bazı özellik ve işlevlerini başka sınıflardan ve nesnelerden saklamak.
Fonksiyonlarda parametreler-->model/DTO/ComplexType gibi ortak nesneler içine koyup öyle gönderilir.
##### Soyutlama Tekniği:
İnterfaceler kullanılır. Katmanlar arasında iletişimi sağlarlar.
...




# Design Pattern
...



## KURALLAR

### Hangi teknolojiyi kullanıyorsak onunla ilgili Concrete klasörü altına klasör açılır.
İçindeki dosyalarda bu klasörleme yapısına göre Namespace adı verilir.
Aynı şey dosya isimleri içinde geçerlidir. Teknolojiye bağlı olarak dosya ismi verilir.(Ör: EfProductDall gibi)

### Çıplak Class kalmasın.
Bir Class'ın base'inin inherit veya implementasyonunun olması gerekir. SOLID'in - sürdürülebilirliğin sağlanması için olmazsa olmaz kuraldır.
O yüzden Abstract klasöründe implementasyonlar için Interface'ler yazılır.
İlgili Classımızın imzaları bu Interface'den implemente edilmesi sağlanır.
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
Validasyon yönetimi bu katmanda yapılır.

### UI Katmanı
Bir kullanıcıya birşeyler göstermek. Kullanıcıdan bilgi almak kısacası kullanıcı ile yapılan her etkileşim bu katmanın işidir.
Refactory işlemleriyle benzer operasyonler metod veya sınıf olarak tanımlanır.Tekrar tekrar kullanılır.
Programlama tekniklerinden Intelligence programing / Niyet güdümlü programlama : Olmayan metod yazılır. Genereate Metod(sağ click) ile otomatik metodu oluşturur. Test First Devolopment / Önce test yap sonra kodu yaz yaklaşımı yapılır. F12 ile progrm içinde gezilir. Refactoring işlemlerinde code generide edilmesi rSharper ile daha rahat oluyor. Solution Buid edilerek çıkan hataya tıklanır. Interface'lerden implemente sınıf yeni kod için tekrar implemente edilir. new'li Dal katmanı içinde yeni delege tanımlanır. Bu işlemler aşağıdaki programcının adımlarının tersine gidilmesi olarakta düşünülenebilinir.
Hata yönetimi arayüzün işi değildir. Try catch ile sadece hatayı nasıl göstereceğiyle ilgilenir.





# Programcının Adımları
## I.Adım:
Entities/Concrate'de veritabanı nesnesi IEntity'den implemente ve gerekli veritabanında tabloda veri karşılıklarını tutan propertileri verilerek oluşturulan classdır.
## II.Adım:
DataAccess/Concrete/EntityFramework'de burada teknoloji EntityFramework olduğunu düşünürerek NorthwindContext'de temel mappingi DbSet için propertisi tanımlanır.
## III.Adım:
DataAccess/Abstract'da ilgili nesneden generic olan IEntityRepository'den implemente interface tanımlanır.
## IV.Adım:
DataAccess/Concrete/EntityFramework'de ilgili veritabanı ile context nesneleri verilmiş base sınıftan inherit ve ayrıca III.Adımda oluşturulan interface'den implemente class oluşturulur.
Artık bu çerçevede temel CRUD operasyonları için katmanlı yapı hazırdır.
## V.Adım:
İş katmanında Business/Abstract'de ilgili nesne için service interface'si yazılır. Sadece işe özel metodlar ihtiyaç ne ise kodlanır.
## VI.Adım:
Business/Concrete'de ilgili nesne için interface'inden implemente manager class'ı yazılır. Bu class constructorında ilgili nesnenin DataAccess katmanındaki interface'den parametre ile nesne oluşturulur.
## VII.Adım:
Bundan sonra artık UI katmanında katmanlı mimarinin nimetlerini kullanma zamanı geldi.(DataGirid nesnesi içinde verileri listeleme,Combobox içerisinde categorileri almak gibi) Burada UI katman işlemleri gerçekleştirilir.
Önce ihtiyacımız olan nesne servisi çağırılır. Consructor içerisinde bu servisi refere eden nesne managerı oluşturulur. Manager'de ilgili teknolojiden dal nesnesi parametre olarak verilir.





# Hata Yönetimi Süreçleri
----




# Best Practice
## UI katmanında nesne isimleri mutlaka değiştirilerek yeniden verilmelidir.(Ör:gbxCategory)




# Not
### İmplemente:
İnterface'ler implementasyon
### İnherit:
Abstract Class'lar ve Normal Class'lar inheritince'dır.




# Ek Bilgiler
VS çok kullandığımız bloklar varsa sağ tıklayıp sinppet oluşturabilinir.

# Kaynakça
- [kodlama.io](https://www.kodlama.io/)
- Udemy/YouTube - Engin DEMİROĞ Eğitim Serileri
- Clean Code - Robert C. Martin
