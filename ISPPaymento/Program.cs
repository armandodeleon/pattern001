namespace ISPPaymento;

class Program
{
    static void Main(string[] args)
    {
        var paymentService = new PaymentService();
        
        IPayment creditCard = new CreditCardPayment();
        IPayment paypal = new PayPalPayment();
        IPayment crypto = new CryptoPayment();
        
        paymentService.MakePayment(creditCard, 100);
        paymentService.RefundableIfPossible(creditCard, "123456");
        
        paymentService.MakePayment(paypal, 100);
        paymentService.SetupRecurringIfSupported(paypal, 100, DateTime.Now.AddDays(1));
        paymentService.RefundableIfPossible(paypal, "123456");
        
        paymentService.MakePayment(crypto, 100);
        paymentService.RefundableIfPossible(crypto, "123456"); // not supported by crypto
        
    }
}