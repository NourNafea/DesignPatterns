using FacadePOC.SubSystems;

namespace FacadePOC;

public class OrderFacade
{
    public void PlaceOrder()
    {
        Console.WriteLine("Place Order Started");
        var product = new Product();
        product.GetProductDetails();
        var payment = new Payment();
        payment.MakePayment();
        var invoice = new Invoice();
        invoice.SendInvoice();
        Console.WriteLine("Order Placed Successfully");
    }
}