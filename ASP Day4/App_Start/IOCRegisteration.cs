using Autofac;
using Autofac.Integration.Mvc;
using ASP_Day4.DB;
using ASP_Day4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_Day4.App_Start
{
    public class IOCRegisteration
    {
        public static void RegisterIOC()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<StudentRepository>().As<IStudentRepository>().SingleInstance(); 
            builder.RegisterType<SQLContext>().As<IStudentContext>();
            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
        

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

    }
}