/// Kaç adım aşağı kaç adım yukarı çıktığını hesaplayarak hangi seviyede olduğunu keşfedebiliriz.
/// Deniz seviyesinin aşağısına inmesi vadiye indiği anlamına gelir
/// Her deniz seviyesinden aşağı inişi ve tekrar çıkışı bir vadi sayılıyor
/// Bu durumda kaç defa deniz seviyesine ÇIKTIĞINI öğrenmemiz lazım.
/// Sayaç mantığında gitmemiz lazım. Yani yukarı çıktıkça eksilen, 
/// aşağı indikçe de artan bir sayaç
/// Vadi ve dağ değerlerini ayrı değişkenlerde tutmamız gerekir

// 21/21 Başarılı test sonucu
public static int countingValleys(int steps, string path)
{
    int valleys = 0;
    int mounth = 0;
    List<char> stepList = new List<char>();
    for (int i = 0; i < steps; i++)
    {
        stepList.Add(path[i]);
    }

    foreach (char c in stepList)
    {
        if (c == 'U')
        {
            mounth++;
            if (mounth == 0)
            {
                valleys++;
            }

        }
        else
        {
            mounth--;
        }
    }
    return valleys;
}

/* Counting Valleys

Örneğin:
12 - DDUUDDUDUUUD (2 Vadiye giriyor.)
_          /\_
 \  /\    /
  \/  \/\/
Hevesli bir yürüyüşçü, 
yürüyüşlerinin titiz kayıtlarını tutar. 
Son yürüyüş sırasında tam olarak adımlar atılmıştır. 
Her adım için yokuş yukarı, U veya yokuş aşağı, 
D adımı olduğu not edilmiştir. Yürüyüşler her zaman 
deniz seviyesinde başlar ve biter ve her yukarı 
veya aşağı adım rakımda 1 birimlik değişikliği temsil eder. 
Aşağıdaki terimleri tanımlıyoruz: 

- Dağ, deniz seviyesinden yukarı doğru bir adımla 
başlayıp deniz seviyesine doğru bir adımla biten, 
deniz seviyesinin üzerindeki ardışık adımlar dizisidir. 

- Anvalley, deniz seviyesinden aşağı doğru bir adımla 
başlayıp deniz seviyesine doğru bir adımla biten, 
deniz seviyesinin altındaki ardışık adımlar dizisidir. 

Bir yürüyüş sırasında yukarı ve aşağı 
adımların sırası göz önüne alındığında, 
yürünen vadi sayısını bulun ve yazdırın.

Aşağıdaki düzenleyicide countingValleys 
işlevini tamamlayın. 

CountingValleys aşağıdaki parametreye sahiptir

int adımlar: yürüyüşteki adım sayısı
string path: yolu tanımlayan bir dize

Sorudan anladığım:
Yokuş yukarı adımlara U deniyor.
Yokuş aşağı adımlara D deniyor.
Yürüyüşler deniz seviyesinde başlayıp bitiyor.

Bizden istenen verilen değerlere göre kaç adet vadiye girip gimediğini hesaplamaktır.
*/