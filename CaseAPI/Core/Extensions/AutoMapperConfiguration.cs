using AutoMapper;

namespace CaseAPI.Core.Extensions
{
    public static class AutoMapperConfiguration
    {
        public static void AutoMapperConfig(this IServiceCollection serviceCollection, MapperConfiguration mapperConfiguration)
        {
            IMapper mapper = mapperConfiguration.CreateMapper();
            serviceCollection.AddSingleton(mapper);
        }
    }
}
