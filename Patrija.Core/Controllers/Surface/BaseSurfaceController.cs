﻿using System.Web.Mvc;
using Umbraco.Web.Mvc;
using Patrija.Core.Contexts;
using Patrija.Core.Extensions;
using System;

namespace Patrija.Core.Controllers.Surface
{
	public abstract class BaseSurfaceController : SurfaceController
	{
		protected ISiteContext CreateSiteContext()
			=> Umbraco.CreateSiteContext();

        protected ActionResult RenderActionResult<T>(T model, Func<ActionResult> callback) where T : class
        {
            if (model == default(T)) return new EmptyResult();
            return callback.Invoke();
        }
        /// <summary>
        /// Called when an unhandled exception occurs on a controller level (during action processing).
        /// </summary>
        /// <param name="filterContext">Information about the current request.</param>
        protected override void OnException(ExceptionContext filterContext)
        {
            if (filterContext.ExceptionHandled)
            {
                return;
            }

            Logger.Error(GetType(), $"An unhandled exception occurred on surface controller action '{filterContext.RouteData.Values["action"]}'!", filterContext.Exception);

            // Return empty result, to prevent the whole page failure.
            filterContext.Result = new EmptyResult();
            filterContext.ExceptionHandled = true;
        }
    }
}
