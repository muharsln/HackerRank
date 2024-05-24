/// Console'dan gelen input'u ekrana yazdır.

// 2/2 Başarılı
class Solution {
    static void Main(String[] args) {
        // Declare a variable named 'inputString' to hold our input.
        String inputString; 
        
        // Read a full line of input from stdin (cin) and save it to our variable, input_string.
        inputString = Console.ReadLine(); 
        
        // Print a string literal saying "Hello, World." to stdout using cout.
        Console.WriteLine("Hello, World.");
        
        // TODO: Write a line of code here that prints the contents of input_string to stdout.
        Console.WriteLine(inputString);
    }
}

/* Hello World

İlk satırda, Merhaba, Dünya... dizesini yazdırıyoruz. İkinci satırda, aşağıdaki dizelerin içeriğini yazdırırız inputString değişkeni, bu örnek durum için, 30 Günlük Koda Hoş Geldiniz! 
değişkenin içeriğini stdout'a yazdırırsanız, gizli test durumunu geçemezsiniz.
*/