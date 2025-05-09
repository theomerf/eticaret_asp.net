﻿using Services.Contracts;

namespace Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly IProductService _productService;
        private readonly IMainCategoryService _mainCategoryService;
        private readonly ISubCategoryService _subCategoryService;
        private readonly IOrderService _orderService;
        private readonly IAuthService _authService;
        private readonly IUserReviewService _userReviewService;
        private readonly ICartService _cartService;

        public ServiceManager(IProductService productService, IMainCategoryService mainCategoryService, IOrderService orderService, IAuthService authService, ISubCategoryService subCategoryService, IUserReviewService userReviewService, ICartService cartService)
        {
            _productService = productService;
            _mainCategoryService = mainCategoryService;
            _orderService = orderService;
            _authService = authService;
            _subCategoryService = subCategoryService;
            _userReviewService = userReviewService;
            _cartService = cartService;
        }

        public IProductService ProductService => _productService;
        public IMainCategoryService MainCategoryService => _mainCategoryService;
        public ISubCategoryService SubCategoryService => _subCategoryService;
        public IOrderService OrderService => _orderService;
        public IAuthService AuthService => _authService;
        public IUserReviewService UserReviewService => _userReviewService;
        public ICartService CartService => _cartService;
    }
}
