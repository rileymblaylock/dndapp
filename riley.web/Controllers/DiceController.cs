using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using riley.domain.contracts;

namespace riley.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiceController : ControllerBase
    {
        IRollDice diceRoller;

        public DiceController(IRollDice diceRoller)
        {
            this.diceRoller = diceRoller;
        }

        // GET api/values
        public ActionResult<int> GetRoll()
        {
            return diceRoller.RollDie(20);
        }

        // GET api/values/{numsides}
        [HttpGet("{numSides}")]
        public ActionResult<int> GetRoll(int numSides)
        {
            return diceRoller.RollDie(numSides);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
