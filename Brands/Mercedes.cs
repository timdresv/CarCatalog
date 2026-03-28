using CarCatalog;
using CarCatalog.Drive;

namespace CarCatalog.Brands;

public class Mercedes : AutomaticCar, IGas
{
    protected override string BrandName => "Mercedes";
    protected override int Seats => 5;
    protected override bool HasAndroid => false;
}
