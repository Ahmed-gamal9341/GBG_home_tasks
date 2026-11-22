public class Order
{
    public int Id { get; set; }
    public string CustomerEmail { get; set; }
    public decimal TotalAmount { get; set; }
    public string ShippingType { get; set; } 
    public bool IsValid { get; set; }
}


public abstract class Discount
{
    public virtual decimal Apply(decimal price)
    {
        return price;
    }
}

public class PercentageDiscount : Discount
{
    private readonly decimal _percentage;

    public PercentageDiscount(decimal percentage)
    {
        _percentage = percentage;
    }

    public override decimal Apply(decimal price)
    {
        return price - (price * _percentage);
    }
}

public class NoDiscount : Discount
{
    public override decimal Apply(decimal price)
    {
        return price; 
    }
}