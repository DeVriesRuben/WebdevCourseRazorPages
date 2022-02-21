using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Routing;

namespace Exercises.Pages.Lesson1
{
    //public class ProductConstraint : IRouteConstraint
    //{
    //    public bool Match(HttpContext httpContext, IRouter route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
    //    {
    //        return values[routeKey]?.ToString().ToLowerInvariant();
    //    }
    //}

    public class Assignment4 : PageModel
    {
        public string Category { get; set; }
        public string Subcategory { get; set; }
        public string ProductID { get; set; }

        public void OnGet([FromRoute] string category, [FromRoute] string subcategory, [FromRoute] string productid)
        {
            Category = category;

            if (!string.IsNullOrWhiteSpace(subcategory))
            {
                Subcategory = subcategory;
            }
            else
            {
                Subcategory = "Geen subcategory";
            }

            if (!string.IsNullOrWhiteSpace(productid))
            {
                ProductID = productid;
            }
            else
            {
                ProductID = "Geen productID";
            }
        }
    }
}
