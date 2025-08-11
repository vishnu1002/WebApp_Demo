using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using WebApp_Demo.Models;

namespace WebApp_Demo.Controllers
{
    public class TreeController : Controller
    {
        List<MyTree> ListofTrees = new List<MyTree>();

        public TreeController()
        {
            ListofTrees.Add(new MyTree { Id = 1, Name = "Oak", Description = "A large tree with a thick trunk.", TreeCount = 10 });
            ListofTrees.Add(new MyTree { Id = 2, Name = "Pine", Description = "A coniferous tree with needle-like leaves.", TreeCount = 5 });
            ListofTrees.Add(new MyTree { Id = 3, Name = "Maple", Description = "A tree known for its vibrant fall colors.", TreeCount = 8 });
            ListofTrees.Add(new MyTree { Id = 4, Name = "Birch", Description = "A tree with distinctive white bark.", TreeCount = 6 });
            ListofTrees.Add(new MyTree { Id = 5, Name = "Cherry", Description = "A tree known for its beautiful blossoms.", TreeCount = 4 });
        }

        public IActionResult Index()
        {
            return View(ListofTrees);
        }

        [Route("Tree/Details/{name}")]
        //[Route("Tree/details/{name}")]
        public IActionResult Details(string name)
        {
            var tree1 = ListofTrees.FirstOrDefault(x => x.Name == name);

            if (tree1 == null)
            {
                return NotFound();
            }

            return View(tree1);
        }

        public IActionResult Form(MyTree mytree)
        {
            return View();
        }

        public IActionResult AddTreeResult(MyTree tree)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
