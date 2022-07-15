using CRUD_MVC_DOTNET6.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CRUD_MVC_DOTNET6.Controllers
{
    public class EntireNameController : Controller
    {
        EntireName entireName = new EntireName();

        public IActionResult Index()
        {
            entireName.Operations = new List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem>();
            entireName.Operations.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = "Add", Value = "Add" });
            entireName.Operations.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = "Sub", Value = "Sub" });
            entireName.Operations.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = "Mul", Value = "Mul" });
            entireName.Operations.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = "Div", Value = "Div" });
            return View(entireName);
        }
        [HttpPost]
        public IActionResult Index(EntireName entireName)
        {
            if (entireName.Operation == "A")
            {
                entireName.Result = entireName.Add(entireName.FirstNumber, entireName.SecondNumber);
            }
            if (entireName.Operation == "S")
            {
                entireName.Result = entireName.Sub(entireName.FirstNumber, entireName.SecondNumber);
            }
            if (entireName.Operation == "M")
            {
                entireName.Result = entireName.Mul(entireName.FirstNumber, entireName.SecondNumber);
            }
            if (entireName.Operation == "D")
            {
                entireName.Result = entireName.Div(entireName.FirstNumber, entireName.SecondNumber);
            }
            if (entireName.Operation == "R")
            {
                entireName.Result = entireName.Rem(entireName.FirstNumber, entireName.SecondNumber);
            }
            return View(entireName);
        }

    }
}
/*
if (entireName.Operation == "A")
{
    entireName.Result = entireName.FirstNumber + entireName.SecondNumber;
}
if (entireName.Operation == "S")
{
    entireName.Result = entireName.FirstNumber - entireName.SecondNumber;
}
if (entireName.Operation == "M")
{
    entireName.Result = entireName.FirstNumber * entireName.SecondNumber;
}
if (entireName.Operation == "D")
{
    entireName.Result = entireName.FirstNumber / entireName.SecondNumber;
}
if (entireName.Operation == "R")
{
    entireName.Result = entireName.FirstNumber % entireName.SecondNumber;
}
*/