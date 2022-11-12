
int DER = 8;
int QuvvetiYR = 2;

for (int i = DER; i >= QuvvetiYR; i /= QuvvetiYR)
{
    Console.WriteLine(i);

    if (i % QuvvetiYR == 0)
    {
        Console.WriteLine("bolunur");
    }
    else if (i % QuvvetiYR != 0)
    {
        Console.WriteLine("bolunmur");
    }
    else
    {
        Console.WriteLine("reqem daxil et");
    }
}