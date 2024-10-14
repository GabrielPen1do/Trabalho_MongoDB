using CadastroUsuarios.Models;
using CadastroUsuarios.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CadastroUsuarios.Controllers
{
	public class UsersController : Controller
	{

		private readonly RegisterService _registerService;

		public UsersController(RegisterService registerService) =>
			_registerService = registerService;

		public async Task<IActionResult> TotalUsersCount()
		{
			var count = await _registerService.GetTotalUsersCountAsync(); 
			return Json(new { Count = count });
		}


		[HttpGet]
		public async Task<IActionResult> Index()
		{
			var users = await _registerService.GetAsync();
			return View(users);
		}


		[HttpGet("{id:length(24)}")]
		public async Task<ActionResult> Details(string id)
		{
			var users = await _registerService.GetAsync(id);

			if (users is null)
			{
				return NotFound();
			}

			return View();
		}

		[HttpGet("create")]
		public IActionResult Create()
		{
			return View();
		}


		[HttpPost("create")]
		public async Task<IActionResult> Create(Users newUser)
		{

			if (!ModelState.IsValid)
			{
				return View(newUser);
			}
			await _registerService.CreateAsync(newUser);

			return RedirectToAction(nameof(Index));
		}

		[HttpGet("edit/{id:length(24)}")]
		public async Task<IActionResult> Edit(string id)
		{
			var user = await _registerService.GetAsync(id);

			if (user is null)
			{
				return NotFound();
			}

			return View(user);
		}


		[HttpPost("edit/{id:length(24)}")]
		public async Task<IActionResult> Edit(string id, Users updateUser)
		{
			if (!ModelState.IsValid)
			{
				return View(updateUser);
			}

			var user = await _registerService.GetAsync(id);

			if (user is null)
			{
				return NotFound();
			}

			updateUser.Id = user.Id;

			await _registerService.UpdateAsync(id, updateUser);

			return RedirectToAction(nameof(Index));
		}

		[HttpPost("delete/{id:length(24)}")]
		public async Task<IActionResult> Delete(string id)
		{
			var user = await _registerService.GetAsync(id);

			if (user is null)
			{
				return NotFound();
			}

			await _registerService.RemoveAsync(id);

			return RedirectToAction(nameof(Index));
		}

	}
}
