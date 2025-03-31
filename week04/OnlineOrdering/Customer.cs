

public class Customer
{
    private string _name;
    private Address _address;
         



   public void SetCustomer(string name,Address address)
   {
    _address =address;
    _name =name;

   }
    

    public string GetCustomer(){

        return $"{_name}:{_address.GetAdressDetails()}";

    }


    public string GetCustomerCountry()
    {
        if(_address.GetUsaAdress() == "usa"){
            return "usa";
        }
        else
        {
            return _address.GetUsaAdress();
        }
    }
}