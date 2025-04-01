using projetoOrderEx.Entities;


namespace projetoOrderEx.Entities.Enums
{
    public enum OrderStatus
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}