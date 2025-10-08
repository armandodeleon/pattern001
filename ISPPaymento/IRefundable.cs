namespace ISPPaymento;

public interface IRefundable
{
    void RefundPayment(string transactionId);
}