Console.WriteLine("Hello, World!");

int n = 1;

for (int i = 0; i < n; i++) Console.WriteLine("NUMBER " + i);

if(n >= 10) Console.WriteLine("N is grater or equal than 10");
else Console.WriteLine("N is smaller than 10");

switch (n)
{
    case 1: {
        Console.WriteLine("Hello");
        break;
    }
    case 2: {
        Console.WriteLine("Bye");
        break;
    }
    default: {
        Console.WriteLine("Invalid input!");
        break;
    }
}

static double CalculateAverage(int[] array)
{
    double sum = 0;
    foreach (var i in array)
    {
        sum += i;
    }
    return sum / array.Length;
}

Console.WriteLine(CalculateAverage(new int[]{4, 3, 2, 7, 9, 4}));

static double FindMax(int[] array)
{
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }

    return max;
}

Console.WriteLine(FindMax(new int[]{4, 3, 2, 7, 9, 4}));

    
