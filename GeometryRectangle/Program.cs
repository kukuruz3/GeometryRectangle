using GeometryRectangle;

try
{
    var rect = new Rectangle(10, 20, 30, 15);

    Console.WriteLine(rect);

    Console.WriteLine($"Периметр: {rect.Perimeter}");
    Console.WriteLine($"Площадь: {rect.Area}");

    Console.WriteLine($"Содержит (25,30): {rect.ContainsPoint(25, 30)}");
    Console.WriteLine($"Содержит (5,10): {rect.ContainsPoint(5, 10)}");

    rect.Move(5, -3);
    Console.WriteLine("\nПосле перемещения:");
    Console.WriteLine(rect);

    rect.Resize(40, 20);
    Console.WriteLine("\nПосле изменения размера:");
    Console.WriteLine(rect);
}
catch (Exception ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}
