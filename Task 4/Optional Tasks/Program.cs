#region Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın.
int n = Convert.ToInt32(Console.ReadLine());
if (n % 3 == 0 && n % 7 == 0)
    Console.WriteLine(n + " 3-e ve 7-e tam bolunur");
else if (n % 3 == 0)
    Console.WriteLine(n + " Yalniz 3-e tam bolunur");
else if (n % 7 == 0)
    Console.WriteLine(n + " Yalniz 7-e tam bolunur");
else
    Console.WriteLine("Eded hec birine tam bolunmur");
#endregion
#region Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapin.
//int n = Convert.ToInt32(Console.ReadLine());
//int m = Convert.ToInt32(Console.ReadLine());
//int count = 0;
//while(n<=m)
//{ 
//    if (n % 2==1) 
//        count++;  
//    n++;
//}
//Console.WriteLine(count);
#endregion
#region Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin.
//int n = Convert.ToInt32(Console.ReadLine());
//int m = Convert.ToInt32(Console.ReadLine());
//int sum = 0;
//while (n <= m)
//{
//    if (n % 2 == 1)
//        sum += n;
//    n++;
//}
//Console.WriteLine(sum);
#endregion
#region Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.
//int n = Convert.ToInt32(Console.ReadLine());
//int count = 0;
//for (int i = 1; i <= n; i++)
//{
//    if (n % i == 0)
//        count++; 
//}
//    if (count == 2)
//    {
//        Console.WriteLine("Eded sadedir");      
//    }
//    else if (count > 2)
//    {
//        Console.WriteLine("Eded murekkebdir");
//    }
//    else
//        Console.WriteLine("Eded duzgun daxil edilmeyib");

#endregion
#region Verilmish arrayin icindeki cut ededlerin cemini tapin.
//int[] array = { 29, 67, 28, 90, 12, 25, 61 };
//int sum = 0;
//for (int i = 0;i< array.Length; i++)
//{
//    if (array[i] % 2 == 0)
//    {
//        sum += array[i];
//    }
//}
//Console.WriteLine(sum);
#endregion