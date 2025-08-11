using Microsoft.AspNetCore.Mvc;
using WebApp_Demo.Models;

namespace WebApp_Demo.Controllers
{
    public class TreeController : Controller
    {
        public IActionResult Index()
        {
            List<MyTree> ListofTrees = new List<MyTree>();
            ListofTrees.Add(new MyTree { Id = 1, Name = "Oak", Description = "A large tree with a thick trunk.", TreeCount = 10 });
            ListofTrees.Add(new MyTree { Id = 2, Name = "Pine", Description = "A coniferous tree with needle-like leaves.", TreeCount = 5 });
            ListofTrees.Add(new MyTree { Id = 3, Name = "Maple", Description = "A tree known for its vibrant fall colors.", TreeCount = 8 });
            ListofTrees.Add(new MyTree { Id = 4, Name = "Birch", Description = "A tree with distinctive white bark.", TreeCount = 6 });
            ListofTrees.Add(new MyTree { Id = 5, Name = "Cherry", Description = "A tree known for its beautiful blossoms.", TreeCount = 4 });

            ViewData["all_trees"] = ListofTrees;

            return View(ListofTrees);
        }

        public IActionResult Details()
        {
            var tree1 = new MyTree
            {
                Id = 1,
                Name = "Neam",
                Description = "A large tree with a thick trunk.",
                TreeCount = 10
            };
            return View(tree1);
        }
    }
}
