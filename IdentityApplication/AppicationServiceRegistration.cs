using IdentityApplication.Validators.Command.Login;
using IdentityApplication.Validators.Command.User;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using SharpGrip.FluentValidation.AutoValidation.Mvc.Extensions;
using FluentValidation;
using MediatR;
using IdentityApplication.Common.Behaviors;
namespace IdentityApplication;

public static class AppicationServiceRegistration
{
    public static void ConfigureApplicationServices(this IServiceCollection services, IConfiguration configuration)
    {
        
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
        services.AddFluentValidationAutoValidation().AddValidatorsFromAssemblyContaining<LoginCommandValidator>();
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
