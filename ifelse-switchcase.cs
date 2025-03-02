int time = DateTime.Now.Hour;

if (time >= 6 && time < 11)
    Console.WriteLine("Günaydın!");

else if (time <= 18)
    Console.WriteLine("İyi Günler!");

else
    Console.WriteLine("İyi Geceler!");

string sonuc = time < 18 ? "İyi Günler!" : "İyi Geceler!";

sonuc = time >= 6 && time < 11 ? "Günaydın!" : time <= 18 ? "İyi Günler!" : "İyi Geceler!";

Console.WriteLine(sonuc);




int gun = 3;

        switch (gun)
        {
            case 1:
                Console.WriteLine("Pazartesi");
                break;
            case 2:
                Console.WriteLine("Salı");
                break;
            case 3:
                Console.WriteLine("Çarşamba");
                break;
            default:
                Console.WriteLine("Geçersiz gün!");
                break;
        }

char harfNotu = 'B';

        switch (harfNotu)
        {
            case 'A':
                Console.WriteLine("Mükemmel!");
                break;
            default:
                Console.WriteLine("Geçersiz not!");
                break;
            case 'B':
                Console.WriteLine("İyi!");
                break;
            
            case 'C':
                Console.WriteLine("Orta!");
                break;
            
        }  

int a = 10, b = 5;
        char islem = '+';

        switch (islem)
        {
            default:
                Console.WriteLine("Geçersiz işlem!");
                break;
            case '+':
                Console.WriteLine(a + b);
                break;
            case '-':
                Console.WriteLine(a - b);
                break;
            case '*':
                Console.WriteLine(a * b);
                break;
            case '/':
                Console.WriteLine(a / b);
                break;
            
        }              