// The address contains a string for the street address, the city, state/province, and country.
// The address should have a method that can return whether it is in the USA or not.
// The address should have a method to return a string all of its fields together in one string 
//(with newline characters where appropriate)

using System;

public class Address
{
    private string _address;
    private string _city;
    private string _state, _province;
    private string _country;


    public void IsUsa()
    {
        return;
    }

    public string ReturnAll()
    {
        return $"{_address} {_city} {_state} {_country} {_province}";
    }









}