//17'den kicik reqemlerin cemi.

int toplanan=0;
int sayi = 17;

for (int i = 1; i < sayi; i++)
{
    toplanan += i;
    Console.WriteLine(toplanan);
}

//i=1
//toplanan=0+1=1
//i=1+1=2
//toplanan=1+2=3
//i=2+1=3
//toplanan=3+3=6
//i=3+1=4
//toplanan=6+4=10
//....
//...
//..
//.