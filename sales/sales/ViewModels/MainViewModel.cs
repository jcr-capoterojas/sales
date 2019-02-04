namespace sales.ViewModels
{
    public class MainViewModel
    {
        #region Properties
        public ProductsViewModel Products { get; set; }
        #endregion

        public MainViewModel()
        {
            this.Products = new ProductsViewModel();
        }
    }
}
