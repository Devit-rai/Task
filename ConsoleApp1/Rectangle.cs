public class Rectangle
{
    private double length;
    private double breath;
    public double Length
    {
        get => length;
        set => breath = value;
    }
    public int Breadth { get; internal set; }

    public double GetArea()=> length * breath;
    public void ShowDetails()=> Console.WriteLine($"Length: {length}, Breadth: {breath}");
    public double GetPerimeter() => 2*(length+breath);
}

