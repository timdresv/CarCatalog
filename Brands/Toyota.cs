using CarCatalog;
using CarCatalog.Drive;

namespace CarCatalog.Brands;

public class Toyota : AutomaticCar, IGas
{
    protected override string BrandName => "Toyota";
    protected override int Seats => 5;
    protected override bool HasAndroid => true;
}
