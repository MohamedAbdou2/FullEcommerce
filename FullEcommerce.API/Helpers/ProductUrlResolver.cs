using AutoMapper;
using FullEcommerce.API.Dtos;
using FullEcommerce.Core.Entities;

namespace FullEcommerce.API.Helpers
{
    public class ProductUrlResolver : IValueResolver<Product, GetProductDto, string>
    {
        private readonly IConfiguration _config;

        public ProductUrlResolver(IConfiguration config)
        {
            _config = config;
        }
        public string Resolve(Product source, GetProductDto destination, string destMember, ResolutionContext context)
        {
            if (!string.IsNullOrEmpty(source.PictureUrl))
            {
                return _config["ApiUrl"] + source.PictureUrl;
            }
            return null;
        }
    }
}
