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
            
            #region Soru 2
            /* 
             * Bir bankacılık uygulamasında kullanıcı giriş bilgilerini kontrol eden bir program yazın. 
             * Kullanıcı 3 defa yanlış bilgi girerse hesap kilitlensin, her yanlış denemede uyarı mesajı verilsin.
             */
            String user = "admin";
            String pass = "12345";
            int attemptCount = 0;
            int maxAttempt = 3;
            while (attemptCount < maxAttempt)
            {
                try
                {
                    Console.WriteLine("Kullanıcı adını giriniz");
                    String username = Console.ReadLine();
                    Console.WriteLine("Şifrenizi giriniz");
                    String password = Console.ReadLine();
                    if (username != user || password != pass)
                    {
                        attemptCount++;
                        Console.WriteLine($"Hatalı giriş. Kalan deneme hakkınız: {maxAttempt - attemptCount}");
                        if( attemptCount == maxAttempt )
                        {
                            throw new Exception("Maximum hatalı giriş sayısı");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Giriş Başarılı");
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Maximum hatalı giriş sayısına ulaştınız. Lütfen Rojbin'le görüşün ona yalvarın");
                }
            }
            #endregion
                
            #region Kullanıcıdan kelime girmesini isteyen ve bu kelimeyi tersten yazan döngü (for ile)
            //String word = Console.ReadLine();
            //for(int i = word.Length-1; i>=0; i--)
            //{
                //    Console.Write(word.ElementAt(i));
            //}
            //Console.WriteLine("\nikinci kelime");
            //String word2 = Console.ReadLine();
            //for (int i = word2.Length - 1; i >= 0; i--)
            //{
                //    Console.Write(word2[i]);
            //}
            #endregion

            #region Kullanıcı tarafından girilen 10 sayıdan kaç tanesinin 3 basamaklı olduğunu bulan program
            //int count = 0;
            //for (int i = 1; i<=10; i++)
            //{
            //    Console.WriteLine(i + ". sayıyı giriniz");
            //    int j = int.Parse(Console.ReadLine());
            //    if (j>=100 && j<=999)
            //        count++;
            //}
            //Console.WriteLine("3 basamaklı sayıların adeti " + count);

            //int count2 = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i + ". sayıyı giriniz");
            //    int j = int.Parse(Console.ReadLine());
            //    string jString = j.ToString();
            //    if (jString.Length == 3)
            //    {
            //        count2++;
            //    }
            //}
            //Console.WriteLine("Girilen 3 basamaklı sayıların adeti : " + count2);
            #endregion
        }
    }
}
