# DevRentACar -- I LOVE YOU C# --

## 📌 Takdim :
Başta bu kampı bizlere hediye eden [Engin DEMİROĞ](https://github.com/engindemirog) hocamıza çok çok teşekkür ederim. Hiçbir maddi ve manevi fedakarlığından vazgeçmeden bizleri spaghetti kodlamadan best practice'lerle dolu programcılığa çıkarma arzusunu hayranlıkla izlemekteyim. Sizin derslerdeki enerjiniz bizleri ilerki kodlama hayatımız için motive ediyor. Bizlere yapmacık örneklerle değil gerçek hayatta karşımıza çıkacak güncel, bire bir uygulanan kodlarla örnekleme yapmanız önümüze ışık tutuyor. Ezberleten değil öğreten yaklaşımınız bizlerin yeni teknolojik gelişmelere daha kolay adapte olmamızı sağlıyor. Bizleri sektörde nitelikli kılıyor. Size nekadar teşekkür etsek az.


## 📌 Ön Söz :
Burası mümkün olduğunca Code Smell / Kötü kokan, DRY - Do not repeat yourself yazılım kalıpları içinde tekrarlanmış (code duplication) kodlardan arındırılmış olacaktır. SOLID Prensiplere uyulmaya çalışılmıştır. Temiz Mimariye odaklanır. Profesyonelliğe ulaşım için en ileri teknikler ile implemente etmeye odaklanınılmıştır. İnanın bu yaklaşımlar sizlere çok teorik gelebilir. Biliniz ki bunları şimdi uygulamakla ileride çok rahat edeceksiniz, beklenmedik şeylerin farkında olmadan üstesinden gelmiş ve çok ekmeğini yiyeceksiniz. 

## 📌 Teşekkür :
Eğer bu yazım birilerine ilham olduysa hayrını ; yazılım için zorlu çalışmalarımda(benim için zevkli :)) başta Engin DEMİROĞ hocam olmak üzere boylarından büyük sabır gösteren ve bende hakları olan eşim ve çocuklarıma adarım.

## 📌 Tanımlar :
Bazı kelimeleri aşağıdaki manaları ile anlamlandırınız. 
- Teknoloji = EntityFramework,NHibernate,Dapper vb.
- Client = Angular, React, Vue, Flutter, React Native, Kotlin, Android için java uygulamaları vb.
- Database = MsSQL,ORAGLE,MySQL vb.
- Katmanlar = Business,DataAccess,Entitiy,Core,UI vb.
- Soyutlama = Interface vb.
- Versiyonlama = Program yazımında kullandığımız anadil ve ek olarak teknolojik library'lerin versiyon uyumluluğu için hassasiyet gösterilmesidir.
- DTO (Data Transformation Object) - Complex Type: Veritabanonda bulunan iki tablonun join edilerek birleşiminden doğan tabloların nesnel karşılığı yada veritabanı tablosunda olmayan ekstra propertisi olan nesneleridir.

## ⚠ Dikkat!!!
Aşağıdaki yazılar bazıları için beyin yakıcı olabilir. O yüzden Spaghetti Kodlama yazanları uzak tutunuz. :)) Engin Hoca öğrencileri hariç.

## Over Design(Aşırı Tasarım) 'dan kaçın

