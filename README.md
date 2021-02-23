# Northwinder
Engin Demiroğ Youtube Yazılım Geliştirici Kampındaki projenin aynısı ya da bir benzerinin yapılması amaçlanmaktadır.

Projede veritabanı ile proje arasındaki bağlantının kurulması için EntityFramework kullanılmaktadır. 


Katmanlar:

  ProjectWebApi ---> Web Api bulunan kısım

  Entities ---> Veritabanındaki tablolaların C#'da modellemesinin yapıldığı kısım.

  DataAccess --->  Veritabanı işlemlerini gerçekleştiren sınıfların bulunduğu kısım.

  Core ---> Veritabanı ve diğer işlemlerde kullanılabilen fakat genel yapı olarak her türlü projeye entegre edilecebilecek tipte olan generic sınıfların bulunduğu kısım.

  Business---> Ekleme,çıkarma ve listeleme gibi işlemlerin koşullara bağlı olarak gerçekleştirilmesi için oluşturulan iş katmanı
  

Not:Sql'de kullanılan veritabanı ve  datalarını https://github.com/Microsoft/sql-server-samples/tree/master/samples/databases/northwind-pubs 'da bulabilirsiniz
