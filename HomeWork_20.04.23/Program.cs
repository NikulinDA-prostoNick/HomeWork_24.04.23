// Task2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.WriteLine("Введите число");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число");
// int b = Convert.ToInt32(Console.ReadLine());

// if (a < b)

// System.Console.WriteLine("Меньшее число: " + a + ", большее число: " + b);
// else System.Console.WriteLine($"Меньшее число: {a}, большее число: {b}");



// Task4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.WriteLine("Введите первое число");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите третье число");
// int c = Convert.ToInt32(Console.ReadLine());

// int max = a;
// if (max < b) max = b;
// if (max < c) max = c;

// System.Console.WriteLine("Максимальное число из введенных = " + max);


// Task6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Console.WriteLine("Введите число");
// int a = Convert.ToInt32(Console.ReadLine());

// if (a % 2 == 0)

// System.Console.WriteLine("Число: " + a + " четное");

// else System.Console.WriteLine($"Число: {a} нечетное");


// Task8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

for(int a=1;a<=n;a++)
{
if (a % 2 == 0)
System.Console.Write(a + ", ");
}
