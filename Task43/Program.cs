// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] pointsB = new double[2];
for(int i = 0; i < pointsB.Length; i++)
{
    Console.WriteLine("Введите координаты конечных точек прямой b1 и b2");
    pointsB[i] = Convert.ToInt32(Console.ReadLine());
}

double[] pointsK = new double[2];
for(int i = 0; i < pointsK.Length; i++)
{
    Console.WriteLine("Введите координаты конечных точек прямой k1 и k2");
    pointsK[i] = Convert.ToInt32(Console.ReadLine());
}
 
double x = (pointsB[1] - pointsB[0]) / (pointsK[0] - pointsK[1]);
double y1 = (pointsK[0] * x) + pointsB[0];
double y2 = (pointsK[1] * x) + pointsB[1];

Console.Write($"Точка пересечения " + y1 + "; " + y2);