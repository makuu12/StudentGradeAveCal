using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {

        [HttpGet]

        public ActionResult Index(Models.Grade m)
        {
            m.total = m.english + m.math + m.science;
            m.average = m.total / 3;

            if (m.average >= 75)
            {
                m.grade = "PASSED";
            }
            else
            {
                m.grade = "FAILED";
            }

            return View(m);


        }


    }
}