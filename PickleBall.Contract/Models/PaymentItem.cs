namespace PickleBall.Contract.Models;

public class PaymentItem
{
    public string Name { get; set; } = null!;
    public int Quantity { get; set; }
    public int Price { get; set; }
}