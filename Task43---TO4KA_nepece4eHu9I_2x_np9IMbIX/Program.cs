// Задача 43. Напишите программу, которая 
//     найдёт точку пересечения двух прямых, 
//         заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//     значения b1, k1, b2 и k2 задаются пользователем.
//             b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// y = k1*x + b1
// y = k2*x + b2
// x = (b2-b1) / (k1-k2)

double WriteTxtReadDouble(string txt){
    System.Console.Write(txt);
    return Convert.ToDouble(Console.ReadLine());
}

void IntersectionPoint (double[] array, out double x, out double y) {
    x = Math.Round( ( array[2] - array[0] ) / ( array[1] - array[3] ) , 2);
    y = Math.Round( array[3] * x + array[2] , 2);
    //  для самопроверки расчётов:
    System.Console.WriteLine($"( {array[2]} - {array[0]} ) / ( {array[1]} - {array[3]} ) = {x}");
    System.Console.WriteLine($"{array[3]} * {x} + {array[2]} = {y}");
    y = Math.Round( array[1] * x + array[0] , 2);
    System.Console.WriteLine($"{array[1]} * {x} + {array[0]} = {y}");
}

System.Console.WriteLine("Имеем две прямые, заданные уравнениями:");
System.Console.WriteLine("y = k1*x + b1");
System.Console.WriteLine("y = k2*x + b2");
System.Console.Write("Введите через зпт значения b1, k1, b2, k2: ");
double[] mas = Array.ConvertAll(Console.ReadLine().Split(", "), double.Parse);
IntersectionPoint(mas, out double x, out double y);
System.Console.WriteLine($"Точка пересечения двух прямых соответствует координатам: ({x}; {y})");