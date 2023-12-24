// ДЗ
// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.

int num1 = new Random().Next(1,10);
int num2 = new Random().Next(1,10);
System.Console.WriteLine("Первое число "+num1);
System.Console.WriteLine("Второе число "+num2);
PrintNumbers(num1, num2);

void PrintNumbers(int startEl, int endEl)
{
    System.Console.Write(startEl+" ");
    if (startEl==endEl)
    {
        return;
    }
    if (startEl<endEl)
    {
        PrintNumbers(startEl+1, endEl);
    }
    else
    {
        PrintNumbers(startEl-1, endEl);
    }
}



// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 


// System.Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(AkkermanFunction (m,n));

// int AkkermanFunction (int m, int n)
// {
//     if (m==0)
//     {
//         return n+1;
//     }
//     if (m>0 && n==0)
//     {
//         return AkkermanFunction (m-1,1);
//     }
//     else
//     {
//         return AkkermanFunction (m-1, AkkermanFunction (m,n-1));
//     }
// }




// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1

// int num = new Random().Next(5,10);
// int [] array = new int [num];
// int index = 0;
// CreateArray (index, array);
// System.Console.WriteLine();
// ReversArray(index, array);
// void CreateArray (int i, int [] newArray)
// {
//     if (i == newArray.Length)
//     {
//         return;
//     }
//     newArray[i] = new Random().Next(1,100);
//     System.Console.Write(newArray[i]+" ");
//     CreateArray(i+1, newArray);
// }
// void ReversArray(int j, int [] ReversArr)
// {
//     if (j == ReversArr.Length)
//     {
//         return;
//     }
//     System.Console.Write(ReversArr[ReversArr.Length-1-j]+" ");
//     ReversArray(j+1, ReversArr);
// }

