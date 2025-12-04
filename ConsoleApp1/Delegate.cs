public class Delegate
{
    public int Add(int a, int b)=> a+b;
    public int Subtract(int a, int b)=> a-b;
    public double SeasonalDiscount(double price)=> price*0.8; // 20% discount
    public double FeastiveDiscount(double price)=> price*0.9; // 10% discount
    public double NoDiscount(double price)=> price;

    
}
public delegate double DiscountStrategy(double price);

public class DiscountCalculator
{
    public static double CalculateFinalPrice(double originalPrice, DiscountStrategy strategy)
    {
        return strategy(originalPrice);
    }

    public static double TenPercentDiscount(double price)
    {
        return price - (price * 0.10);
    }

    public static double TwentyPercentDiscount(double price)
    {
        return price - (price * 0.20);
    }

    public static double NoDiscount(double price)
    {
        return price;
    }
}
