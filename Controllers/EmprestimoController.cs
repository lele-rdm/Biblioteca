﻿using Biblioteca.Data;
using Biblioteca.Models;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Controllers
{
    public class EmprestimoController : Controller
    {
        readonly private ApplicationDbContext _db;

        public EmprestimoController(ApplicationDbContext db) 
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<EmprestimosModel> emprestimos = _db.Emprestimos;

            return View(emprestimos);
        }
    }
}