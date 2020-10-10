﻿using LoggerLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmpPracWebApp.Controllers
{
    public class BaseController : Controller
    {
        private ILog _log;
        public BaseController()
        {
            _log = Log.GetInstance;
        }
        protected override void OnException(ExceptionContext filterContext)
        {
            _log.LogException(filterContext.Exception.ToString());
            filterContext.ExceptionHandled = true;
            this.View("Error").ExecuteResult(this.ControllerContext);
        }

    }
}