using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Owner.API.Data;
using Owner.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Owner.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {

        [Route("All")]
        [HttpGet]
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

        [HttpPost("Create")]
        public IActionResult CreateOwner(ModelOwner model)
        {
            var owners = new List<ModelOwner>();
            if (owners.Any(x=>x.Description.Contains("hack")))
            {
                return BadRequest("error");
            }
            else
            {
                owners.Add(model);
                return Ok(model);
            }
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var owners = new OwnerData().GetAllOwner();

            var owner = owners.FirstOrDefault(x => x.Id == id);

            if (owner == null)
                return NotFound($"{id} bulunamadı");

            owners.Remove(owner);

            return Ok("Owner silindi");
        }

        [HttpPut("{id:int}")]
        public IActionResult Update(int id, ModelOwner owner)
        {
            if (id != owner.Id)
                return BadRequest("Müşteri Id'leri eşleşmedi");

            var employees = new OwnerData().GetAllOwner();

            var update = employees.FirstOrDefault(x => x.Id == id);

            update.FirstName = owner.FirstName.ToUpper();
            update.LastName = owner.LastName.ToLower();
            update.Date = owner.Date;
            update.Description = owner.Description;
            update.Type = owner.Type;
            return Ok(update);
        }
    }

}
