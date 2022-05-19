// Задача:
// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между
// ними в 3D пространстве.
// Пример:
// A (3, 6,8); B (2, 1,-7) -> 15.84
// A (7,-5,0); B (1,-1, 9) -> 11.53

// Для простоты решения условимся на то, что
// координаты X, Y, Z точки в 3-х мерном пространстве
// вводятся последовательно. Для удобства работы с
// данными будут использованы массивы.

int[] firstPoint = new int[3];
int[] secondPoint = new int[3];

void enterPoint3D(int[] userPoint)
{   
    //Метод ввода координат точки.
    int arrLen = userPoint.Length;
    for(int i = 0; i < arrLen; i++)
    {
        userPoint[i] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine("Введите координаты первой точки:");
enterPoint3D(firstPoint); //Ввод координат первой точки.
Console.WriteLine("Введите координаты второй точки:");
enterPoint3D(secondPoint);//Ввод координат второй точки.

double distance(int[] firPoint, int[] secPoint)
{
    //Метод определения расстояния между точками.
    int arrLen = firPoint.Length;
    double result = 0.0;
    int diff = 0;
    for (int i = 0; i < arrLen; i++)
    {
        diff = firPoint[i] - secPoint[i];
        result += diff * diff;
    }
    return Math.Sqrt(result);
}

Console.WriteLine(Convert.ToString(distance(firstPoint, secondPoint)));