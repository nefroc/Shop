namespace Shop.Web.Controllers.API
{
    using System;
    using Microsoft.AspNetCore.Mvc;
    using Shop.Web.Data;

    [Route("api/[Controller]")]
    public class ProductsController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }

        public IActionResult GetProducts() {
            return this.Ok(this._productRepository.GetAll());
        }
    }
}
