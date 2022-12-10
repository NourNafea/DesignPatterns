using FactoryPatternPOC.Types;

namespace FactoryPatternPOC;

public class CreditCardFactory
{
    public static ICreditCard? GetCreditCart(string cardType)
    {
        return cardType switch
        {
            "MoneyBack" => new MoneyBack(),
            "Titanium" => new Titanium(),
            "Platinum" => new Platinum(),
            _ => null,
        };
    }
}