using AutoMapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.Models;
using TaskAPI.Service.Models;

namespace TaskAPI.Service.Profiles
{
    public class AuthorProfile : Profile
    {
        public AuthorProfile()
        {
            CreateMap<Aurthor, AuthorDto>()
                .ForMember(dest => dest.Address,
                opt => opt.MapFrom(src => $"{src.AddressNo}, {src.Street}, {src.City}"));
        }
    }
}
