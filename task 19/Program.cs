// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да


string Method2(string msg)
{
    Console.WriteLine(msg);
    string number = Console.ReadLine();
    return number;
}
string Method3(string number)
{
string result = "НЕТ";
if (number[0] == number[4] && number[1] == number[3])
{
    result = "ДА";
    return result;
}
else
{
    return result;
}
}

string number = Method2(msg: "Введите пятизначное число: ");
string result = Method3(number);
Console.WriteLine(result);
