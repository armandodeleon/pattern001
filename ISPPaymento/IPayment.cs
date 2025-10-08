namespace ISPPaymento;

public interface IPayment
{
    void ProcessPayment(decimal amount);
}