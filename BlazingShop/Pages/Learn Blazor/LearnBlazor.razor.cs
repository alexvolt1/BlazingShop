using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Pages.Learn_Blazor
{
    public class LearnBlazorBase:ComponentBase
    {
        protected string name = "Alex";
        protected string welcomeText = "Time to learn Blazor!";
        protected void getName()
        {
            name = "Blazor Learner";
        }
    }
}
