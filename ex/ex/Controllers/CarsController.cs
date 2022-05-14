using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex.Controllers
{
    [Route("api/[controller]")]
    [Controller]
    public class CarsController : Controller
    {
        public List<Car> cars;

        [HttpGet("[action]")]
        public Car Get(int ID)
        {
            return cars.FirstOrDefault(e => e.ID == ID);
        }
        [HttpPost("[action]")]
        public void Add(Car car)
        {
            cars.Add(car);
        }
    }
}
