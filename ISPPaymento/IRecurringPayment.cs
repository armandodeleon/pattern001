namespace ISPPaymento;

public interface IRecurringPayment
{
    void SetupRecurringPayment(decimal amount, DateTime schedule);
}