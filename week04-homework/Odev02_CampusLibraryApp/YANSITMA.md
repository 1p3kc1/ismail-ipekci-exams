# YANSITMA

 1. Encapsulation'ı nerede kullandınız?

Encapsulation'ı Book ve Member sınıflarında kullandım.
Book sınıfında AvailableCopies değerinin dışarıdan doğrudan değiştirilmesini engelledim.
Stok değişikliklerini Borrow() ve Return() metotları üzerinden yaptım.
Member sınıfında aktif ödünç kitaplar, son teslim tarihleri ve renew bilgilerini sınıf içinde yönettim.
Üyeliği kapatmak için CloseMembership() metodunu kullandım.

 2. Polymorphism'i nerede kullandınız?

Polymorphism'i Member sınıfı ve ondan türeyen StudentMember,
AcademicMember ve GuestMember sınıflarında kullandım.
LibraryService, üyenin hangi tür olduğunu kontrol etmek yerine Member üzerinden çalışmaktadır.
MaxBooks, LoanPeriodDays ve CalculateLateFee() gibi davranışlar
her üye tipinde farklı şekilde çalışmaktadır.

 3. Interface kullanmak size ne kazandırdı?

IRepository<T> ve ILoanLogger interface'lerini kullanarak
LibraryService'i somut sınıflara bağımlı olmaktan kurtardım.
Böylece veri saklama veya loglama yöntemi değiştirildiğinde
LibraryService'in değiştirilmesine gerek kalmaz.
Bu yapı kodun daha esnek ve test edilebilir olmasını sağlar.

4. GuestMember eklerken hangi dosyalara dokundunuz / dokunmadınız? Neden?

GuestMember eklerken GuestMember.cs dosyasını oluşturdum
ve Program.cs içerisinde GuestMember'ı sisteme dahil ettim.
LibraryService.cs içerisinde GuestMember için özel bir if/else zinciri oluşturmadım.
Çünkü LibraryService Member sınıfı üzerinden polymorphism ile çalışmaktadır.
Bu sayede yeni bir üye tipi eklenirken çekirdek servis kodunu değiştirmeye gerek kalmadı.