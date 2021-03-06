﻿using Patrija.Core.ViewModels.Shared;
using Patrija.Models.Extensions;
using Patrija.Models.Generated;
using System;
using System.Linq;
using System.Web.Mvc;

namespace Patrija.Core.Controllers.Surface.Partials
{
    public class ListingController : BaseSurfaceController
    {
       
        public ActionResult BlogsArticlesListing(int newsPageId, int numberArticlesOnLoad, string partial, int orderNumber)
        {
            var items = GetNewsPageModel(newsPageId)?
                .NewsNewsBlogBlocks?
                .ToList()[orderNumber]
                .GetArticles()?
                .Skip(numberArticlesOnLoad)
                .Select(article => new NewsBlogBlockPreviewViewModel(article))
                .ToList();

            return PartialView(partial, items);
        }

        private News GetNewsPageModel(int pageId)
        {
            var model = (News)Umbraco.Content(pageId);

            if (model == null)
            {
                throw new NullReferenceException();
            }

            return model;
        }

    }
}
