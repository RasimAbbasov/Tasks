//stringe cevirmekle

//int[] array = { 61, 77, 26, 1, 124, 8720 };
//int max = array[0];
//string num;
//for (int i = 1; i < array.Length; i++)
//{
//    if (max < array[i])
//    { max = array[i]; }

//}
//num = max.ToString();
//Console.WriteLine(num.Length + " reqemlidir");



//while ile

int[] array = { 61, 77, 26, 1, 124, 8720 };
int max = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (max < array[i])
    { max = array[i]; }

}
int count = 0, temp;
while (max != 0)
{
    temp = max % 10;
    max /= 10;
    count++;
}
Console.WriteLine(count + " reqemlidir");