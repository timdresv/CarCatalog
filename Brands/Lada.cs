using CarCatalog;
using CarCatalog.Drive;

namespace CarCatalog.Brands;

public class Lada : ManualCar, IGas
{
    protected override string BrandName => "Lada";
    protected override int Seats => 5;
    protected override bool HasAndroid => false;
}
