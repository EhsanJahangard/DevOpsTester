//using FluentValidation;
//using FluentValidation.AspNetCore;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SharpGrip.FluentValidation.AutoValidation.Mvc.Extensions;
using System.Reflection;
using TestApplication.Common.Behaviors;
using TestApplication.Validators.Level;

namespace TestApplication;
public static class AppicationServiceRegistration
{
    public static void ConfigureApplicationServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly());
            //Behavior for MediatR
            cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
            cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(RequestPerformanceBehavior<,>));
            //cfg.AddOpenRequestPostProcessor(typeof(LoggingPostProcessor<,>));
            //cfg.AutoRegisterRequestProcessors = false;
        }
        );
        //or add thease lines for add Behavior for MediatR
        // services.AddTransient(typeof(IRequestPostProcessor<,>), typeof(PostHandler<,>));
        // services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
        // services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestPerformanceBehavior<,>));


        #region FluentValidation
        //این روش مناسب و بروز هستش.
        services.AddFluentValidationAutoValidation().AddValidatorsFromAssemblyContaining<LevelCommandValidator>();
        //نیازی به اضافه کردن این دوتا خط نیست
        //services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        //services.AddValidatorsFromAssemblyContaining<LevelCommandValidator>();
        //برای fluentValidation همین دو تا خط کافیه(این روش هم نسوخ شده است)
        //1)
        //services.AddControllers().AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<LevelCommandValidator>());
        //2)
        //services.
        //   AddControllers().
        //   AddFluentValidation(v =>
        //   {
        //       v.ImplicitlyValidateChildProperties = true;
        //       v.ImplicitlyValidateRootCollectionElements = true;
        //       v.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        //   });

        #endregion



        


    }
}