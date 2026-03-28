using CarCatalog;
using CarCatalog.Drive;

namespace CarCatalog.Brands;

public class Volkswagen : ManualCar, IGas
{
    protected override string BrandName => "Volkswagen";
    protected override int Seats => 5;
    protected override bool HasAndroid => true;
}
