using CarCatalog;
using CarCatalog.Drive;

namespace CarCatalog.Brands;

public class BYD : AutomaticCar, IElectric
{
    protected override string BrandName => "BYD";
    protected override int Seats => 5;
    protected override bool HasAndroid => true;
}
