namespace PersonalPortfolio.AutoMapper
{
    public class PersonalInfoMapper : Profile
    {
        public PersonalInfoMapper()
        {
            CreateMap<PersonalInfo, PersonalInfoVModel>().ReverseMap();
        }

    }
}
