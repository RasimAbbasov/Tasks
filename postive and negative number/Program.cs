//Verilmish ededin menfi ve ya musbet oldugunu tapan algorithm
int x = Convert.ToInt32(Console.ReadLine());
if (x > 0)
{
    Console.WriteLine("Eded musbetdir");
}
else if (x < 0)
{
    Console.WriteLine("Eded menfidir");
}
else
{
    Console.WriteLine("Eded ne musbet ne menfi ededdir");
}