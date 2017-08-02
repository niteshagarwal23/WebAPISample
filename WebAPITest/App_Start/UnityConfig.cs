using Microsoft.Practices.Unity;
//using System.Web.Http;
//using Unity.WebApi;
using WebAPITest.Database;
using WebAPITest.Models;
using WebAPITest.Repository;
using WebAPITest.Services;

namespace WebAPITest
{
    public static class UnityConfig
    {
        public static UnityContainer RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            
            container.RegisterType<IEmployeeRepository, EmployeeRepository>();
            container.RegisterType<IEmployeeManager, EmployeeManager>();
            container.RegisterType<IDataTable<Employee>, EmployeeDataTable>();

            return container;

            //GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}