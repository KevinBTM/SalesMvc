﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
{
	public class DepartmentsController : Controller
	{
		public IActionResult Index()
		{
			List<Department> list = new List<Department>();
			list.Add(new Department { Id = 1, Name = "Eletrônicos" });
			list.Add(new Department { Id = 2, Name = "Perfumaria" });
			return View(list);
		}
	}
}
