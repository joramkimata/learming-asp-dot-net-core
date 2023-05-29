using BulkWeb.Data;
using Microsoft.AspNetCore.Mvc;

namespace BulkWeb.Controllers;

public class CategoryController : Controller
{
    private readonly ApplicationDbContext _db;
    public CategoryController(ApplicationDbContext db)
    {
        _db = db;
    }
    // GET
    public IActionResult Index()
    {
        var objCatList = _db.Categories.ToList();
        return View(objCatList);
    }

    public IActionResult Create()
    {
        return View();
    }
}