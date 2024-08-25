//Verilmish ededin 2-nin quvveti olub olmadigini tapan alqoritm misal: 8 quvvetidir, 6 quvveti deyil
int x = Convert.ToInt32(Console.ReadLine());
if (x <= 0)
{
    Console.WriteLine("Melumat duzgun deyil");
}
while (x % 2 == 0)
{
    x /= 2;
}
if (x == 1)
    Console.WriteLine("Quvvetidir");
else
    Console.WriteLine("Quvveti deyil");
    