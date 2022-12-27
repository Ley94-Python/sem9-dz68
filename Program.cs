// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
static int AccNumbers(int M, int N)
{
if (M == 0) return (N + 1);            
else if (N == 0) return AccNumbers(M -1, 1);       
else return AccNumbers(M - 1, AccNumbers(M, N - 1));          
}       
Console.Write("M = ");
int M = int.Parse(Console.ReadLine());
Console.Write("N = ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine($"Число Аккермана: , A = {AccNumbers(M, N)}");
Console.ReadLine();