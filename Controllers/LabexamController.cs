using Microsoft.AspNetCore.Mvc;
using exam_laboratory_codes_app.Models;
using exam_laboratory_codes_app.Services;

namespace exam_laboratory_codes_app.Controllers
{
    [Route("api/[controller]")]
    public class LabexamController : ControllerBase
    {
        readonly ILabexamService _labexamServiceLocal;
        public LabexamController(ILabexamService labexamService)
        {
            _labexamServiceLocal = labexamService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_labexamServiceLocal.GetAll());
        }

        [HttpGet("search")]
        public IActionResult SearchKeyword([FromQuery(Name = "q")] string q)
        {
            try
            {
                if (string.IsNullOrEmpty(q))
                {
                    return BadRequest("String is required...");
                }

                var result = _labexamServiceLocal.SearchKeyword(q);

                //var result = $"{q}>xD";

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error: {ex.Message}");
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Labexam labexamNew)
        {
            _labexamServiceLocal.Save(labexamNew);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] Labexam le)
        {
            _labexamServiceLocal.Update(id, le);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            _labexamServiceLocal.Delete(id);
            return Ok();
        }
    }
}
