using CarCatalog;
using CarCatalog.Drive;

namespace CarCatalog.Brands;

public class Tesla : AutomaticCar, IElectric
{
    protected override string BrandName => "Tesla";
    protected override int Seats => 5;
    protected override bool HasAndroid => true;
}
