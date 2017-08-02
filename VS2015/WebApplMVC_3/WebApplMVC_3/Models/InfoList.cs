using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplMVC_3.Models
{
    public class InfoList
    {
        public static string RenderItem(HttpContext ctx)
        {
            var itemsList = new List<string>
            {
                "Twas brillig, and the slythy toves",
                "did gyre and gimbol in the wabe.",
                "All mimsey were the borogoves,",
                "and mome wraths outgabe.",
                "You must lose a fly to catch a trout.",
                "Try to divide your time evenly to keep others happy.",
                "There seems no plan because it is all plan.  -- C. S. Lewis",
                "The knack of flying is learning how to throw yourself at the ground and miss.",
                "Spock:  We suffered 23 casualties in that attack, Captain.",
                "Recursion: see Recursion.",
                "Not enough is being done for the apathetic.",
                "Life was a funny thing that happened to me on the way to the grave.",
                "Is it time for lunch yet?"
            };
            var rnd = new Random();
            return itemsList[rnd.Next(itemsList.Count)];
        }
    }
}