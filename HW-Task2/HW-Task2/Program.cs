//Daxil olunan ededin factorialini tapmaq.

int vurulan = 1;

int regem = 6;

for (int i = regem; i > 1; i--)
{
    vurulan *= i;
    Console.WriteLine(vurulan);
}

//regem=14 (0. indeks)
//vurulan=1*14=14
//regem=14-1=13 (1. indeks)
//vurulan=14*13=182
//regem=13-1=12 (2. indeks)
//vurulan=182*12=2,184
//...
//..
//.