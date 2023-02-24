// Задача 41: Пользователь 
//     вводит с клавиатуры M чисел. 
//     Посчитайте, сколько чисел больше 0 ввёл пользователь.
//         0, 7, 8, -2, -2 -> 2
//         -1, -7, 567, 89, 223-> 3

int NumberPositiveElementsArray(int[] array) {
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0) count++;
    return count;
}

System.Console.Write("Введите числа через пробел: ");
int[] mas = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
System.Console.WriteLine("Кол-во чисел больше нуля соответствует " + NumberPositiveElementsArray(mas));