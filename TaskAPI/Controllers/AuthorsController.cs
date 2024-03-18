using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Net;
using TaskAPI.Models;
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
        public ActionResult<ICollection<AuthorDto>> GetAllAuthors(string job = null, string search = null)
        {

            
            
            var authors = _service.GetAllAuthors(job, search);
            var mapperAuthor = _mapper.Map<ICollection<AuthorDto>>(authors);

            
                
            
            return Ok(mapperAuthor);
        }

        [HttpGet("{id}", Name = "GetAuthor")] // Corrected "GetAuthor" spelling
        public IActionResult GetAuthor(int id) // Corrected "GetAuthor" spelling
        {
            var author = _service.GetAuthor(id);

            if (author is null)
            {
                return NotFound();
            }

            var mappedAuthor = _mapper.Map<AuthorDto>(author);

            return Ok(mappedAuthor);
        }

        [HttpPost]
        public ActionResult<AuthorDto> CreateAuthor(CreateAuthorDto author)
        {
            var authorEntity = _mapper.Map<Aurthor>(author);
            var newAuthor = _service.AddAuthor(authorEntity);

            var authorForReturn = _mapper.Map<AuthorDto>(newAuthor); // Corrected variable name

            return CreatedAtRoute("GetAuthor", new { id = authorForReturn.Id }, // Corrected "Id" property name
                authorForReturn);
        }

    }
}
