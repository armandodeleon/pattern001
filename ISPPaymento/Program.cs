namespace ISPPaymento;

class Program
{
    static void Main(string[] args)
    {
        PayPalPayment payPalPayment = new PayPalPayment();
        payPalPayment.ProcessPayment(100);
        
        CreditCardPayment creditCardPayment = new CreditCardPayment();
        creditCardPayment.ProcessPayment(100);
        
        
    }
}