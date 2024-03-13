// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Modification1");
Console.WriteLine("Modification 2");
Console.WriteLine("Modification 3");

static double GetAverage(int [] numbers)
{
    double counter = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        
        counter += numbers[i];
        
    }

    return counter / numbers.Length;

}

int[] numbers = {1,2,3,4};
double average = GetAverage(numbers);
Console.WriteLine(average);

Console.WriteLine("Modyfikacja testowa");

static int GetMax(int[] nums)
{
    
    int tmp = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i]>nums[tmp])
        {
            nums[tmp] = nums[i];
        }
    }

    return nums[0];
}
int max = GetMax(numbers);
Console.WriteLine("Max wartość: " + max);