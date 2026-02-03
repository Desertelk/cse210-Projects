using System.Runtime.CompilerServices;
using System.Collections.Generic;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private int _postalCode;
    private string _country;

    public Address(string street, string city, string state, int postalCode, string country)
    {
        this._street = street;
        this._city = city;
        this._state = state;
        this._postalCode = postalCode;
        this._country = country;
    }

    public bool IsInUSA()
    {
        return _country.ToLower() == "usa";
    }

    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_state} {_postalCode}\n{_country}";
    }
}