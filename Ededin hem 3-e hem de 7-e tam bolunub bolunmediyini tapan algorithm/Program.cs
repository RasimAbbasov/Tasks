Console.WriteLine("Ededi daxil et:");
int x = Convert.ToInt32(Console.ReadLine());
if (x % 3 == 0 && x % 7 == 0)
{
    Console.WriteLine("Eded hem 3-e hem de 7-e tam bolunur");
}
else if (x % 3 == 0)
{
    Console.WriteLine("Eded yalniz 3-e bolunur");
}
else if (x % 7 == 0)
{
    Console.WriteLine("Eded yalniz 7-e bolunur");
}
else 
{
    Console.WriteLine("Eded ne 3-e ne de 7-e bolunur");
}