using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MicroRabbit.Banking.Api.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class BankingController : ControllerBase
	{
		private readonly IAccountService _accServ;
		private static readonly string[] Summaries = new[]
		{
			"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
		};

		private readonly ILogger<BankingController> _logger;

		public BankingController(ILogger<BankingController> logger , IAccountService accountService)
		{
			_logger = logger;
			_accServ = accountService;
		}

		[HttpGet]
		public IEnumerable<Account> Get()
		{
			return _accServ.GetAccounts();
		}
	}
}
