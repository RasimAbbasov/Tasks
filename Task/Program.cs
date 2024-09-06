#region Verilmiş 3 ədəddən hansının ən böyük olduğunu tapan proqram
int a, b, c;
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (max < b) max = b;
if (max < c) max = c;
Console.WriteLine(max);
#endregion


#region Verilmiş yazının içində A hərfinin olub olmadığını tapan proqram
//string word = Console.ReadLine();
//bool result = false;
//for (int i = 0; i < word.Length; i++)
//{
//    if (word[i] == 'A')
//    {
//        result = true;
//        break;
//    }
//}
//if (result)
//{
//    Console.WriteLine("A herfi var");
//}
//else
//{
//    Console.WriteLine("A herfi yoxdur");
//}
#endregion


#region Verilmiş yazıda neçə A hərfinin olduğunu tapan proqram
//string word = Console.ReadLine();
//int count=0;
//for (int i = 0; i < word.Length; i++)
//{
//    if (word[i] == 'A')
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);
#endregion


#region Verilmiş müsbət cüt ədədi kvadrata yüksəldən proqram
//int a = Convert.ToInt32(Console.ReadLine());
//if (a > 0 && a % 2 == 0){
//    a *= a;
//    Console.WriteLine(a);
//}
//else
//{
//    Console.WriteLine("Eded uygun deyil");
//}
#endregion


#region Daxil edilən ədəd musbət və cüt olmadıqca yenidən daxil edilməlidir
//int a;
//bool result=false;
//do
//{
//    a = Convert.ToInt32(Console.ReadLine());
//    if (a > 0 && a % 2 == 0)
//    {
//        result = true;
//        Console.WriteLine("Eded musbet ve cutdur");
//    }
//}
//while (!result);
#endregion


#region Verilmiş 5 uzunluqlu ədədlər siyahısındaki ədədlərin cəmini tapan proqram
//int[] array = { 12,29,58,54,10};
//int sum=0;
//for (int i = 0; i < array.Length; i++)
//{
//    sum+= array[i];
//}
//Console.WriteLine(sum);
#endregion


#region Verilmiş təhsil növü dəyərinə əsasən o təhsilin saatını göstərən proqram
//string answer=Console.ReadLine();
//if (answer == "programming")
//{
//    Console.WriteLine("400 saat");
//}
//else if (answer == "design")
//{
//    Console.WriteLine("250 saat");
//}
//else if(answer == "system")
//{
//    Console.WriteLine("200 saat");
//}
//else
//{
//    Console.WriteLine("Tehsil novu yanlisdir");
//}
#endregion