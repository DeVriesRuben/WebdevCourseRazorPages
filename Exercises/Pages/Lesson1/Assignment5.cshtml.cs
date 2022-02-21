using Exercises.Pages.Lesson1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System;

namespace Exercises.Pages.Lesson1
{
    public class Assignment5 : PageModel
    {
        public class MoodCounter
        {
            
            public int Happy { get; set; } = 0;
            
            public int Disappointed { get; set; } = 0;
            
            public int Angry { get; set; } = 0;
        }

        public MoodCounter moodCounter {get; set; } = new MoodCounter();

        public void OnPost(string action = " ")
        {
            string moodStr = Request.Cookies["moodCounter"];

            if (moodStr == null) //cookie is not set (first time request or after reset)
            {
                Response.Cookies.Append("moodCounter", JsonConvert.SerializeObject(moodCounter), new CookieOptions()
                {
                    Expires = DateTimeOffset.Now.AddDays(30)
                });
            }
            else
            {
                MoodCounter deserializedMoodCounter = JsonConvert.DeserializeObject<MoodCounter>(moodStr); //deserialize
                moodCounter = deserializedMoodCounter;

                if (action == "happyInc")
                {
                    moodCounter.Happy++;                   
                }
                else if (action == "disappointedInc")
                {
                    moodCounter.Disappointed++;                  
                }
                else if (action == "angryInc")
                {
                    moodCounter.Angry++;
                }
                else if (action == "delete")
                {
                    moodCounter.Happy = 0;
                    moodCounter.Angry = 0;
                    moodCounter.Disappointed = 0;
                    Response.Cookies.Delete("moodCounter");
                }
                //Response.Cookies.Append("moodCounter", JsonConvert.SerializeObject(moodCounter));
            }

            Response.Cookies.Append("moodCounter", JsonConvert.SerializeObject(moodCounter));
        }
    }
}
