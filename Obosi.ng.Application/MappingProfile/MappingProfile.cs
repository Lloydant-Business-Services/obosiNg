using AutoMapper;
using Obosi.ng.Application.DTO;
using Obosi.ng.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obosi.ng.Application.MappingProfile
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Users, UserLoginDTO>();
            CreateMap<Users,UserRegistrationDTO>();
            CreateMap<Blogs, BlogDTO>().ReverseMap();
            CreateMap<News, NewsDTO>().ReverseMap();
            CreateMap<Executive, ExecutiveDTO>().ReverseMap();
            CreateMap<Menu, MenuDTO>().ReverseMap();
            CreateMap<MenuInRole, MenuInRoleDTO>().ReverseMap();
            CreateMap<MenuGroup, MenuGroupDTO>().ReverseMap();
            CreateMap<About, AboutDTO>().ReverseMap();

        }
    }
}
