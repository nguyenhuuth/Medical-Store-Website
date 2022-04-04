namespace MedicalStore.Utils.Common
{
    public class RouterItem
    {
        public string Title
        {
            get; set;
        }
        public string Page
        {
            get; set;
        }
        public string Link
        {
            get; set;
        }
    }

    public class Routers
    {

        public static readonly RouterItem Register = new RouterItem() { Page = "/Views/Containers/Auth/Register.cshtml", Title = "Register", Link = "/auth/register" };
        public static readonly RouterItem RegisterShop = new RouterItem() { Page = "/Views/Containers/Auth/RegisterShop.cshtml", Title = "Register", Link = "/auth/register/shop" };
        public static readonly RouterItem Login = new RouterItem() { Page = "/Views/Containers/Auth/Login.cshtml", Title = "Login", Link = "/auth/login" };

        //User Controller
        public static readonly RouterItem User = new RouterItem() { Page = "/Views/Containers/User/User.cshtml", Title = "User", Link = "/user" };
        public static readonly RouterItem UpdatePassword = new RouterItem() { Page = "/Views/Containers/User/UpdatePassword.cshtml", Title = "Update Password", Link = "/user/password" };
        public static readonly RouterItem UpdateUserInfo = new RouterItem() { Page = "/Views/Containers/User/UpdateUserInfo.cshtml", Title = "Update User Info", Link = "/user/updateinfo" };
        public static readonly RouterItem UserProfile = new RouterItem() { Page = "/Views/Containers/User/UserProfile.cshtml", Title = "Update User Profile", Link = "/user/profile" };
        //------------------------------------

        public static readonly RouterItem Home = new RouterItem() { Page = "/Views/Containers/Home.cshtml", Title = "Home", Link = "/" };

        public static readonly RouterItem Logout = new RouterItem() { Page = "/Views/Containers/CreateProduct.cshtml", Title = "Create Product", Link = "/auth/logout" };
        public static readonly RouterItem Cart = new RouterItem() { Page = "/Views/Containers/Cart/Cart.cshtml", Title = "Cart", Link = "/cart" };
        public static readonly RouterItem RemoveCart = new RouterItem() { Page = "/Views/Containers/Cart/Cart.cshtml", Title = "Cart", Link = "/cart/remove" };

        //Category Controller
        public static readonly RouterItem Category = new RouterItem() { Page = "/Views/Containers/Category/Category.cshtml", Title = "All Category", Link = "/category" };
        public static readonly RouterItem CreateCategory = new RouterItem() { Page = "/Views/Containers/Category/CreateCategory.cshtml", Title = "Create Category", Link = "/category/create" };
        public static readonly RouterItem CategoryUpdate = new RouterItem() { Page = "/Views/Containers/Category/CategoryUpdate.cshtml", Title = "Update Category", Link = "/category/update" };
        public static readonly RouterItem CategoryDetail = new RouterItem() { Page = "/Views/Containers/Category/CategoryDetail.cshtml", Title = "Category Profile", Link = "/category/detail" };
        //------------------------------------

        //Product
        public static readonly RouterItem Product = new RouterItem() { Page = "/Views/Containers/Product/Product.cshtml", Title = "All Product", Link = "/product/" };
        public static readonly RouterItem CreateProduct = new RouterItem() { Page = "/Views/Containers/Product/CreateProduct.cshtml", Title = "Create Product", Link = "/product/create" };
        public static readonly RouterItem UpdateProduct = new RouterItem() { Page = "/Views/Containers/Product/UpdateProduct.cshtml", Title = "Update Product", Link = "/product/update" };
        public static readonly RouterItem ProductDetail = new RouterItem() { Page = "/Views/Containers/Product/ProductDetail.cshtml", Title = "Product Profile", Link = "/product/detail" };
        public static readonly RouterItem SearchProduct = new RouterItem() { Page = "/Views/Containers/Product/SearchProduct.cshtml", Title = "Search Product", Link = "/product/search" };
        //------------------------------------

        //Order
        public static readonly RouterItem Order = new RouterItem() { Page = "/Views/Containers/Order/Order.cshtml", Title = "Your Order", Link = "/order" };
        public static readonly RouterItem OrderDetail = new RouterItem() { Page = "/Views/Containers/Order/OrderDetail.cshtml", Title = "Order Detail", Link = "/order/detail" };
        public static readonly RouterItem OrderManager = new RouterItem() { Page = "/Views/Containers/Order/Manager.cshtml", Title = "Users Order", Link = "/order/manager" };
        public static readonly RouterItem SearchOrders = new RouterItem() { Page = "/Views/Containers/Order/Manager.cshtml", Title = "Users Order", Link = "/order/manager" };
        //------------------------------------
        
        //Report
        public static readonly RouterItem CreateReport = new RouterItem() { Page = "/Views/Containers/Report/CreateReport.cshtml", Title = "Report", Link = "/report/create" };
        public static readonly RouterItem Report = new RouterItem() { Page = "/Views/Containers/Report/Report.cshtml", Title = "Report", Link = "/report" };
        public static readonly RouterItem ReportList = new RouterItem() { Page = "/Views/Containers/Report/ReportDetail.cshtml", Title = "Report Detail", Link = "/report/detail" };
        //------------------------------------

        //Admin
        public static readonly RouterItem CustomerManage = new RouterItem() { Page = "/Views/Containers/Admin/CustomerManage.cshtml", Title = "Manage Customer", Link = "/admin/customer" };
        public static readonly RouterItem SellerManage = new RouterItem() { Page = "/Views/Containers/Admin/SellerManage.cshtml", Title = "Manage Seller", Link = "/admin/seller" };
        //------------------------------------
    }
}
