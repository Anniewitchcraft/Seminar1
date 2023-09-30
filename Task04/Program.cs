// Задача 4: Напишите программу, 
// которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int firstNumber, secondNumber, thirdNumber;

Console.WriteLine("Введите первое число: ");
firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
thirdNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    if (firstNumber > thirdNumber)
    {
        Console.WriteLine($"максимальное число = {firstNumber}");
    }

}
else if(secondNumber > firstNumber)
{
    if (secondNumber > thirdNumber)
    {
        Console.WriteLine($"максимальное число = {secondNumber}");
    }
}
else if (thirdNumber > firstNumber)
{
    if (thirdNumber > secondNumber)
    {
        Console.WriteLine($"максимальное число = {thirdNumber}");
    }
}