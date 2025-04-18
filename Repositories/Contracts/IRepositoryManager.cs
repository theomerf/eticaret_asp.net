namespace Repositories.Contracts{
    public interface IRepositoryManager{
        IProductRepository Product {get; }
        IMainCategoryRepository MainCategory {get; }
        ISubCategoryRepository SubCategory { get; }
        IOrderRepository Order { get; }
        void Save();
    }
}