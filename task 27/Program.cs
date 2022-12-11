// Напишите программу, которая принимает на вход 
// число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int InputNumber()
{
    Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
return number;
}
int SumNumber(int number)
{
    int sumnumber = 0;
    while (number>0)
    {
    int temp = number%10;
    number= number/10;
    sumnumber = sumnumber + temp;
    }
    return sumnumber;
}

int number = InputNumber();
int sumnumber = SumNumber(number);
Console.WriteLine($"Сумма цифр введенного числа = " + sumnumber);