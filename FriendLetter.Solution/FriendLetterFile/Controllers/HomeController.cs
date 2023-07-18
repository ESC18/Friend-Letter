using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
    public class HomeController : Controller
    {
        [Route("/Yes")]
        public string Hello() { return "hello friend!"; }

        [Route("/No")]
        public string Goodbye() { return "Goodbye friend."; }

        [Route("/Form")]
        public ActionResult Form() { return View(); }

        [Route("/")]
        public ActionResult Letter()
        {
            LetterVariable myLetterVariable = new LetterVariable();
            myLetterVariable.Recipient = "Lina";
            myLetterVariable.Sender = "Steve";
            return View(myLetterVariable);
        }
        [Route("/Postcard")]
        public ActionResult Postcard(string recipient, string sender)
        {
            LetterVariable myLetterVariable = new LetterVariable();
            myLetterVariable.Recipient = recipient;
            myLetterVariable.Sender = sender;
            return View(myLetterVariable);
        }
    }
}