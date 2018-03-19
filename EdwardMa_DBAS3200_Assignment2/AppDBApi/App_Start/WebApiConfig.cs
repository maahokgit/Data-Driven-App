using AppDBDatalayer.Models;
using System.Linq;
using System.Web.Http;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;

namespace AppDBApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Filter()
                  .Expand()
                  .Select()
                  .OrderBy()
                  .MaxTop(null)
                  .Count();

            ODataModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<Applicant>("Applicants");
            builder.EntitySet<Application>("Applications");
            builder.EntitySet<Campus>("Campuses");
            builder.EntitySet<Citizenship>("Citizenships");
            builder.EntitySet<Country>("Countries");
            builder.EntitySet<Gender>("Genders");
            builder.EntitySet<Program>("Programs");
            builder.EntitySet<ProgramChoice>("ProgramChoices");
            builder.EntitySet<ProvinceState>("ProvinceStates");
            config.MapODataServiceRoute(
                routeName: "ODataRoute",
                routePrefix: null,
                model: builder.GetEdmModel());
        }
    }
}
