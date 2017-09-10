using AutoMapper;
using VueBlog.Models;

namespace VueBlog.ModelsDtos
{
    public class MappingProfile : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "MappingProfile";
            }
        }

        public MappingProfile()
        {
            ConfigureMappings();
        }


        /// <summary>
        /// Creates a mapping between source (Domain) and destination (ViewModel)
        /// </summary>
        private void ConfigureMappings()
        {
            CreateMap<Blog, BlogDto>().ReverseMap();
            CreateMap<Post, PostDto>().ReverseMap();
        }

        //public MappingProfile()
        //{
        //    CreateMap<Blog, BlogDto>();
        //    CreateMap<Post, PostDto>();
        //}
    }
}
