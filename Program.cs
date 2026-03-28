using CarCatalog;

Console.OutputEncoding = System.Text.Encoding.UTF8;

while (true)
{
    Console.Write("Введите марку автомобиля или done для остановки ввода: ");
    string? line = Console.ReadLine();

    if (line is null)
    {
        continue;
    }

    line = line.Trim();

    if (line.Equals("done", StringComparison.OrdinalIgnoreCase))
    {
        break;
    }

    if (!Enum.TryParse<CarType>(line, ignoreCase: true, out CarType carType))
    {
        string allBrands = string.Join(", ", Enum.GetNames<CarType>());
        Console.WriteLine($"Марка «{line}» не найдена. Доступны: {allBrands}.");
        continue;
    }

    ICar car = CarFactory.Create(carType);
    Console.WriteLine(car.GetDescription());
}

Console.WriteLine("Выход.");
