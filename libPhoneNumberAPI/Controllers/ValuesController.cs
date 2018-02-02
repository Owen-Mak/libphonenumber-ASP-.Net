using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PhoneNumbers;

namespace libPhoneNumberAPI.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public IHttpActionResult Post([FromBody]string value)
        {
            var util = PhoneNumberUtil.GetInstance();
            if (string.IsNullOrEmpty(value)){
                return BadRequest();
            }
            try
            {
                var number = util.Parse(value, "CA");

                
                if (util.IsValidNumber(number))
                {
                    return Ok(util.FormatInOriginalFormat(number,"CA"));
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (NumberParseException)
            {
                return BadRequest();
            }

          
            
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
