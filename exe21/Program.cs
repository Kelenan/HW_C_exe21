/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int Prompt (string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine()?? "";
    int result = Convert.ToInt32(value);
    return result;
}

int Xa = Prompt("Введите первое число первой координаты ");
int Ya = Prompt("Введите второе число первой координаты ");
int Za = Prompt("Введите третье число первой координаты ");

int Xb = Prompt("Введите первое число второй координаты ");
int Yb = Prompt("Введите второе число второй координаты ");
int Zb = Prompt("Введите третье число второй координаты ");

Console.WriteLine($"Первая координата: {Xa}{Ya}{Za}");
Console.WriteLine($"Вторая координата: {Xb}{Yb}{Zb}");

Console.WriteLine($"Расстояние между точками координат в 3D пространстве составляет: {Math.Sqrt(Math.Pow((Xa-Xb),2) + Math.Pow((Ya-Yb),2) + Math.Pow((Za-Zb),2))}");