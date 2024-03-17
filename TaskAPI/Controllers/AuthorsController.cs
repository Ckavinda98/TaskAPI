using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Net;
using TaskAPI.Service.Authors;
using TaskAPI.Service.Models;

namespace TaskAPI.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorRepository _service;
        private readonly IMapper _mapper;  

        public AuthorsController(IAuthorRepository service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult<ICollection<AuthorDto>> GetAuthors()
        {
            
            var authors = _service.GetAllAuthors();
            var mapperAuthor = _mapper.Map<ICollection<AuthorDto>>(authors);

            
                
            
            return Ok(mapperAuthor);
        }

        [HttpGet("{id}")]
        public IActionResult GetAthor(int id)
        {
            var author = _service.GetAuthor(id);

            if(author is null)
            {
                return NotFound();
            }

            var mappedAuthor = _mapper.Map<AuthorDto>(author);

            return Ok(mappedAuthor);
        }
    }
}
