using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Data;
using JsonApiDotNetCore.Services;
using Microsoft.Extensions.Logging;
using TodoListAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace TodoListAPI.Controllers
{
    [Route("api/v1/[controller]")]
    public class PeopleController : JsonApiController<Person>
    {
         public PeopleController(
            IJsonApiContext jsonApiContext,
            IResourceService<Person> resourceService,
            ILoggerFactory loggerFactory) 
            : base(jsonApiContext, resourceService, loggerFactory)
        { }
    }
}