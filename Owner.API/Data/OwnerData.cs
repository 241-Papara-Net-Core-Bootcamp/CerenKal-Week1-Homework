using Owner.API.Models;
using System;
using System.Collections.Generic;


namespace Owner.API.Data
{
    public class OwnerData
    {
        public List<ModelOwner> GetAllOwner()
        {
            return new List<ModelOwner>
            {
                new ModelOwner
                {
                    Id = 1,
                    FirstName = "Ceren",
                    LastName = "Kal",
                    Date = DateTime.Now,
                    Description = "Hacker",
                    Type = "Home"
                },
                new ModelOwner
                {
                    Id = 2,
                    FirstName = "Ayse",
                    LastName = "Olmez",
                    Date = DateTime.Now,
                    Description = "Software Developer",
                    Type = "Home"
                },
                new ModelOwner
                {
                    Id = 3,
                    FirstName = "Tuba",
                    LastName = "Zorlu",
                    Date = DateTime.Now,
                    Description = "Junior Depeloper",
                    Type = "Home"
                },
                new ModelOwner
                {
                    Id = 4,
                    FirstName = "Yaren",
                    LastName = "Bayir",
                    Date = DateTime.Now,
                    Description = "Tekirdag Koftesi",
                    Type = "Home"
                }
            };
        }
    }

}
