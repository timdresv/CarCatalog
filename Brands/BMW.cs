using CarCatalog;
using CarCatalog.Drive;

namespace CarCatalog.Brands;

public class BMW : AutomaticCar, IGas
{
    protected override string BrandName => "BMW";
    protected override int Seats => 5;
    protected override bool HasAndroid => true;
}
