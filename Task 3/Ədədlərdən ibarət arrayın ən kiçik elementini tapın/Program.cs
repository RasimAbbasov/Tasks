int[] nums = { 12, 32, 3452, 95, 10, 213, 49, 982, 123, 78231, 125381 };
int min = nums[0];
for (int i = 0; i < nums.Length; i++)
{
    if (min > nums[i]) { 
    min =nums[i];
}
}
Console.WriteLine(min);
