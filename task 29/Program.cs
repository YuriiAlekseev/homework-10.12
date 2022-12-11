// Напишите программу, которая задаёт массив
//  из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] InputNumber()
{
    int [] massiv = new int [8];
    int index = 0;
    int length = massiv.Length;
        while (index < length)
        {
            massiv[index] = new Random(). Next(1, 10);
            index++;
        }
return massiv;
}
int [] OutputMassiv(int [] inputnumber)
{
    Console.Write("[" );
for (int i=0; i<inputnumber.Length; i++)
{
    Console.Write($""+inputnumber[i]+", " );
}
Console.Write("]" );
return inputnumber;
}
int [] inputnumber  = InputNumber();
int [] outputmassiv = OutputMassiv(inputnumber);