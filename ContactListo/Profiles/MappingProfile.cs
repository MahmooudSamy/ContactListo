using AutoMapper;
using ContactListo.DataAccess.DTO;
using ContactListo.Domain;

namespace ContactListo.Profiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Contact, ContactDto>().ReverseMap();
            CreateMap<UserModel, UserDto>().ReverseMap();
        }
    }
}
