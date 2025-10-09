namespace ISPPaymento;

public class PaymentService
{
    public void MakePayment(IPayment paymentProcessor, decimal amount)
    {
        paymentProcessor.ProcessPayment(amount);
    }

    public void RefundableIfPossible(object paymentProcessor, string transactionId)
    {
        if (paymentProcessor is IRefundable refundable)
        {
            refundable.RefundPayment(transactionId);
        }
        else
        {
            Console.WriteLine("Payment processor does not support refunds");
        }
    }
    
    public void SetupRecurringIfSupported(object paymentProcessor, decimal amount, DateTime schedule)
    {
        if (paymentProcessor is IRecurringPayment recurringPayment)
        {
            recurringPayment.SetupRecurringPayment(amount, schedule);
        }
        else
        {
            Console.WriteLine("Payment processor does not support recurring payments");
        }
    }
}