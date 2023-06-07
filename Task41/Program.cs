// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int GetLength() 
{     
    Console.WriteLine("Введите длину массива");     
    int length = Convert.ToInt32(Console.ReadLine());     
    return length; 
} 

int length = GetLength();

int[] Numbers(int length)
{
    int[] num = new int[length];
    int numbers = length;
    for (int i = 0; i < num.Length; i++)
    {
        Console.Write("Введите число: ");     
        numbers = Convert.ToInt32(Console.ReadLine());
        num[i] = numbers;
    }
    
    return num;
}

int PositiveNumbers(int[] lol)
{
    int res = 0;
    for(int i= 0; i < lol.Length; i++)
    {
        if(lol[i] > 0)
        res++;
    }
    return res;
}

int[] lol = Numbers(length);
Console.WriteLine(String.Join(", ", lol));    
int result = PositiveNumbers(lol);
Console.WriteLine("Количество положительных чисел: " + result);    




