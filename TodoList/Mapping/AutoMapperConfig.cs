using AutoMapper;

namespace TodoList.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {

        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperConfig>();
            }, loggerFactory);

            //configuration.map

            configuration.AssertConfigurationIsValid();

            var mapper = new Mapper(configuration, sp => loggerFactory.CreateLogger("AutoMapper"));
        }
    }
}