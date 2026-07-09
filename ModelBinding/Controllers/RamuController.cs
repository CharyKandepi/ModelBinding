using Microsoft.AspNetCore.Mvc;
using ModelBinding.Models;
using System.Net.Mime;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ModelBinding.Controllers
{
	public class RamuController : Controller
	{
		[HttpGet]
		public ContentResult Sitha()
		{

			ContentResult contentResult = new ContentResult();
			contentResult.Content = "HI";

			//Content("HI");
			//return new ContentResult
			//{
			//	Content = "HI",
			//	//ContentType = "text / plain"
			//};
			return contentResult;
		}

		[Route("Sri/{HeroName}")]
		public ContentResult Raju() 
		{
			var Hero_name=Request.RouteValues["HeroName"];
            var First_name =Request.Query["FName"];

			ContentResult contentResult = new ContentResult();
			contentResult.Content = "<html><body><h1>Hello "+Hero_name+ ""+First_name+", Welcome to Dot Net Tutorials</h1></body></html>";
			contentResult.ContentType = "text/html";

			return contentResult;

        }

		public ContentResult EX_XML()

		{
			return Content("<?xml version=\"1.0\" encoding=\"UTF-8\"?><Soumya><SRINU>I AM SRINU</SRINU><Akhila>Hello Dot Net Tutorials</Akhila></Soumya>", "application/xml");
		}
        public ContentResult EX_Json()

        {
           string HI= """{"id": 101, "name": "Alice Johnson"}""";
            return Content(HI, "application/json");
        }

		[HttpPost]
        public ContentResult EX_Json([FromQuery]string Rani, [FromQuery] int ID )

        {
            string HI = $@"{{""id"":'""{ID} ""', ""name"":'"" {Rani}""'}}";
            return Content(HI, "application/json");
        }


		public JsonResult JsonResult()
		{

            //return Json("{\"ID\":102,\"Name\":\"Raju\" }");
            JsonResult obj = new JsonResult($@"{{""ID"":102,""Name"":""Raju"" }}");
			return  new JsonResult($@"{{""ID"":102,""Name"":""Raju"" }}");

            //var obj = new { "ID" };

            //return $@"{{""ID"":102,""Name"":""Raju"" }}";



        }

		[Route("HI/{RANI}/{id}")]
        public JsonResult JsonResult2([FromRoute]string RANI, [FromRoute] int ID )
        {
            //anonymous object
            var employee = new { Id = 101, Name = "Alice", Department = "IT",Gender ="Male"};




			var employee1 = new Employee { Id = ID, Name = RANI, Gender = "Male"  };


            JsonResult obj = new JsonResult(employee);

            JsonResult obj1 = new JsonResult(employee1);


            //var obj = new { "ID" };

            return obj1;



        }

    }
}
