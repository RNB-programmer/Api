using Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        List<User> users = new List<User>()
            {
            new User()
        {
            Id=1,
            FullName="Петров Иван Иванович",
            BirthDate=new DateOnly(1988,2,5)     
        },
         new User()
        {
            Id = 2,
            FullName = "Петр%ов Егор Алексеевич",
            BirthDate = new DateOnly(1994, 12, 11)


        },
        new User()
        {
            Id = 3,
            FullName = "Егорова Дарья Евге!ньевна",
            BirthDate = new DateOnly(2005, 3, 1)


        }
    };

        [HttpGet(Name = "GetUsers")]

        public IEnumerable<User> Get()
        {
            return users;
        }
    }
}
