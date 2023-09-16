using exam_laboratory_codes_app.Services;
using Microsoft.AspNetCore.Mvc;

namespace exam_laboratory_codes_app.Controllers
{
    [Route("api/[controller]")]
    public class LabexamController : ControllerBase
    {
        ILabexamService _labexamServiceLocal;
        public LabexamController(ILabexamService labexamService)
        {
            _labexamServiceLocal = labexamService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_labexamServiceLocal.GetAll());
        }

    }
}
