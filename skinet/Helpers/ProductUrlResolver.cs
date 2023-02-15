using AutoMapper;
using AutoMapper.Execution;
using Core.Entities;
using skinet.Dtos;
using Microsoft.Extensions.Configuration;

namespace skinet.Helpers
{
    public class ProductUrlResolver : IValueResolver<Product, ProductToReturnDto, string>
    {
        private readonly IConfiguration config;

        public ProductUrlResolver(IConfiguration config)
        {
            this.config = config;
        }

        public string Resolve(Product source, ProductToReturnDto destination, string destMember, ResolutionContext context)
        {
            if (!string.IsNullOrEmpty(source.PictureUrl)) 
            {
                return this.config["ApiUrl"] + source.PictureUrl;
            }

            return null;
        }
    }
}
