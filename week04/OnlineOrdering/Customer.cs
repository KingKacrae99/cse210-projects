public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address){
        _name = name;
        _address =  address;
    }

    public bool LiveInTheCountry(){
        return _address.IsDomestic();
    }

    public string GetShippingLabel(){
        return $"{_name}\n{_address.GetFullAddress()}";
    }

}