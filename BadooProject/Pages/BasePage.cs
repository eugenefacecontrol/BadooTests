﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BadooProject.Utils;
using OpenQA.Selenium.Support.PageObjects;

namespace BadooProject.Pages
{
    public class BasePage
    {
        public BasePage()
        {
            PageFactory.InitElements(Browser.WebDriver, this);
        }
    }
}