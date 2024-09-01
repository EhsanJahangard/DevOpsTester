using FluentValidation;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NotificationApplication.Common.Behaviors;
using NotificationApplication.Validators;
using SharpGrip.FluentValidation.AutoValidation.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NotificationApplication;

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
        #region FluentValidation
        //این روش مناسب و بروز هستش.
        services.AddFluentValidationAutoValidation().AddValidatorsFromAssemblyContaining<SendSmsCommandValidator>();
        #endregion

    }
}