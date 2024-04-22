public class MegaStore
{
    public enum DiscountType
    {
        Standard,
        Seasonal,
        Weight
    }

    public static double GetDiscountedPrice(double cartWeight,
                                            double totalPrice,
                                            DiscountType discountType)
    {
        return discountType switch
        {
            DiscountType.Weight => (cartWeight > 10) ? (double)(totalPrice - Math.Floor(totalPrice * 18) / 100) : (double)(totalPrice - Math.Floor(totalPrice * 6) / 100),
            DiscountType.Seasonal => (double)(totalPrice - Math.Floor(totalPrice * 12) / 100),
            DiscountType.Standard => (double)(totalPrice - Math.Floor(totalPrice * 6) / 100),
            _ => totalPrice
        };

    }

    public static void Main(string[] args)
    {
        Console.WriteLine(GetDiscountedPrice(12, 100, DiscountType.Weight));
    }
}
