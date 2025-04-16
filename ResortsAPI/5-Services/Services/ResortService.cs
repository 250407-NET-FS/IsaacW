using ResortsAPI.DTOs;
using ResortsAPI.Models;
using ResortsAPI.Repositories;

namespace ResortsAPI.Services;

public class ResortService : IResortService
{
    private readonly IBookingRepository _bookingRepo;

    private readonly ICustomerRepository _customerRepo;

    private readonly IResortRepository _resortRepo;

    public ResortService(
        IBookingRepository bookingRepo,
        ICustomerRepository customerRepo,
        IResortRepository resortRepo
    )
    {
        _bookingRepo = bookingRepo;
        _customerRepo = customerRepo;
        _resortRepo = resortRepo;
    }

    public Resort CreateResort(PostResortDTO resortDTO){
        Resort resort = new(resortDTO.Name!, resortDTO.Email!, resortDTO.Price!);
        return AddResort(resort);
    }

    public Resort AddResort(Resort resort){
        IResortService.CheckValidResort(resort);
        return _resortRepo.AddResort(resort);
    }

}