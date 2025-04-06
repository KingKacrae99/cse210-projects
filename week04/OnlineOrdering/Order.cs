public class Order{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer){
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product){
        _products.Add(product);
    }
    public double TotalOrderCost(){
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.TotalCost();
        }
        if (_customer.LiveInTheCountry()){
            total += 5;
        } else{
            total += 35;
        }
        return total;
    }
    public double TotalPriceWithoutShipFee(){
        double total = 0;
        foreach (Product product in _products){
            total += product.TotalCost();
        }
        return total;
    }
    public string GetPackingLabel(){
        string label = "";
        foreach (Product product in _products)
        {
            label += $"{product.GetPackingLabel()}\n";
        }
        return label;
    }
    public string GetShippingLabel(){
        return _customer.GetShippingLabel();
    }
}