/// En başta gönderilen s değeri sadece a ise n değerini döndürmemiz lazım. Stringleri uzun döngüler halinde
/// yazmak ciddi performans isteyecek ve hesaplamalar uzun sürecektir. Bunun için en önce verilen s değerinde kaç adet a 
/// olduğunu hesaplamamız lazım. Aynı zamanda s değerinin uzunluğunu almamız lazım.
/// Verilen n değerini s'in uzunluğuna bölersek kaç defa oluşabileceğini bulabiliriz. Bu çıkan değeri a'nın
/// sayısı ile çarparsak toplam kaç a olduğunu bulabiliriz. Ama bu sayı tam çıkmayabilir. geri kalanları da bulmak için
/// n'nin string uzunluğuna bölümünden kalan sayıyı alırız. Bu sayı kadar s değeri vardır demektir.
/// Yani geri kalan 3 karakterli bir s varsa içinde ki a değerlerini de alıp sayaca eklememiz lazım.

// Tüm case'leri başarı ile tamamladı.
public static long repeatedString(string s, long n)
{
    if (s == "a")
        return n;

    long lengthOfS = s.Length;

    // Linq ile sayıyı hesapladık
    long countOfA = s.Count(c => c == 'a');

    // Manuel hesaplama
    //foreach (char c in s)
    //{
    //    if (c == 'a')
    //        countOfA++;
    //}

    long repeatedCount = (n / lengthOfS) * countOfA;

    long remainder = n % lengthOfS;
    for (int i = 0; i < remainder; i++)
    {
        if (s[i] == 'a')
            repeatedCount++;
    }

    return repeatedCount;
}

// Input: aab - 882787
// Output 588525

/* Repeated String

Sonsuz sayıda tekrarlanan küçük İngilizce harflerden oluşan bir s dizisi vardır. 
Bir tamsayı, n, verildiğinde, bulun ve Sonsuz dizenin ilk n harfindeki a 
harflerinin sayısını yazdırır.

Örneğin:
s = "abcac"
n = 10

Ele aldığımız alt dize, sonsuz dizenin ilk 10 karakteri olan abeacabeac'tir. 
İçinde a'nın 4 geçişi vardır alt dize.

Fonksiyon Açıklaması:
Aşağıdaki düzenleyicide repeatedString işlevini tamamlayın. 
repeatedString aşağıdaki parametre(ler)e sahiptir: 
- s: tekrarlanacak bir dize 
- n: dikkate alınacak karakter sayısı

Dönüş:
- int: a'nın alt dizedeki sıklığı

Giriş Biçimi

İlk satır tek bir dize içerir, s.
İkinci satır bir tamsayı, n, içerir.

Örnek input:
aba
10

Örnek Çıktı:
7

Sorudan Anladığım:
Verilen harfleri verilen sayı kadar yazdırıp, kaç adet a içerdiğini bizden bulmamız isteniyor.
Örneğin aba 10 verildiği zaman abaabaabaa şeklinde arka arkaya 10 harf olana kadar yazdırdık.
Ve içinde 7 adet a harfi mevcut.
*/