//Verilmish 2 mertebeli ededin en boyuk reqemini tapan algorithm misal
int y, z;
int x = Convert.ToInt32(Console.ReadLine());
if (x >= 10 && 100>x)
{
    y = x / 10;
    z = x % 10;
    if(y>z)  {Console.WriteLine(y);}
    else if(y<z) {Console.WriteLine(z);}
    else
    {Console.WriteLine(y);} 
}
else
{ Console.WriteLine("Eded 2 mertebeli deyil");}