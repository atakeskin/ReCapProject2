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
En kaba tabir ile bir kadman diğer katmanı new'leyemez. Bağımlılıklar artar. Bu olay micro servis yazımına kadar gider. İş katmanında başka bir iş katmanını dahi newlememesiniz.

## KURALLAR
### Hangi teknolojiyi kullanıyorsak onunla ilgili Concrete klasörü altına klasör açılır.
İçindeki dosyalar bu klasörleme yapısı ile Namespace adı verilir.
### Çıplak Class kalmasın. Bir Class'ın base'inin veya iplementasyonunun olması gerekir.
