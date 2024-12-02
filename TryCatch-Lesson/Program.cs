using System.Linq.Expressions;

namespace TryCatch_Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter a number : ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Sonuc : {10 / x}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("sayı 0'a bölünemez");
            }
            catch (FormatException)
            {
                Console.WriteLine("Geçersiz format girişi yaptınız");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bilinmeyen hata" + ex.Message);
            }

            /*
             * Bir sinema bilet satis programi yapilmak isteniliyor. Bu programda oncellikle kullanicidan yasi aliniyor ve 
             * yasina gore hangi sinemaya uygun oldugu gosteriliyor ve ona uygun bir fiyat cikartiliyor
             * fakat kullanici yasini yazi ile girerse sistem uyari mesaji gosterecek. En sonda da tesekkur ederiz yazilacaktır.
             * c# ile bu programi yaziniz (try-catch)
             * 0-100 yaş aralığına göre kodlama yapılacaktır.Bunlardan büyük değer girilirse eğer Lütfen geçerli bir yaş giriniz uyarısı gelecektir.
             * (formatexception)
             * 3-12 yaş : Çocuk kategorisi
             * 13-24 yaş: Genç kategorisi
             * 25-63 yaş: Yetişkin Kategorisi
             * 64 ve üzeri Yaşlı kategorisinde yer alacaktır. 
             * çok büyük veya çok küçük sayı değerleri girilmek istenirse hata versin
             */

            try
            {
                int yas = int.Parse(Console.ReadLine());
                if (yas < 0 || yas > 100)
                {
                    throw new ArgumentOutOfRangeException("Geçersiz yaş girildi");
                }
                if (yas <= 12)
                {
                    Console.WriteLine("Çocuk kategorisi. Bilet fiyatınız 30TL");
                }
                else if (yas <= 24)
                {
                    Console.WriteLine("Genç kategorisi. Bilet fiyatınız 50TL");
                }
                else if (yas <= 63)
                {
                    Console.WriteLine("Yetişkin kategorisi. Bilet fiyatınız 70TL");
                }
                else
                {
                    Console.WriteLine("Yaşlı kategorisi. Bilet fiyatınız 40TL");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Geçersiz veri girişi");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("0 ile 100 dışarısında bir veri girildi");
            }
            catch (OverflowException)
            {
                Console.WriteLine("int değerleri dışında bir sayı girildi");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Bir hata oluştu: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Beni beni, Rojbini tercih ediceksin tabi hadsiz. Kendine gel");
            }

        }
    }
}
