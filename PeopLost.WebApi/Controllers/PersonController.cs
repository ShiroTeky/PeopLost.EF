using PeopLost.Service.Alertes;
using PeopLost.Service.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApplication1.Controllers
{
    [EnableCors(origins: "http://localhost:54978", headers: "*", methods: "*")]
    public class PersonController : ApiController
    {
        private IAlertService _alertservice;
        private IPersonService _personservice;

        //List<AlertModels> listmodels;
        public PersonController(IAlertService AlertService,IPersonService PersonService)
        {
            _alertservice = AlertService;
            _personservice = PersonService;
        }

        // GET: api/Person/5
        //public HttpResponseMessage Get(string id )
        //{
        //    Guid userguid = Guid.Parse(id);
        //    return _alertservice.GetMyPersons(alertguid);
        //}

    }
}
