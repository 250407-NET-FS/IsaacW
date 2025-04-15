using ResortsAPI.DTOs;
using ResortsAPI.Models;

namespace ResortsAPI.Repositories;

public interface ICustomerService
{
    Customer CreateCustomer(PostCustomerDTO customerDTO);
    Customer AddCustomer(Customer customer);

    public static bool CheckValidCustomer(Customer customer){
        if(customer.Email is null || customer.Email == ""){
            throw new Exception("Invalid Customer Email.");
        }
        if(customer.FName is null || customer.FName == ""){
            throw new Exception("Invalid Customer First Name.");
        }
        if(customer.LName is null || customer.LName == ""){
            throw new Exception("Invalid Customer Last Name.");
        }
        return true;
    }
}