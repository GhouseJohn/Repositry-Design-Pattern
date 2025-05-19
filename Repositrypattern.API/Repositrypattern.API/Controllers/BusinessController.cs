using Microsoft.AspNetCore.Mvc;
using Repositrypattern.API.Repo;

namespace Repositrypattern.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BusinessController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public string getName()
        {
            return "Hello from Business Controller";
        }
        [HttpGet("getAll")]
        public void GetById()
        {
            var data = _unitOfWork.Products.GetByIdAsync(1);
            // Do something with the data
        }
    }
}
