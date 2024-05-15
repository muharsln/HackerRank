/// Gelen n değeri 1 den küçük yada 100 den büyük ise null döndürmeli
/// Listedeki tüm elemanları alıp kıyas etmem lazım
/// Aynı olanların birbirini götürmesi kalanların da sayısının döndürülmesi lazım

// 8/8 Başarılı test sonucu
public static int sockMerchant(int n, List<int> ar)
{
    if (n < 1 || n > 100)
        return 0;

    int result = 0;
    var list = new List<int>();

    foreach (var color in ar)
    {
        if (!list.Contains(color))
        {
            list.Add(color);
        }
        else
        {
            result++;
            list.Remove(color);
        }
    }
    return result;

    /** Eski Çözüm
    List<int> arr = new List<int>();
    int index;

    for (int i = 0; i < ar.Count; i++)
    {
        arr.Add(ar[i]);
    }

    for (int i = 0; i < n - 1; i++)
    {
        index = 0;
        for (int j = 0; j < arr.Count; j++)
        {
            if (ar[i] == arr[j]) index++;

            if (index >= 2)
            {
                arr.Remove(arr[j]);
                arr.Remove(ar[i]);
                index = 0;
                j = 0;
            }

        }
    }
    return arr.Count;
    */
}
/* Sales by Match
    Renklerine göre eşleştirilmesi gereken büyük bir çorap yığını var. 
    Her çorabın rengini temsil eden bir tamsayı dizisi verildiğinde, 
    eşleşen renklere sahip kaç çift çorap olduğunu belirleyin.

    Örneğin:
    n = 7
    ar = [1, 2, 1, 2, 1, 3, 2]
    Bir çift renk 1 ve bir çift renk 2 var. Her renkten birer tane olmak üzere üç tek çorap kaldı. Çift sayısı 2'dir

    Fonksiyon Açıklaması:
    Aşağıdaki düzenleyicide sockMerchant işlevini tamamlayın.
    sockMerchant aşağıdaki parametre(ler) sahiptir:
        - int n: yığındaki çorap sayısı
        - int ar[n]: her bir çorabın 
        
    Geri dönüşler 
        - int: çift sayısı

    Giriş Biçimi 
    İlk satır, ar'de temsil edilen çorap sayısı olan bir n tamsayısı içerir.
    İkinci satır n adet boşluk bırakılarak ayrılmış tamsayı içerir, arli]. yığındaki çorapların renkleri.

    Kısıtlamalar
        1<= n <=100
        1<= ar[i] <=100 where 0<=i<n

    Sorudan anladığım:
    Verilen dizide bir elemanın aynısından varsa yani çifri varsa birbirini götürür. Geriye çifti olmayanların sayısı döndürülür.
*/