﻿using ReviewApp.Models;

namespace ReviewApp.Interfaces
{
    public interface ICountryRepository
    {
        bool CountryExists(int  countryId);
        ICollection<Country > GetCountries();
        Country GetCountry(int countryId);

        Country GetCountryByOwner(int ownerId);

        ICollection<Owner> GetOwnersFromACountry(int countryId);
    }
}