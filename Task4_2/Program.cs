// Another solution to the task
Console.Clear();

int i = 0; // entering a variable
int maxNumbers = -2147000000; // entering the min value
while (i < 3) // how many numbers should the user enter
{
    Console.Write("Введите число: "); 
    int n = Convert.ToInt32(Console.ReadLine());
    if (maxNumbers < n) // checking the entered data
        maxNumbers = n;

    i++;
}
Console.Write(maxNumbers);