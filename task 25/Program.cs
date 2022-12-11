//  Напишите цикл, который принимает на вход
//  два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int InputNumberA()
{
    Console.WriteLine("Введите число А: ");
int numberA = int.Parse(Console.ReadLine());
return numberA;
}
int InputNumberB()
{
Console.WriteLine("Введите число В: ");
int numberB = int.Parse(Console.ReadLine());
return numberB;
}
int Degree(int numberA, int numberB)
{
    int degree = System.Convert.ToInt32(Math.Pow(numberA, numberB));
    return degree;
}
int numberA = InputNumberA();
int numberB = InputNumberB();
int degree = Degree(numberA, numberB);
Console.WriteLine($"Число А в степени числа В = " + degree);