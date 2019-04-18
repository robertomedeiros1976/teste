using Microsoft.AspNetCore.Mvc;
using FullstackDeveloperAssessment.Logic.Logics;
using FullstackDeveloperAssessment.Domain.Entyties;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace FullstackDeveloperAssessment.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PersonController : ControllerBase
	{
		private PersonLogic _personLogic;
		private PersonTypeLogic _personTypeLogic;
		

		public PersonController(PersonLogic personLogic, PersonTypeLogic personTypeLogic)
		{
			this._personLogic = personLogic;
			this._personTypeLogic = personTypeLogic;
		}

		[HttpGet]		
		public ActionResult<string> Get()
		{
			return "Hello boy!!";
		}

		//[HttpGet]		
		//public IActionResult Get()
		//{
		//	try
		//	{
		//		return Ok(this._personTypeLogic.SelectAllPersonTypes());
		//	}
		//	catch (Exception ex)
		//	{
		//		return BadRequest(ex.Message);
		//	}
		//}

		[HttpGet("{id}")]
		public IActionResult Get(int Id)
		{
			try
			{
				return Ok(this._personLogic.GetById(Id));
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}

		[HttpPost]
		[ProducesResponseType(typeof(Domain.Entyties.Person), StatusCodes.Status201Created)]
		public async Task<IActionResult> CreateAsync([FromBody] Domain.Entyties.Person person)
		{
			await _personLogic.SavePerson(person);

			return CreatedAtAction(nameof(Get), new { Id = person.VAT }, person);
		}
	}
}
