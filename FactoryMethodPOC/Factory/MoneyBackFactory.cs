using FactoryMethodPOC.Types;

namespace FactoryMethodPOC.Factory;

public class MoneyBackFactory : CreditCardFactory
{
    protected override ICreditCard MakeProduct()
    {
        ICreditCard product = new MoneyBack();
        return product;
    }
}