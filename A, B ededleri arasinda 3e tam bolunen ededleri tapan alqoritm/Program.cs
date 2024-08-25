//A, B ededleri arasinda 3e tam bolunen ededleri tapan alqoritm
int a=Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
while (a <= b)
{
    if (a % 3 == 0)
        Console.WriteLine(a);
    a++;
}




