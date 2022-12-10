using FactoryMethodPOC;

var cardInstance = Console.ReadLine()?.AddCreditCard();

if(cardInstance != null)
{
    Console.WriteLine("Card Type : " + cardInstance.GetCardType());
    Console.WriteLine("Credit Limit : " + cardInstance.GetCreditLimit());
    Console.WriteLine("Annual Charge :" + cardInstance.GetAnnualCharge());
}

