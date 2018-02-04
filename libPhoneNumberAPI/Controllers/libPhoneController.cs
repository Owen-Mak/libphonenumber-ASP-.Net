using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PhoneNumbers;

namespace libPhoneNumberAPI.Controllers
{
    public class libPhoneController : ApiController
    {
       /* // GET: api/libPhone
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }*/

        // GET: api/libPhone/5
        [Route("Api/libPhone/GetString/{value}")]
        public IHttpActionResult Get(string value)
        {
            value = System.Web.HttpContext.Current.Server.UrlDecode(value);
            var util = PhoneNumberUtil.GetInstance();
            if (string.IsNullOrEmpty(value))
            {
                return BadRequest();
            }
            try
            {
                var number = util.Parse(value, "CA");


                if (util.IsValidNumber(number))
                {
                    return Ok(util.FormatInOriginalFormat(number, "CA"));
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

        // POST: api/libPhone
        public IHttpActionResult Post([FromBody]string value)
        {
            var util = PhoneNumberUtil.GetInstance();
            if (string.IsNullOrEmpty(value))
            {
                return BadRequest();
            }
            try
            {
                var number = util.Parse(value, "CA");


                if (util.IsValidNumber(number))
                {
                    return Ok(util.FormatInOriginalFormat(number, "CA"));
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
        /*
        // PUT: api/libPhone/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/libPhone/5
        public void Delete(int id)
        {
        }*/
    }
}
