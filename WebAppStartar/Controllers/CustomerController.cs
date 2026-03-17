using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace WebAppStartar.Contorlllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        // public string Create()
        // {
        //     return "Customer Created";
        // }

        public IActionResult Create()
        {
            return Content("Customer Created");
        }

        //JSON Result

        public IActionResult GetCustomer()
        {
            var customer = new 
            { 
                Id = 1, 
                Name = "John Doe", 
                Email = "john.doe@example.com",
                Address = new 
                {
                    Street = "123 Main St",
                    City = "Anytown",
                    State = "CA",
                    ZipCode = "12345"
                }
            };
            return Json(customer);
        }

        //Redirect Result

        public IActionResult Edit()
        {
            // Perform edit operations here
            //return RedirectToAction("Privacy", "Home");
            return RedirectToAction("Index");
        }

        //Status Code Result

        public IActionResult Delete()
        {
            // Perform delete operations here
            return StatusCode(500); // No Content
        }

        public string Details(int id)
        {
            if(id <= 0)
            {
                return "Invalid Customer ID";
            }
            return $"Customer Details for ID: {id}";
        }
    }

    
}