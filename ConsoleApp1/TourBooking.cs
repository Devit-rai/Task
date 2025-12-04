public class TourBooking
{
    public required string CustomerName { get; set; }
    public required string Destination { get; set; }
    public double Price { get; set; }
    public int DurationInDay { get; set; }
    public bool IsInternational { get; set; }
}
