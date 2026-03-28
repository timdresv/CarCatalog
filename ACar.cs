using CarCatalog.Drive;
using CarCatalog.Gearbox;

namespace CarCatalog;

public abstract class ACar : ICar
{
    protected abstract string BrandName { get; }
    protected abstract int Seats { get; }
    protected abstract bool HasAndroid { get; }

    public string GetDescription()
    {
        string engine = this is IElectric
            ? "электромобиль"
            : "автомобиль с двигателем внутреннего сгорания";

        string gearbox = this is IAutomatical
            ? "автоматической коробкой передач"
            : "механической коробкой передач";

        string android = HasAndroid ? "Андроид на борту" : "без системы Андроид";

        return $"«{BrandName}: {engine} с {gearbox}, {Seats} местами, {android}»";
    }
}
