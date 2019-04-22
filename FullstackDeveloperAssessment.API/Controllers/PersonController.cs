using Microsoft.AspNetCore.Mvc;
using FullstackDeveloperAssessment.Logic.Interfaces;
using System;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace FullstackDeveloperAssessment.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PersonController : ControllerBase
	{
		protected IPersonLogic _personLogic;
		protected IPersonTypeLogic _personTypeLogic;

		public PersonController(IPersonLogic personLogic, IPersonTypeLogic personTypeLogic)
		{
			this._personTypeLogic = personTypeLogic;
			this._personLogic = personLogic;			
		}


		[HttpGet]
		public IActionResult Get()
		{
			try
			{
				var persons = this._personLogic.SelectAllPerson();				
				return Ok(persons);
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
		[ProducesResponseType(typeof(Domain.Entyties.Person), StatusCodes.Status201Created)]
		public async Task<IActionResult> CreateAsync([FromBody] Domain.Entyties.Person person)
		{
			await _personLogic.SavePerson(person);

			return CreatedAtAction(nameof(Get), new { Id = person.VAT }, person);
		}
	}
}
