bool isWithinTheSquare(int x1, int y1, int length, int Ax, int Ay)
{
    int x2 = x1 + length;
    int y2 = y1 + length;

    if (Ax >= x1 && Ax <= x2 && Ay >= y1 && Ay <= y2)
    {
        Console.WriteLine("Точка знаходиться всерединi квадрата.");
        return true;
    }
    else
    {
        Console.WriteLine("Точка НЕ знаходиться всерединi квадрата.");
        return false;
    }
}

// Input

Console.Write("Введiть довжину сторони квадрата: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("=========================================");
Console.WriteLine("Введiть координати верхньої лiвої точки квадрата (x1, y1):");
Console.Write("X(0) = "); 
int x0 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y(0) = ");
int y0 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("=========================================");
Console.WriteLine("Введiть координати точки A:");
Console.Write("A(x) = ");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.Write("A(y) = ");
int Ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("=========================================");

isWithinTheSquare(x0, y0, length, Ax, Ay);
