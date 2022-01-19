using Microsoft.AspNetCore.Mvc;
using primeira_api_data_driven_asp;

[Route("categories")]
public class CategoryController : ControllerBase
{
    [HttpGet]
    [Route("")]
    public string Get()
    {
        return "GET";
    }

    [HttpGet]
    [Route("{id:int}")]
    public string GetById(int id)
    {
        return "GET";
    }


    [HttpPost]
    [Route("")]
    public Category Post([FromBody] Category model)
    {
        return model;
    }

    [HttpPut]
    [Route("{id:int}")]
    public Category Put(int id, [FromBody] Category model)
    {
        if(model.Id == id)
        {
            return model;
        }
        else
        {
            return null;
        }
        
    }

    [HttpDelete]
    [Route("{id:int}")]
    public string Delete()
    {
        return "DELETE";
    }
}

