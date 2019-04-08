using FullstackDeveloperAssessment.Domain.Entyties;
using FullstackDeveloperAssessment.Logic.Logics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FullstackDeveloperAssessment.Controllers
{
	[Route("api/[Controller]")]
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
	}
}
