using MedicalStore.Models;
using System.Collections.Generic;


namespace MedicalStore.Service.Interface
{
    public interface ICartService
    {
        public string convertCartItemToString(Dictionary<string, CartItem> list);
        public Dictionary<string, CartItem> convertStringToCartItem(string input);
        public List<Product> GetCartItems(Dictionary<string, CartItem> list);

    }
}