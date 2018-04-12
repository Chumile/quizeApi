using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace quiz_backend.Controllers
{
    [Produces("application/json")]
    [Route("api/Question")]
    public class QuestionController : Controller
    {
        readonly QuizContext context;
        public QuestionController(QuizContext context)
        {
            this.context = context;  
        }
        [HttpGet]
        public IEnumerable<Models.Questions> Get()
        {
            return new Models.Questions[]
            {
                new Models.Questions() {Text = "Hello"},
                new Models.Questions() {Text = "Hi"}
            };
        }

        [HttpPost]
        public void Post([FromBody] Models.Questions question)
        {
            context.Questions.Add(new Models.Questions() { Text = "test" });
            context.SaveChanges();
        }

       
    }
}