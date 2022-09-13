using Microsoft.AspNetCore.Mvc;

namespace webapi_test.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ValuesController : ControllerBase
{
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[]{"value1", "value2"};
    }

    [HttpGet("{id}")]
    public string Get(int id)
    {
        if (id == 1) return "value1";
        if (id == 2) return "value2";

        return "NA";
    }
}
