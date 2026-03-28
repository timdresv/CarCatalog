using CarCatalog;
using CarCatalog.Drive;

namespace CarCatalog.Brands;

public class Kia : AutomaticCar, IGas
{
    protected override string BrandName => "Kia";
    protected override int Seats => 5;
    protected override bool HasAndroid => false;
}
