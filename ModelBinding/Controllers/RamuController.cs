using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ModelBinding.Controllers
{
	public class RamuController : Controller
	{
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


		public ContentResult Raju() 
		{ 


			ContentResult contentResult = new ContentResult();
			contentResult.Content = "<html><body><h1>Hello, Welcome to Dot Net Tutorials</h1></body></html>";
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

    }
}
