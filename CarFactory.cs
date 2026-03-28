using CarCatalog.Brands;

namespace CarCatalog;

public static class CarFactory
{
    public static ICar Create(CarType type)
    {
        return type switch
        {
            CarType.Tesla => new Tesla(),
            CarType.BMW => new BMW(),
            CarType.Lada => new Lada(),
            CarType.Mercedes => new Mercedes(),
            CarType.Toyota => new Toyota(),
            CarType.Volkswagen => new Volkswagen(),
            CarType.Kia => new Kia(),
            CarType.BYD => new BYD(),
            _ => throw new ArgumentOutOfRangeException(nameof(type), type, "Неизвестный тип.")
        };
    }
}
