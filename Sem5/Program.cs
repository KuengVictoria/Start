//Семинар5 Задача1 Задать массив заполненный случайными положительными
// трехзначными числами. Написать программу, которая покажет колличество
// четных чисел в массиве

/*int [] CreateRandomArray (int size, int a, int b)
{
    int [] array = new int [size];
    for(int i = 0; i < size; i++)
    array [i] = new Random().Next(a,b);
    return array;
}

void ShowArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array [i] + " ");
    
    Console.WriteLine();    
}

int FindNumbersCount(int []array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    if(array[i] % 2 == 0)
    count ++;
    return count;
}

Console.WriteLine("Enter the size of the array: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter a of array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter b of array: ");
int b = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateRandomArray(n, a, b);

ShowArray(myArray);
int numbersCount = FindNumbersCount(myArray);
Console.WriteLine($"Sum of even numbers is " + numbersCount);
*/

// Задача2 Задать одномерный массив, заполненный случайными числами.
// Найти сумму элементов, стоящих на нечетных позициях.

/*int [] CreateRandomArray (int size, int a, int b)
{
    int [] array = new int [size];
    for(int i = 0; i < size; i++)
    array [i] = new Random().Next(a,b);
    return array;
}
void ShowArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array [i] + " ");
    
    Console.WriteLine();    
}
int FindNumbersSum(int []array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i = i +2)
    
    sum += array [i];
    return sum;
}

Console.WriteLine("Enter the size of the array: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter a of array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter b of array: ");
int b = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateRandomArray(n, a, b);

ShowArray(myArray);
int numbersSum = FindNumbersSum(myArray);
Console.WriteLine($"Sum of even numbers is " + numbersSum);
*/

//Задача3 Задать массив вещественных чисел. Найти разницу между 
//максимальным и минимальным элементов массива.

/*double [] Array = {3, 4, 7, 9, 3.2, 17};

void PrintArray(int [] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
        Console.Write($"{array[i]}");
    
    Console.WriteLine();    
}
double FindDifference(int []array)
{
    int max = 0;
    int min = 0;
    int dif = 0;
    for(int i = 0; i < array.Length; i++)
       if(array[i] > max)
       array[i] = max;       
       for(int i = 0; i < array.Length; i++)
       if(array[i] < min)
       array[i] = min;
       dif = max - min;

       return dif;
}

PrintArray(Array);
int dif = FindDifference(Array);
Console.WriteLine($"Difference is " + dif);
*/