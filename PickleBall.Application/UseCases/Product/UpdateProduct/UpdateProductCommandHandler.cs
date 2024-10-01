using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Contract.Abstractions.Repositories;
using PickleBall.Domain.DTOs.Product;

namespace PickleBall.Application.UseCases.Product.UpdateProduct;

public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, Result<ProductResponse>>
{
    private readonly IProductRepository _productRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public UpdateProductCommandHandler(IProductRepository productRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _productRepository = productRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<Result<ProductResponse>> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        var product = await _productRepository.GetEntityByConditionAsync(x => x.Id == request.Id,
            true,
            cancellationToken);

        if (product is null)
        {
            throw new Exception("Product not found");
        }
        
        product.ProductName = request.ProductName;
        product.Description = request.Description;
        product.ImageUrl = request.ImageUrl;
        product.Quantity = request.Quantity;
        product.Price = request.Price;
        
        _productRepository.UpdateAsync(product);
        
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        
        var productResponse = _mapper.Map<ProductResponse>(product);
        
        return Result<ProductResponse>.Success(productResponse);
    }
}