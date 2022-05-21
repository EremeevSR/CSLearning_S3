// Напишите программу, которая принимает на
// вход число (N), а выдает таблицу кубов
// чисел от 1 до N.
// Пример:
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// При решении задачи условимся, что правильность ввода
// проверять не нужно. 

int N = Convert.ToInt32(Console.ReadLine());

int cubeOfNum(int num)
{
    // Метод вычисления куба числа num
    return num * num * num;
}

void showCubeTable(int userNumber)
{
    // Метод вывода кубов от 1 до userNumber
    for(int i = 1; i <= userNumber; i++)
    {
        if (i == userNumber) //Чтобы вывод был, как в примере
            Console.WriteLine(cubeOfNum(i));
        else                 
            Console.Write(cubeOfNum(i) + ", ");
    }
}

showCubeTable(N);