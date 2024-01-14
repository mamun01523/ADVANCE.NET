using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AL.Controllers
{
    public class SExamController : ApiController
    {
        [HttpGet]
        [Route("api/student1/exams")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = ExamService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/student1/exams/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = ExamService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
