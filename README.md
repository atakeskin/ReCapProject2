# DevRentACar

## 📌 Takdim :
Başta bu kampı bizlere hediye eden [Engin DEMİROĞ](https://github.com/engindemirog) hocama çok çok teşekkür ederim. Hiçbir maddi ve manevi fedakarlığından vazgeçmeden bizleri spaghetti kodlamadan best practice lerle dolu programcılığa çıkarma arzusunu hayranlıkla izlemekteyim. Sizin derslerdeki enerjiniz bizleri ilerki kodlama hayatımız için şevklendiriyor.


## 📌 Ön Söz :
Burası mümkün olduğunca Code Smell / Kötü kokan, içinde tekrarlanmış (duplicate) kodlar arındırılmış olacaktır. SOLID Prensiplere uyulmaya çalışılmıştır. Temiz Mimariye odaklanır. Profesyonelliğe ulaşım için en ileri teknikler ile implemente etmeye odaklanınılmıştır.


## 📌 Tanımlar :
Bazı kelimeleri aşağıdaki manaları ile anlamlandırınız. 
- Teknoloji = EntityFramework,NHibernate,Dapper vb.
- Client = Angular, React, Vue, Flutter, React Native, Kotlin, Android için java uygulamaları vb.
- Database = MsSQL,ORAGLE,MySQL vb.
- Katmanlar = Business,DataAccess,Entitiy,Core,UI vb.
- Soyutlama = Interface vb.


## ⚠ Dikkat!!!
Aşağıdaki yazılar ile beyin kısa devre yapabilir. O yüzden Spaghetti Kodlama yazanları uzak tutunuz. :)) Engin Hoca öğrencilerine serbestir.
Veritabanında aşırı Normalizasyon(var olan 5 seviyenin 3. seviyesinde bırakılır) programlamada over design(aşırı tasarım'dan) kaçınılmalıdır.
Programın (Handel)üstesinden gelemeyiz. İyi programcı hemen hemen hiç new yazmaz. Bunun için IoC Container teknojilerinden faydalanırız. En çok kullanılanlar;Ninject,AutoFac,Structure Map, Castle Windsor vb. IoC Container'lar bu newlemeleri bizim için bir konfigurasyon vasıtasıyla yapmamızı sağlayan dolayısıyla sistemde istediğimiz zaman değişiklik yapmamızı sağlayan ortamdır.


## 📌 Programcılığın ABC'si

## Değişkenler
- Değer tipler : Belleğin Stek bölümünü kullanır.Örneğin int,decimal vb.
- Referans tipler : Belleğin Stek ve Heap bölümlerini kullanırlar.Örneğin Class'lar,Interface vb.
- String : Ör:TcNo sayısal bir işlem yapılmadığından bu tiptir.
Anti Patern oluşturan magic string'lerden kaçınılmalıdır.

## Field
Bir class yada struct içinde tanımlanan her tipten değişkendir.Private isimlendirme pascalCase yazılır. Public ise CamelCase yazılır.

## Constance(Sabitler)
- Enum programcılıkta en fazla suistimal edilen konuların başında gelir. Gerçekten ona ihtiyaç var mı? Dikkat.

## Generic Tip
- Herhangi bir değer/referans tiplerin genellemesidir. Kısıtlamalar where verilerek özele indirgenebilinir. 

## Karar Verme Mekanizmaları
- İf'ler koşullu yönlendirmeler için kullanılır. Sadece lojik anlamında dağılım(Dallanmak) için kullanılır. Birbirin alternatifi olan işler için kullanılmaz.
- switch doğaları gereği switch ifadeleri N tane şey yaparlar. Abstract Factory tasarım deseni (design pattern) temeline gömmek ve başka hiç kimsenin görmesine izin vermemektir.
## Döngüler
...
## Exception
- try/catch Bloklarını çirkindir ve Ayırın

## 📌  Clean Code

Araç:[sonarqube](https://www.sonarqube.org/)

## 1-İsimlendirme Kuralları
İsimlendirme yeterince açıklayıcı Common Language içerisinde olmalıdır.
Ör: 
- int elapsedTimeInDays;
- getActiveAccount();

## 2-Fonksiyonlar
Fonksiyonlar tek sorumluluk prensibine uygun olmalıdır.Sadece Bir Şey Yapmalıdır. Çok kısa olmalıdır.
Nesnel bir dili fonksiyonel kullanmaya çalışılırsa zafiyetler yaşanır.
Bir çok operasyon parçalanabilir ve metod içerisinde çarılmalıdır.
Bu parçalar başka bir yerdede kullanılabilinir.
Koda devamlı Refactoring için ReSharper gibi araçlar kullanılır.

## 3-Yorumlar-Comments
Yorum Yok.Fonksiyonun içerisine comment yazılmaz.
Bir ölçüye kadar fonksiyonun üzerine intelizans desteği için yazılır.
Kurumsal hafıza için yazılır.

## 4-Soyutlama
Çıplak kılas kalmasın. Open/Closed Principle uygun olmalıdır.

## 5-SOLID Prensipleri İmplementasyonu

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
Örneğin: Yeni bir teknoloji veya database sisteme ekleme yaparken soyutlamadan faydalanılarak gevşek bağlılık(Loosely Coupled) Dependency Inversion Principle ile 
sağlanır.

#### Liskov‘s Substitution Principle:
Bulgar bir hanımefendi tarafından ortaya atılmıştır. 
Nesneleri sırf birbirine benziyor diye birbirinin yerine kullanma. Ör: İlişkisel Veritabanında Normalization çinememek için bankanın iki tip gerçek, tüzel kişi nesneleri ayrı ayrı ve Musteri base nesnesinden inherit yapılır.

#### Interface Segregation Principle:
Kullanmayacağın bir şeyi yazma. Güçlü interface'i parçalara ayırarak ör:IPayable,IWorkable,IEatable vb. ilgili nesnel classlar tarafından ihtiyaçları doğrultusunda bir veya daha fazla implemente edilmesi sağlanır. Böylece gereksiz implementasyonun önüne geçilerek clean code yazımı gerçekleştirilir.

#### Dependency Inversion Principle:
En kaba tabir ile bir katman diğer katmanı new'leyemez. Bağımlılıkların azaltımıdır. 
Dependency Injection(DI) Deseni kullanılır. Gereken nesnenin ya Constructor’dan ya da Setter metoduyla parametre olarak alınması gerektiğini vurgulamaktadır. Böylece iki classı birbirinden izole ederiz. Örneğin IProductDall Interface ini bu desen ile sınıfın yapıcı metodu içerisinde kullandığımızda aynı implementasyondan oluşan ve iş kodları kendilerine özgü olan teknojileri bağımlılığımız olmadan çağırabilmiş oluruz. Bir katman bir katmana gevşek bağlılığı sağlar.
Bu olay micro servis yazımına kadar gider. İş katmanında başka bir iş katmanını dahi newleyemessiniz.

## 6-(AOP) Aspect Oriented Programming Yaklaşımı
Bir çok araç ile yapılabilinir.
+ IoC Container
+ Sarmallama Tekniği
Örneğin; Add operasyonu üzerinde {Validasyon}{Tansaction-Unit of work}{Caching}{Loglama}{Authorized}{Perforance} Aspec'ler yazılarak Single Responsibility Principle uyulur.

## Dört basit tasarım kuralı
- Tüm testleri çalıştırın : Bir tasarım, amaçlandığı gibi hareket eden bir sistem üretmelidir.
- Tekrarlanmış kodlar yazmayın : Tekrarlanmış kodlar, ek iş, ek risk ve gereksiz karmaşa demektir. 
- Açıklayıcı olun : kodumuz yazanın niyetini açıkça belli etmelidir. Yazar kodu daha da açık hale getirdikçe, diğerlerinin anlaması için geçen süre ve bakım süresi daha da azalır.
- Sınıf ve metot sayısını en aza indirin : Sınıflarımızı ve metotlarımızı küçültmek için çabalarken, küçük küçük bir çok sınıf ve metot yaratabiliriz. Bu kural ise bu sayıyı minimumda tutmamız gerektiğini söylüyor.

## 📌 OOP
##### Properties
Property : Property, field ve metotları(Getter Setter) birleştirir.
Getter Readonly'lidir Constructor'da set edilebilinir.
##### Static Metod
Newlenmez ve uygulama hayatında tek bir instance'ı vardır. Deirek çağırılır.
##### Cunstructor
Cunstructor kendi base'i içinde kendini tekrar etme ilkesi içerisinde nested kullanılır.
##### Class
- newlenebilirler. Sınıf tasarımı konusundaki ilk kural sınıfların küçük olmaları gerektiğidir. 
- SOLID'in I harfine göre bir class bir class'ı inherit ettiğinde sen aslında base'inin structerini içeriyorsun.Haberin olsun demektir. O da diyor ki constructorları varsa implente et o zaman diye bizi uyarır.
##### Encapsulation: 
Bir nesnenin bazı özellik ve işlevlerini başka sınıflardan ve nesnelerden saklamak.
Fonksiyonlarda parametreler-->model/DTO/ComplexType gibi ortak nesneler içine koyup öyle gönderilir.
Bir metotda sadece bir değer döndürülür. Mesela liste gibi. Ama aynı anda birden fazla değer döndürmek isteniyorsa encapsulation yapılır. Bunun için 
##### Soyutlama Tekniği:
İnterfaceler kullanılır.
- Özellik tutan Classların yönetimi
- Katmanlar arasında iletişimi sağlarlar. İş katmanı veri erişim katmanıyla Dependency Inversion Principle ayağa kaldırılarak interface vasıtasıyla iletişim kurar.
- Bir proje içerisinde kullanırken oradaki referans yönetimini yakalanır. Utilities / Results içerisinde Data veya işlem sonucu ve kullanıcıyı bilgilendirmek için mesaj olur.
- SOLID'in I harfine göre bir interface bir interface'i implemente ettiğinde otomatikmen kodlarını içerir.
##### Abstract Class :
Abstractlar inherittır. Aynı zamanda bir nesnel class gibide davranır. Kullanım konusunda cimri olmak gerekir. Interfacelerden farkı nesnel class'lara bir abstract class verilebilinir. Interface'ler ise kısıtlama yoktur. Abstract Class'lar daha çok Business iş süreçlerinde karşımıza çıkar.
- Polimorfizmle (çok biçimlilik)
...


## CQRS (Command Query Responsibility Segregation) Yaklaşımı
...

## PnP (Plug and Play) mimarisine
...


## 📌  Design Pattern
###### ⚠ Tasarım kalıpları ezberlenmeye çalışılmaz. Tasarım kalıplarında amaç SOLID'i ayağa kaldırmaktır. 
###### ⚠ Unutma!!Kodlamamızda SOLID'e uyarak yazdığımızda ismini bilmesekte tasarımkalıplarını otomatik olarak yazarız.
...




## 📌 KURALLAR

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
Veri Aktarım Nesneleri (Data Transfer Objects) : public değişkenleri olan ve hiç fonksiyonu olmayan sınıftır. Buna bazen DTO da deriz; ki bu nesneler özellikle veritabanı vb. yerlerle haberleşiyorken oldukça kullanışlıdır.
### Katmanlar arası iletişim için Public belirtecinden faydalanılınır.





## 📌 N KATMANLI MİMARİ

### 📚 Core Katmanı
Evrensel katmandır. Birkere yazılır. Kurumsal mimaride tüm projelerde kullanabilirdir.
DataAccess katmanında operasyon sınıfları genel olarak birbirini tekrarlayandır. Bunun önüne geçmek için Repository Dizayn Paterni kullanılır.  Generic tipte TEntity kısıtlamaları tanımlı olarak yazılır. Yani TEntity referans tipte veritabanı nesnesi ve newlenebilir somut bir sınıf olmalıdır. İçerisinde operasyonlara kullanıcı parametre vermek isterse Linq expresion ile filtreleme yapacak şekilde IEntityRepository imza interface si oluşturulur. Buna generic constraint denir.
Generic tipte TEntity ve database  genellemesi TContext için base sınıf yine aynı şekilde tiplere kısıtlamalar verilerek oluşturulur. 

Base'de Add(),Update(),Delete() operasyonlarında buna abone ol / refere et 

eklenecek/güncellenecek/silinecek olarak işaretle 

veritabanında ekleme/güncelleme/silme kodunu çalıştır ve SaveChanges metoduyla burada UnitOfDizayn Paterni imlemente ederek onu gerçekleştirmiş olacağız.

Dahada genelleme yapılarak core katmanında ilgili teknolojiyi base repository haline getirerek klasörü içerisinde tutulur. Bütün CRUD işlemler için böylece metodlar yazmış olunur.

### 📚 Entities Katmanı
Dikey mimaride çalışır.

### 📚 DataAccess Katmanı - Veri erişim Katmanı
Abstract klasörü içerisinde tanımlı veritabanı nesneli repository'den implemente interface'dir. Ayrıca DTO nesneleri imzalarını barındırır.
Concrete klasöründe yine ayrıca kullanılan teknolojiye bağlı olarak veritabanı nesnesi ve veritabanı context nesnesini tutan base repository inherit - DTO nesnelerini tutan interface'i imlemente class barındırır.

### 📚 Bussines Katmanı
İş kodlarının tutulduğu katmandır. Validasyon yönetimi bu katmanda yapılır. 

### 📚 WebAPI Katmanı
Yeni modern ve populer geliştirme ortamıdır. Farklı client'lar ile backend katmanlı mimarinin arasında data yönetimi için iletişim kurulmasını sağlar. WepApi'de RestFul(Json vb.) Mimarisi gibi Standartları bulunur. Servise client'lardan istek (Request) yapılır. Ör: Şu kategorideki ürünleri getir. Yanıt olarakta Response veilir. Microsoft tafında bu mimari ASP.NET WebAPI'dır. Test ortamı olarak Postman kullanılabilinir.

### 📚 UnitTest Katmanı

### 📚 UI Katmanı
- Bir kullanıcıya birşeyler göstermek. Kullanıcıdan bilgi almak kısacası kullanıcı ile yapılan her etkileşim bu katmanın işidir. Yazılımın Frontend kısmına karşılık gelir. Diğer katmanlar Backend kısmını oluşturur.
- Bir kaç metot sadeleştirmesi, yeniden adlandırma, kendini tekrar etme yaklaşımı gibi benzer operasyonel metod veya sınıf yeniden yapılandırımı (refactoring) işlemleri yürütülür. Oluşturulan kod blokları tekrar tekrar kullanılır.
- Hata yönetimi arayüzün işi değildir. Try catch ile sadece hatayı nasıl göstereceğiyle ilgilenir.

New'lemeler için .NET CORE içerisinde IoC Container amacı ile MVC tarafında implementasyonlar var. Fakat Backend'de bizim yine IoC Containerlardan destek vermemiz gerekiyor. Çünkü Microsoft teknolojileri sadece kendi yapıları-frameworkleri tanıyacak şekildedir. Bizim oluşturduğumuz katmanlar için ayrıca IoC container'ler sisteme tanımlamamız gerekir. Ayrıca WepApi yaptığımızda MVC yapısının içinde kalan IoC Container işimize yaramayacaktır.



## 📌 Programcının Adımları

- Programlama tekniklerinden Intelligence programing / Niyet güdümlü programlama : Olmayan metod yazılır. Genereate Metod(sağ click) ile otomatik metodu oluşturur.
- Test First Devolopment / Önce test yap sonra kodu yaz yaklaşımı yapılır. F12 ile program içinde gezilir. 
- Refactoring işlemlerinde code generide edilmesi rSharper ile daha rahat oluyor. 
- Solution Buid edilerek çıkan hataya tıklanır. 
- Interface'lerden implemente sınıf yeni kod için tekrar implemente edilir. new'li Dal katmanı içinde yeni delege tanımlanır. Bu işlemler aşağıdaki programcının adımlarının tersine gidilmesi olarakta düşünülenebilinir.

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






## 📌 Exception Yönetimi(Hata Yönetimi) Süreçleri
Hata işleme (Error handling) : İstisnaları (exception) işleyebileceğimiz ve raporlayabileceğimiz teknikler.  Bir hata ile karşılaşıldığında istisna fırlatmak (throw) daha iyidir. Çağıranın kodunu daha temiz hale getirir. İlk Önce Try-Catch-Finally Bloklarını Yazın
----





## 📌 Best Practice
## UI katmanında nesne isimleri mutlaka değiştirilerek yeniden verilmelidir.(Ör:gbxCategory)





## 📌 Not
### İmplemente:
İnterface'ler implementasyon
### İnherit:
Abstract Class'lar ve Normal Class'lar inheritince'dır.





## 📌 Ek Bilgiler
VS çok kullandığımız bloklar varsa sağ tıklayıp sinppet oluşturabilinir.


## 📌 Referans Kaynakça
- [kodlama.io](https://www.kodlama.io/)
- [Udemy](https://www.udemy.com/courses/search/?src=ukw&q=%22engin+demiro%C4%9F%22)/[YouTube](https://www.youtube.com/channel/UCRjiquPh4mjPNoOV9eCilXQ) - Engin DEMİROĞ Eğitim Serileri
- [Clean Code](https://www.amazon.com.tr/Clean-Code-Handbook-Software-Craftsmanship/dp/0132350882) - Robert C. Martin
- [DevArchitecture](https://www.devarchitecture.net/)
