/// Olabilecek atlama sayıları içerisinde en kısa olanı bulmamız isteniyor.
/// Her defasında en fazla 2 sıra atlayabilir. Yani dizi içerisinde 1. eleman ise
/// en fazla tek seferde 3. elemana zıplayabilir.
/// Bu durumda her eleman kendi sırasının 2 ilerisini kontrol edecek. Eğer ki 1 değil ise
/// oraya atlayabilir. 1 ise o zaman bir gerisine atlayacak.
/// Atlarken de bir sayaç tutabiliriz.

// Greedy Pattern

// 8/8 başarılı test sonucu
int jumpingOnClouds(List<int> c)
{
    int n = c.Count;
    int jump = 0;
    int i = 0;

    while (i < n - 1)
    {
        if (i + 2 < n && c[i + 2] == 0)
        {
            i += 2;
        }
        else
        {
            i++;
        }
        jump++;
    }

    return jump;
}

/* Jumping On Clouds

Ardışık olarak numaralandırılmış bulutlarla başlayan yeni bir mobil oyun var. 
Bulutların bazıları gök gürültüsü başları, diğerleri ise kümülüstür. 
Oyuncu, mevcut bulutun numarası artı 1 veya 2'ye eşit bir numaraya 
sahip herhangi bir kümülüs bulutunun üzerine atlayabilir. 
Oyuncu gök gürültülü bulutlardan kaçınmalıdır. 
Başlangıç konumundan son buluta atlamak için gereken minimum atlama sayısını belirleyin. 
Oyunu kazanmak her zaman mümkündür.

Her oyun için, güvenli ise 0,
kaçınılması gerekiyorsa 1 ile numaralandırılmış 
bir dizi bulut elde edeceksiniz.
*/