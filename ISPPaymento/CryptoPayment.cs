namespace ISPPaymento;

public class CryptoPayment: IPayment
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing crypto payment of {amount}");
    }    
}