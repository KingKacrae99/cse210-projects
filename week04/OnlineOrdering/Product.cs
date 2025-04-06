public class Product{
    private string _name;
    private int _productId;
    private double _price;
    private int _quantity;

    public Product(string name,int productId,double price,int quantity){
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
    public string GetPackingLabel(){
        return $"Product Name: {_name};\nProduct ID: {_productId};\nPrice:${ShowPrice()};\n";
    }
    public double ShowPrice(){
       return _price;
    }
    public double TotalCost(){
        return _price * _quantity;
    }
    
}