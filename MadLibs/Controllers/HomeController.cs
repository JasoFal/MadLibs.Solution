using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/form")]
    public ActionResult Form() { return View(); }
    [Route("/madlibview")]
    public ActionResult MadLibView(string nounone, string adjectiveone, string verbone, string verbtwo, string adjectivetwo, string adverb, string verbthree, string nountwo)
    {
      WordVariables myWordVariable = new WordVariables();
      myWordVariable.NounOne = nounone;
      myWordVariable.AdjectiveOne = adjectiveone;
      myWordVariable.VerbOne = verbone;
      myWordVariable.VerbTwo = verbtwo;
      myWordVariable.AdjectiveTwo = adjectivetwo;
      myWordVariable.Adverb = adverb;
      myWordVariable.VerbThree = verbthree;
      myWordVariable.NounTwo = nountwo;
      return View(myWordVariable);
    }
  }
}