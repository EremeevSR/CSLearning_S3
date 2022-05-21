// Задача: 
// Написать программу, которая принимает на
// вход пятизначное число и проверяет, является
// ли оно палиндромом.
// Пример:
// 14212 -> нет
// 23432 -> да
// 12821 -> да

// При решении условимся на правильный ввод
// пятизначного числа.
// В частности, признак палиндрома для пятизначного
// числа - равенство первой/пятой и второй/четвертой
// цифер этого числа. Это уловие и будет проверяться.

// В первом случае сравниваться будут символы строки.
String userNumber = Console.ReadLine();
if (userNumber[0] == userNumber[4] &&
    userNumber[1] == userNumber[3])
    Console.WriteLine("да");
else 
    Console.WriteLine("нет");

// Этот алгоритм можно оформить в виде метода.
// Для разнообразия этот метод будет с возвращаемым
// значением (в прошлой ДЗ все были void).
String isPalindromS(String userNum)
{
    if (userNumber[0] == userNumber[4] &&
        userNumber[1] == userNumber[3])
        return "да";
    else 
        return "нет";
}

<<<<<<< HEAD
// Во втором случае метод будет работать с числами,
// а не символами строки.
=======
>>>>>>> 3319498d0642aae09033fa87515907ff445cc334
String isPalindromN(String userNum)
{
    // Метод, который определяет палиндром работая
    // с числом.
    int userNumber = Convert.ToInt32(userNum);
    int[] numbers = new int[5]; //Массив для записи цифр числа
    int i = 4;
    while(userNumber > 0) 
    {
        // Разложение числа на цифры.
        numbers[i] = userNumber % 10;
        userNumber /= 10;
        i--;
    }
    if (numbers[0] == numbers[4] &&
        numbers[1] == numbers[3])
        return "да";
    else 
        return "нет";
}

Console.WriteLine(isPalindromS(userNumber));
Console.WriteLine(isPalindromN(userNumber));