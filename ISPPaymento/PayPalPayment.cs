namespace ISPPaymento;

public class PayPalPayment: IPayment, IRecurringPayment
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing PayPal payment of {amount}");
    }
    
    public void SetupRecurringPayment(decimal amount, DateTime schedule)
    {
        Console.WriteLine($"Setting up recurring payment of {amount} for {schedule}");
    }  
}