using FullstackDeveloperAssessment.Domain.Entyties;
using FullstackDeveloperAssessment.Logic.Logics;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace FullstackDeveloperAssessment.Controllers
{
	[EnableCors("CorsPolicy")]
	[Route("api/[Controller]")]	
	[ApiController]
	public class PersonController : Controller
	{
		private PersonLogic _personLogic;
		private PersonTypeLogic _personTypeLogic;

		public PersonController(PersonLogic personLogic, PersonTypeLogic personTypeLogic)
		{
			this._personLogic = personLogic;
			this._personTypeLogic = personTypeLogic;
		}

		[HttpGet]
		[Route("sayhello")]
		public string SayHello()
		{
			return "Hello boy!!";
		}

		[HttpGet]
		[Route("persons")]
		public IActionResult Get()
		{
			try
			{
				return Ok(this._personTypeLogic.SelectAllPersonTypes());
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}

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
		[ProducesResponseType(typeof(Person), StatusCodes.Status201Created)]
		public async Task<IActionResult> CreateAsync([FromBody] Person person)
		{
			await _personLogic.SavePerson(person);

			return CreatedAtAction(nameof(Get), new { Id = person.VAT }, person);
		}
	}
}
