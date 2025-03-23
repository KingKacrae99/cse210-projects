public class Fraction{
    private int _top;
    private int _bottom;

    public Fraction(){
        _top = 1;
        _bottom = 1;
        //Console.WriteLine($"{_top}/{_bottom}");
    }
    public Fraction(int wholeNumber){
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom){
        _top = top;
        _bottom = bottom;
    }
    public void GetTop(){
        Console.WriteLine($"numerator: {_top}");
    }
    public void SetTop(int top){
        _top = top;
        Console.WriteLine($"Numerator assigned the value {top}");
    }
    public void GetBottom(){
        Console.WriteLine($"denominator: {_bottom}");
    }
    public void SetBottom(int bottom){
        _bottom = bottom;
        Console.WriteLine($"denominator assiged the value {bottom}.");
    }
    public string GetFractionString(){
        //Console.WriteLine($"Numerator: {_top}");
        //Console.WriteLine($"Denominator:{_bottom}");
        return $"{_top}/{_bottom}";
    }
    
    public double GetDecimalValue(){
        return (double)_top/(double)_bottom;
    }
}