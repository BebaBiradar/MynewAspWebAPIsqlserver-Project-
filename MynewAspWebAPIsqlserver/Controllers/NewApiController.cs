using MynewAspWebAPIsqlserver.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MynewAspWebAPIsqlserver.Controllers
{
    public class NewApiController : ApiController
    {
        practiceEntities db = new practiceEntities();
        [System.Web.Http.HttpGet]
        //public IHttpActionResult Action()

        //{
        //List<student> obj = db.students.ToList();
        //return Ok(obj);
        //}
        //OR
        
        public IHttpActionResult Index()
             {
              List<student> obj = db.students.ToList();
              return Ok(obj);
            }
        [System.Web.Http.HttpGet]
        //this method returns only one records
        public IHttpActionResult Index(int id)
        {
            var obj = db.students.Where(model => model.std_id == id).FirstOrDefault();
            return Ok(obj);
        }
    }

}

  




