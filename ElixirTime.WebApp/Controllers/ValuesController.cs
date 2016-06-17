using System.Collections.Generic;
using System.Web.Http;
using ElixirTime.WebApp.Models;

namespace ElixirTime.WebApp.Controllers
{
    public class ValuesController : ApiController
    {
        [Route("api/GetBanks")]
        public IEnumerable<BankBaseModel> GetBanks()
        {
            return BanksLogic.GetBankList();
        }

        [Route("api/GetElixirTime")]
        public IHttpActionResult Post([FromBody]TransferModel incommingModel)
        {
            var elixirTime = BanksLogic.CalculateEliksirTime(incommingModel);
            return Ok(new { TransferTime = elixirTime });
        }
    }
}
