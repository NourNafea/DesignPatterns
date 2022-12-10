using SimpleFactoryPOC;


var cardDetails = CreditCardFactory.GetCreditCart(Console.ReadLine()!);

if(cardDetails != null)
{
    Console.WriteLine(cardDetails.GetCardType());
    Console.WriteLine(cardDetails.GetCreditLimit());
    Console.WriteLine(cardDetails.GetAnnualCharge());
}