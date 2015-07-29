using System;
using System.Linq;
using Microsoft.AspNet.Mvc;
using Animal.Db;
using AnimalWeb.Db;

namespace AnimalWeb.Controllers
{
    public class DogeController : Controller
    {
        private readonly AnimalModel context;

        public DogeController(AnimalModel context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var model = this.context.Dogs.ToArray();

            return View(model);
        }

        [HttpPost]
        public JsonResult FeedDoge(int dogId)
        {
            try
            {
                var dog = this.context.Dogs.FirstOrDefault(d => d.DogId == dogId);
                if (dog == null)
                {
                    return new JsonResult(null);
                }

                dog.CurrentClickCount++;
                if (dog.CurrentClickCount >= dog.TargetClickCount)
                {
                    dog.Bowls.Add(new Bowl() { DogId = dog.DogId, ClickCount = dog.CurrentClickCount, Date = DateTime.Now });
                    dog.CurrentClickCount = 0;
                }

                this.context.SaveChanges();

                return Json(new DogDto
                {
                    Bowls = dog.Bowls.Count,
                    CurrentClickCount = dog.CurrentClickCount,
                    Description = dog.Description,
                    DogId = dog.DogId,
                    HappyImg = dog.HappyImg,
                    Name = dog.Name,
                    SadImg = dog.SadImg,
                    SponsorLogo = dog.SponsorLogo,
                    TargetClickCount = dog.TargetClickCount
                });
            }
            catch (Exception)
            {
                return new JsonResult(null);
            }
            
        }
    }
}
