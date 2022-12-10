using FactoryMethodPOC.Factory;

namespace FactoryMethodPOC;

public static class Install
{
    public static ICreditCard? AddCreditCard(this string cardType)
    {
        return cardType switch
        {
            "MoneyBack" => new MoneyBackFactory().CreateProduct(),
            "Titanium" => new TitaniumFactory().CreateProduct(),
            "Platinum" => new PlatinumFactory().CreateProduct(),
            _ => null
        };
    }
}