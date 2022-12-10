using FactoryMethodPOC.Types;

namespace FactoryMethodPOC.Factory;

public class TitaniumFactory : CreditCardFactory
{
    protected override ICreditCard MakeProduct()
    {
        ICreditCard product = new Titanium();
        return product;
    }
}