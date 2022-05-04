using AuthorBook.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AuthorBook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {

        ///definer en metode der returnerer en int og bagefter en der returnere en string

        //[HttpGet]
        //public int getAll()
        //{
        //    return 100;
        //}
        [HttpGet]
        public List<Car> getList()
        {
            List<Car> listCars = new List<Car>
            {
                new Car(){CarId=1,Model="127",Brand="Fiat",Color="Sort"},
                new Car(){CarId=2,Model="Punto",Brand="Fiat",Color="Blå"},
                new Car(){CarId=3,Model="Panda",Brand="Fiat",Color="Gul"},
            };
            return listCars;
        }
        //[HttpPost]
        //public

    }
}
