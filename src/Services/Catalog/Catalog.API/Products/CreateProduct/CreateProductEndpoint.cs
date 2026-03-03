using System;
using Carter;

namespace Catalog.API.Products.CreateProduct;

// captures all the information to create a product
// we need to map the request to CommandQuery using Mapping library (Mapster)
public record CreateProductRequest(string Name, List<String>Category, string Description, string ImageFile, decimal Price);

// returns the final result
public record CreateProductResponse(Guid id);

// we need to send values from request to trigger the handler
public class CreateProductEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        throw new NotImplementedException();
    }
}