Veritabanında aşırı Normalizasyon(var olan 5 seviyenin 3. seviyesinde bırakılır) programlamada over design(aşırı tasarım'dan) kaçınılmalıdır.
Programın (Handel)üstesinden gelemeyiz. İyi programcı hemen hemen hiç new yazmaz. 
- Kayıt/Instance üretimini için IoC Container yapılandırma teknojilerinden faydalanırız. En çok kullanılanlar;Postsharp,AutoFac,Ninject,Structure Map,Castle Windsor,  Microsoft Enterprise Library içerisinde bulunan Unity bloğu vb. IoC Container'lar bu newlemeleri bizim için bir konfigurasyon vasıtasıyla yapmamızı dolayısıyla sistemde istediğimiz zaman değişiklik yapmayı sağlayan ortamdır. Bir nevi Factory Tasarım Desenidir. Hangi interface in karşılığı nedir şeklinde.
- Birde çalışma anında Activator.CreateInstance'la reflection kullanılarak çalışma anında dinamik instance'ı üretilir. Dolayısıyla bu instance'e bağlı metod çalışma anında getMethod ile çağrılır ve invok ile çalıştırılır. Çalışma anında bir classın propertilerine,metodlarına,attribute'lerine vb ve bunlar objeden gelen özelliklerinin listelenmesi için oradanda parametrelerinin listelenmesinde kullanılır. Bellek için pahalı bir işlem olduğundan ancak ihtiyaç doğrultusunda kullanılmalıdır.


## 📌 Programcılığın ABC'si

## Değişkenler
- Değer tipler : Belleğin Stek bölümünü kullanır.Örneğin number: int,decimal,boolean vb. Tanımlanmadıysa undefine'dır.
- Referans tipler : Belleğin Stek ve Heap bölümlerini kullanırlar.Örneğin diziler,Class'lar,Interface vb. Refarans oluşmadıysa null'dır.
- String : Anti Patern oluşturan magic string'lerden kaçınılmalıdır.

## Field
Bir class yada struct içinde tanımlanan her tipten değişkendir. Private isimlendirme camelCase yazılır. Public ise PascalCase yazılır.

## Properties
Property : Property, field ve metotları(Getter Setter) birleştirir.
Getter Readonly'lidir Constructor'da set edilebilinir.

## Linq
- .Net içerisinde C# diline gömülü dil mimarisidir.
- Nesneler için array, Koleksiyon(liste,dizi) linq to object
- EntityFramework(Veri tabanını sorgulama) linq to entity

## Delegate
- Elçi. Yapılmak istenen operasyonlar eklenir ve/veya çıkarılır. Void türünde özel bir tür döndermeyen kod blokları için Action kullanılır. Buna ek olarak dönüş tipi olan parametreler için Func kullanılır. Bunlar Mevcut kod bloklarını başka bir kod bloklarıyla sarmallayarak void veya bir değer döndürürler. Ve delegedirler. CrossCutting işlemleri bu türdendir.

## Events
- Uygulamada bir hareket olduğunda ve o harekete ek olarak yapmak istediğimiz bir işlem var olduğunda kullanılırlar. Yanlızca o nesne için abone isek çalışır. Delegelerin kullanımından faydalanılır. Events bir delegedir. Bir delegate tanımlanır. event bu delegate tipinde ve isminin sonunda ..Event olacak şekilde tanımlanır.

## Lambda
Predicate delegasyondur.

## Constance(Sabitler)
- Enum programcılıkta en fazla suistimal edilen konuların başında gelir. Gerçekten ona ihtiyaç var mı? Dikkat.

## Generic Tip
- Herhangi bir değer/referans tiplerin genellemesidir. Class, fonksiyon tekrar tekrar yazmamak için yapılır. Tip güvenli dediğimiz modelle çalışmayı sağlar. Kısıtlamalar where verilerek özele indirgenebilinir. 

## Karar Verme Mekanizmaları
- İf'ler koşullu yönlendirmeler için kullanılır. Sadece lojik anlamında dağılım(Dallanmak) için kullanılır. Birbirin alternatifi olan işler için kullanılmaz.
- switch doğaları gereği switch ifadeleri N tane şey yaparlar. Abstract Factory tasarım deseni (design pattern) temeline gömmek ve başka hiç kimsenin görmesine izin vermemektir.
- 
## Loops
- Verileri setlerini iterit etmek için kullanılır.
- İndex(in) ve value(of)
-
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
En kaba tabir ile bir katman diğer katmanı new'leyemez. Bir katman bir katmana gevşek bağlılığı sağlar. Bağımlılıkların azaltımıdır. Bu olay micro servis yazımına kadar gider. İş katmanında başka bir iş katmanını dahi newleyemessiniz.
Dependency Injection(DI) Deseni kullanılır. Gereken nesnenin ya Constructor’dan ya da Setter metoduyla parametre olarak alınması gerektiğini vurgulamaktadır. Böylece iki classı birbirinden izole ederiz. Örneğin IProductDall Interface ini bu desen ile sınıfın yapıcı metodu içerisinde kullandığımızda aynı implementasyondan oluşan ve iş kodları kendilerine özgü olan teknojileri bağımlılığımız olmadan çağırabilmiş oluruz.
- AddScoped : Request bazlı çalışır. Request için birkez instance create edilir.
- AddSingleton : Sadece uygulama ayağa kalktığı zaman ilk çağrıldığında instance create edilir.
- AddTransient : Hem request başlangıcında ve aynı request çağrıldığında yeniden instance create edilir.


## 6-(AOP) Aspect Oriented Programming Yaklaşımı
Uygulama kodunda belirli bir yerde execute edilecek olan Loglama mekanizmasının (concern) loglama metodunun (pointcut) hangi şartlar altında ne zaman (join point) execute edileceği (bir araya girme bir interception) olgusuna aspect denir. AOP özellikle encapsulation konusunda bir tamamlayıcı olarak düşünülür.
Bir çok araç ile yapılabilinir.Separation of Cross-Cutting Concerns'dir. Bir yazılım geliştirme yaklaşımıdır.
- Side-Effect Concern:
Pointcut’ların kendisiyle ilişkilendirilmiş olan bir kod parçacı olduğundan, intercept ettiğinden yani araya girer. Bu araya girme işlemi kodun akışında davranışsal (behavior) olarak bir değişikliğe sebep olmuyorsa bu bir side-effect concern’dür. Logging bu açıdan baktığımızda iyi bir örnek.
- Advice Concern: 
AOP ve functional programming’de (prosedürel programlama) execute edildiğinde join point olarak yer aldığı fonksiyonun veya metotdun davranışını değiştiren fonksiyon veya metotlara denir. Ör:Caching
- Weaving :
Bir kod parçasının çalıştırılması (executing) esnasında bir aspect’in araya nasıl gireceği yöntemiyle alakalı.(interception model) İki yöntemleyapılır. Compile-Time Weaving ve Run-Time Weaving.
- Dynamic Proxy Yöntemi
Run-time Weaving yöntemleri arasında en popüler olanı. Bu yöntemin öncülerinden biri Castle Projesi. Dinamik olmasının sebebi yukarıda bahsettiğim gibi proxy’lerin oluşturulması işleminin run-time’da dinamik olarak oluşturulması. Bu size müthiş bir esneknik sağlıyor, run-time’da pointcut ve join point’lerini dinamik olarak değiştirebilirsiniz veya aynı nesnenin farklı proxy’lerini kullanabiliriz.
Castle DynamicProxy’nin belli kısıtları var. Mesela intercept edeceğiniz metotlar ya virtual olmalı yada interface metotları olmalı. Bu kısıtların sebebi DynamicProxy’nin yapısından kaynaklanıyor.

+ IoC Container
+ Sarmallama Tekniği
Örneğin; Add operasyonu üzerinde {Validasyon}{Tansaction-Unit of work}{Caching}{Loglama}{Authorized}{Perforance} Aspec'ler yazılarak Single Responsibility Principle uyulur.

## [Attribute]
- Nesneye bir imza koyma işlemidir. Classlara,Metodlara,Propertys,Fields bir anlam yüklüyoruz. Attribute Reflection ilişkisiyle beslenen bir mimaridir. Üzerine konulması gereken derin konulardan bir tanesidir.
- DataAnnotations'lar vasıtasıyla nesne veritabanıyla ilişkilendiriliyor veya arayüzde doğrulamalar ile ilişkilendiriliyor.

## Dört basit tasarım kuralı
- Tüm testleri çalıştırın : Bir tasarım, amaçlandığı gibi hareket eden bir sistem üretmelidir.
- Tekrarlanmış kodlar yazmayın : Tekrarlanmış kodlar, ek iş, ek risk ve gereksiz karmaşa demektir. 
- Açıklayıcı olun : kodumuz yazanın niyetini açıkça belli etmelidir. Yazar kodu daha da açık hale getirdikçe, diğerlerinin anlaması için geçen süre ve bakım süresi daha da azalır.
- Sınıf ve metot sayısını en aza indirin : Sınıflarımızı ve metotlarımızı küçültmek için çabalarken, küçük küçük bir çok sınıf ve metot yaratabiliriz. Bu kural ise bu sayıyı minimumda tutmamız gerektiğini söylüyor.

## 📌 OOP

##### Erişim Belirteçleri
- Public : Her(Solution) taraftan erişilebilir.
- İnternal : Sadece ilgili proje katmanı altından erişilir.
- Private : Sadece tanımlandığı yerde(blok) kullanılır.
- Protected : Sadece inherid ettiği yerde kullanılır.
##### Static Metod
Newlenmez ve uygulama hayatında tek bir instance'ı vardır. Direk çağırılabilirler.

##### Virtual Metod
Virtual yazılan metodlar istenirse daha sonra override edilerek ezilirler.

##### Cunstructor
Cunstructor kendi base'i içinde kendini tekrar etme ilkesi içerisinde nested kullanılır.

##### Class
- newlenebilirler. Sınıf tasarımı konusundaki ilk kural sınıfların küçük olmaları gerektiğidir. 
- SOLID'in I harfine göre bir class bir class'ı inherit ettiğinde sen aslında base'inin structerini içeriyorsun.Haberin olsun demektir. O da diyor ki constructorları varsa implente et o zaman diye bizi uyarır.
- Class'ın C#'da metodlarından biri static ise clasın static olasına gerek yoktur. Javada bu zorunludur.
- Gerçek hayatta varlıklar/programlamada nesneler class'ların newlenmeleriyle oluşturulur. Nesnelerin özellik ve metodlarına bu şekilde ulaşılınır.
- C#'da Classın erişim belirteci default (internal)'dır. Private yaznızca iç içe klaslarda içerideki classa verilir. Pek kullanılmaz.
- Encapsulation gibi bir çok özelliğide beraberinde getirir. İçerisinde özellik ve operasyonları barındırır.
- İnherit edilerek sürdürülebilirliği sağlar.
- 
##### Encapsulation: 
Bir nesnenin bazı özellik ve işlevlerini başka sınıflardan ve nesnelerden saklamak. Encapsulation OOP’daki nihai amaçdır.
Fonksiyonlarda parametreler-->model/DTO/ComplexType gibi ortak nesneler içine koyup öyle gönderilir.
Bir metotda sadece bir değer döndürülür. Mesela liste gibi. Ama aynı anda birden fazla değer döndürmek isteniyorsa encapsulation yapılır. Bunun için 

##### Soyutlama Tekniği:

- Özellik tutan Classların yönetimidir. İnterfaceler kullanılır. Referans tutuculardır.
- Katmanlar arasında iletişimi sağlarlar. İş katmanı veri erişim katmanıyla Dependency Inversion Principle ayağa kaldırılarak interface vasıtasıyla iletişim kurar.
- Bir proje içerisinde kullanırken oradaki referans yönetimini yakalanır. Utilities / Results içerisinde Data veya işlem sonucu ve kullanıcıyı bilgilendirmek için mesaj olur.
- SOLID'in I harfine göre bir interface bir interface'i implemente ettiğinde otomatikmen kodlarını içerir.
- İmplemantasyon eden diğer sınıflar için imza içerir.
- Getter ve setterler bir nevi class için soyutlama tekniğidir.

##### Abstract Class :
Abstractlar inherittır. Aynı zamanda bir nesnel class gibide davranır. Kullanım konusunda cimri olmak gerekir. Interfacelerden farkı nesnel class'lara bir abstract class verilebilinir. Interface'ler ise kısıtlama yoktur. Abstract Class'lar daha çok Business iş süreçlerinde karşımıza çıkar.
- Polimorfizimle (çok biçimlilik)
...


## CQRS (Command Query Responsibility Segregation) Yaklaşımı
...

## PnP (Plug and Play) mimarisine
...


## 📌  Design Pattern
###### ⚠ Tasarım kalıpları ezberlenmeye çalışılmaz. Tasarım kalıplarında amaç SOLID'i ayağa kaldırmaktır. 
###### ⚠ Unutma!! Kodlamamızda SOLID'e uyarak oluşturduğumuzda ismini bilmesekte tasarım kalıplarını otomatik olarak yazarız.
...




## 📌 KURALLAR

### Hangi teknolojiyi kullanıyorsak onunla ilgili Concrete klasörü altına klasör açılır.
İçindeki dosyalarda bu klasörleme yapısına göre Namespace adı verilir.
Aynı şey dosya isimleri içinde geçerlidir. Teknolojiye bağlı olarak dosya ismi verilir.(Ör: EfProductDall gibi)

### Uzmanından bir söz : "Çıplak class kalmasın. _Engin Demiroğ"
Bir Class'ın base'inin inherit veya implementasyonunun olması gerekir. SOLID'in - sürdürülebilirliğin sağlanması için olmazsa olmaz kuraldır.
O yüzden Abstract klasöründe implementasyonlar için Interface'ler yazılır.
İlgili Classımızın imzaları bu Interface'den implemente edilmesi sağlanır.
Aynı zamanda yeni bir teknoloji(Entity Framework,NHibernate vb.) kullandığımızda Classımız bu Interface üzerinden miras alır. Ve böylece bağımlılığn önüne geçilmiş olunacaktır. İstisnası Araç olarak kullanılan statik classlar yalın kalabilir.Metodlarıda statik olur.

Veritabanı tablo nesne karşılığı olan class'larımız için burada;
IEntity : Veritabanı nesnesi olduğunu belirten imzadır(boş bir interface)
IDto : Veritabanı nesnesi olan sınıfların join edilerek birleşiminden oluşmuş nesneyi belirten imzadır.
Veri Aktarım Nesneleri (Data Transfer Objects) : public değişkenleri olan ve hiç fonksiyonu olmayan sınıftır. Buna bazen DTO da deriz; ki bu nesneler özellikle veritabanı vb. yerlerle haberleşiyorken oldukça kullanışlıdır.

### Default olarak katmanlı bir mimaride çalıştığımız ve diğer taraflarda bunu kullandığı için katmanlar arası iletişim amacından dolayı Public belirtecinden faydalanılınır.

## 📌 BİRAZDA TEK TEK N KATMANLI MİMARİYİ TANIYALIM
Kurumsal mimari hafızası standart bir alt yapıda oluşturulur.
- Backend ve Frontend olarak ikiye ayrabiliriz. Backendde asıl olan  DRY Prensiblerin (reusability,Maintainability vb.) oluşumunu sağlayan nesnel sistemlerin kurulumunu sağlamaktır. Bu ihtiyaçların çeşitlenmesinden ötürüdür. Mobil(IOS,Android...), Desktop(MT,Windows...), Web
- Frontend uygulamanın ön yüzünü oluşturur. - Html,Css,JS
- Klasörleme ; Abstract:Soyut(Abstract,Interface,Base) sınıflar tutulur. Concrete:Somut sınıflar tutulur.
- C#'da katmanlardan biri diğerini referans almıış olduğu durumda aynı an için tersi geçerli değildir. Javada bu durum söz konusu değildir.
- Solution proje bazlı database isimlendirmesi verilerek yola çıkılır.Katmanlar için bu isimlendirme nokta katman adı verilir. Bu diğer projelerde kullanılacaksa böyle yapılır. İstenirse sadece o projeye özgü katman adı verilebilinir.

### 📚 Core Katmanı

- Evrensel olan framework katmandır. Bir kere yazılır. Kurumsal mimaride tüm projelerde kullanabilir. Ör: JWT(JSON Web Token)işlemleri 
- DataAccess katmanında operasyon sınıfları genel olarak birbirini tekrarlayandır. Bunun önüne geçmek için Repository Dizayn Paterni kullanılır.  Generic tipte TEntity kısıtlamaları tanımlı olarak yazılır. Yani TEntity referans tipte veritabanı nesnesi ve newlenebilir somut bir sınıf olmalıdır. İçerisinde operasyonlara kullanıcı parametre vermek isterse Linq expresion ile filtreleme yapacak şekilde IEntityRepository imza interface si oluşturulur. Buna generic constraint denir.
Generic tipte TEntity ve database  genellemesi TContext için base sınıf yine aynı şekilde tiplere kısıtlamalar verilerek oluşturulur. 
- Base'de Add(),Update(),Delete() operasyonlarında buna abone ol / refere et Eklenecek/güncellenecek/silinecek olarak işaretle Veritabanında ekleme/güncelleme/silme kodunu çalıştır ve SaveChanges metoduyla burada UnitOfDizayn Paterni imlemente ederek onu gerçekleştirmiş olacağız. Dahada genelleme yapılarak core katmanında ilgili teknolojiyi base repository haline getirerek klasörü içerisinde tutulur. Bütün CRUD işlemler için böylece metodlar yazmış olunur.
- TEntity Database nesnesi ve TDto interface'i tutulur. Ayrıca evrensel entities nesneleride burada tutulur.

### 📚 Entities Katmanı
Dikey mimaride çalışır. Temel manada Entity varlıktır. Veritabanı nesnelerini ve DTO'ları burada oluştururuz.

### 📚 Cross-Cutting Concern
Çapraz kesmek manasındadır. Her katmanı dikey olarak kesen ilgi alanlarıdır. Yani her katmanda kullanılabilirler. Kaba bir tabirle Aspect-Oriented kullanarak Loglama, Exception Handling, Security, Caching, Transaction bunların hepsi katman bağımsız parçalar, modüller, her katmanda birbirlerinden bağımsız şekilde kullanılabilirler. 

### 📚 DataAccess Katmanı 
- Sadece Veri Erişim Katmanı işlerini yapar. Insert,Update,Delete ve Select kodları yazılır. ORM Teknolojileri kullanılır.
- Abstract klasörü içerisinde tanımlı veritabanı nesneli repository'den implemente interface'dir. Ayrıca DTO nesneleri imzalarını barındırır.
- Concrete klasöründe yine ayrıca kullanılan teknolojiye bağlı olarak veritabanı nesnesi ve veritabanı context nesnesini tutan base repository inherit - DTO nesnelerini tutan interface'i imlemente class barındırır.

### 📚 Bussines Katmanı
- İş kurallarının/kodlarının tutulduğu merkezi katmandır. İf'ler burada yazılır. 
- Servis nesnesi iş tarafında yazacağımız operasyonların implementasyonlarını içeren yapıdır. İlk etapta interface kurulur.
- Validasyon yönetimi, loglamalar bu katmanda yapılır. 
- Veritabanından kaynaklı hata yönetimleri ayrı ayrı geliştirerek bu katmanda işlenir. WepAPI veya UI katmanları tarafından bu handel edilir.
- Bağımlılıkların çözümü burada yapılır. Klasörlenen teknoloji içerisinde bağımlılık konfigürasyonu yapılır. Örneğin WebAPI startup içerisinde instance konfigurasyon yapılanmasını bu katmana bağlı kalmamak adına dahada geriye çekerek katmanlı mimari içerisinde Business katmanında gerçekleştirilir.

### 📚 WebAPI Katmanı
Yeni modern ve popüler geliştirme ortamıdır. Farklı client'lar ile backend katmanlı mimarinin arasında data yönetimi için iletişim kurulmasını sağlar. WepApi'de RestFul(Json vb.) Mimarisi gibi Standartları bulunur. Servise client'lardan istek (Request) yapılır. Ör: Şu kategorideki ürünleri getir. Yanıt olarakta Response veilir. Microsoft tafında bu mimari ASP.NET WebAPI'dır. Test ortamı olarak Postman kullanılabilinir. Controller isimlendirmeleri çoğul yapılır. Bu MVC'de tekil olmasına dikkat edilir.Ataptor servis paterni görevi görür.

### 📚 UnitTest Katmanı
...

### 📚 UI Katmanı
- Bir kullanıcıya birşeyler göstermek. Kullanıcıdan bilgi almak kısacası kullanıcı ile yapılan her etkileşim bu katmanın işidir. Yazılımın Frontend kısmına karşılık gelir. Diğer katmanlar Backend kısmını oluşturur.
- Bir kaç metot sadeleştirmesi, yeniden adlandırma, kendini tekrar etme yaklaşımı gibi benzer operasyonel metod veya sınıf yeniden yapılandırımı (refactoring) işlemleri yürütülür. Oluşturulan kod blokları tekrar tekrar kullanılır.
- Hata yönetimi arayüzün işi değildir. Try catch ile sadece hatayı nasıl göstereceğiyle ilgilenir.

### 📚 Servis Tabanlı Mimari
...

Bir katman bir katmanı new'leyemez. Çünkü projeler büyüdükçe onlarca sayfa içinde bağımlılıkları değiştirmek güçleşir.
New'lemeler için .NET CORE içerisinde IoC Container amacı ile MVC tarafında implementasyonlar var. Fakat Backend'de bizim yine IoC Containerlardan destek vermemiz gerekiyor. Çünkü Microsoft teknolojileri sadece kendi yapıları-frameworkleri tanıyacak şekildedir. Bizim oluşturduğumuz katmanlar için ayrıca IoC container'ler sisteme tanımlamamız gerekir. Ayrıca WepApi yaptığımızda MVC yapısının içinde kalan IoC Container işimize yaramayacaktır.



## 📌 Programcının Katmanlı Mimari içinde ki Adımları

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

## 📌 DRY "Don't Repeat Yourself" Prensibinin Avantajları
- Tekrar Kullanılabilirlik (reusability)
- Okunaklılık (Readability)
- Sürdürülebilirlik (Maintainability)
- Test Edilebilirlik (Testing)
OOP bu konuda yardımcıdır. Kendini tekrar etmemek, aynı şeyi defalarca yazmamak. Sık kullandığımız kodları, library’lere taşırız yeri geldimi yine bu library’lerimizi kullanarak belli bir işe özel framework’ler yazarız. Object Oriented diller de bize bu konuda oldukça yardımcı olurlar. Bir süre sonra yazdığımız kodların anlaşılabilirliği ve maintainability(bakım yapılabilirlik)’si düşmekte. Aspect-Oriented Programming bu noktada bize yardımcı olmakta. AOP’un en büyük hedefi modularity’i arttırmak ve Cross-Cutting Concern’lerimiz arasındaki ayrımı daha net sağlamaktır.



## 📌 Not
### İmplemente:
İnterface'ler implementasyon
### İnherit:
Abstract Class'lar ve Normal Class'lar inheritince'dır.





## 📌 Ek Bilgiler
- VS çok kullandığımız bloklar varsa sağ tıklayıp sinppet oluşturabilinir.
- Kodları düzenlemek için Ctrl+K , Ctrl+D

## 📌 Referans Kaynakça
- [Temel C#](https://www.w3schools.com/cs/default.asp)
- [kodlama.io](https://www.kodlama.io/)
- [YouTube](https://www.youtube.com/channel/UCRjiquPh4mjPNoOV9eCilXQ) - Engin DEMİROĞ Videoları
- [C# - btkakademi](https://www.btkakademi.gov.tr) - Engin DEMİROĞ C#
- [Udemy](https://www.udemy.com/courses/search/?src=ukw&q=%22engin+demiro%C4%9F%22) - Engin DEMİROĞ Eğitim Serileri
- [Clean Code](https://www.amazon.com.tr/Clean-Code-Handbook-Software-Craftsmanship/dp/0132350882) - Robert C. Martin
- [DevArchitecture](https://www.devarchitecture.net/)
