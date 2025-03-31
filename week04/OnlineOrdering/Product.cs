
public class Product
{
    private string _name;
    private int _productId;
    private int _price;
    private int _quantityOfProduct;
     


      public Product(string name, int productId,int price, int quantityOfProduct)
    {
        _name= name;
        _price = price;
        _productId = productId;
        _quantityOfProduct = quantityOfProduct;
    }

    public void SetProducts(string name, int productId,int price, int quantityOfProduct)
    {
        _name= name;
        _price = price;
        _productId = productId;
        _quantityOfProduct = quantityOfProduct;
    }


    public string GetProductsString()
    {
        return $"{_name},{_productId},{_price},{_quantityOfProduct}";
    }

    
    public int GetTotalOfProduct()
    {
        return _price * _quantityOfProduct;
    }
} 