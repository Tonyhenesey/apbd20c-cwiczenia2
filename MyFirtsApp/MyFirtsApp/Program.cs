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
