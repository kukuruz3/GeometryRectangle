using GeometryRectangle;

        try
        {
            Console.WriteLine("=== Демонстрация работы с прямоугольником ===\n");

            // Создание прямоугольника
            Console.WriteLine("1. Создание прямоугольника с координатами (10, 20), шириной 30, высотой 15");
            Rectangle rect = new Rectangle(10, 20, 30, 15);
            Console.WriteLine(rect);
            Console.WriteLine();

            // Демонстрация свойств
            Console.WriteLine("2. Свойства прямоугольника:");
            Console.WriteLine($"   Периметр: {rect.Perimeter:F2}");
            Console.WriteLine($"   Площадь: {rect.Area:F2}");
            Console.WriteLine($"   Правая граница: {rect.Right:F2}");
            Console.WriteLine($"   Нижняя граница: {rect.Bottom:F2}");
            Console.WriteLine();

            // Проверка принадлежности точки
            Console.WriteLine("3. Проверка принадлежности точек:");
            double testX = 25, testY = 30;
            Console.WriteLine($"   Точка ({testX}, {testY}) {(rect.ContainsPoint(testX, testY) ? "принадлежит" : "не принадлежит")} прямоугольнику");

            testX = 5; testY = 10;
            Console.WriteLine($"   Точка ({testX}, {testY}) {(rect.ContainsPoint(testX, testY) ? "принадлежит" : "не принадлежит")} прямоугольнику");
            Console.WriteLine();

            // Перемещение прямоугольника
            Console.WriteLine("4. Перемещение прямоугольника на (5, -3):");
            rect.Move(5, -3);
            Console.WriteLine(rect);
            Console.WriteLine();

            // Изменение размера
            Console.WriteLine("5. Изменение размера на ширину 40, высоту 20:");
            rect.Resize(40, 20);
            Console.WriteLine(rect);
            Console.WriteLine();

            // Демонстрация обработки некорректных значений
            Console.WriteLine("6. Попытка установить отрицательную ширину:");
            try
            {
                rect.Width = -10;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"   Ошибка: {ex.Message}");
            }
            Console.WriteLine();

            // Создание прямоугольника через свойства
            Console.WriteLine("7. Создание прямоугольника через инициализацию свойств:");
            Rectangle rect2 = new Rectangle(0, 0, 10, 10)
            {
                X = 15,
                Y = 25
            };
            Console.WriteLine(rect2);
            Console.WriteLine();

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
