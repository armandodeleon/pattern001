namespace ISPPaymento;

public class CreditCardPayment: IPayment, IRefundable
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing credit card payment of {amount}");
    }   
    
    public void RefundPayment(string transactionId)
    {
        Console.WriteLine($"Refunding transaction {transactionId}");
    }  
}