﻿using Patrija.Models.Generated;
using System.Collections.Generic;
using System.Linq;

namespace Patrija.Models.Extensions
{
    public static class NewsBlogBlockExtension
    {
        public static IEnumerable<BlogArticle> GetAllArticlesSkippingFirst(this NewsBlogBlock model)
        {
            IEnumerable<BlogArticle> allArticles = model.GetArticles();
            if(allArticles == null || !allArticles.Any())
            {
                return default(List<BlogArticle>);
            }
            return allArticles
                .Skip(1)
                .ToList();

        }

        public static IEnumerable<BlogArticle> GetOnLoadArticles(this NewsBlogBlock model, int numberOfArticlesOnLoad)
        {
            IEnumerable<BlogArticle> allArticles = model.GetArticles();
            if (allArticles == null || !allArticles.Any())
            {
                return default(List<BlogArticle>);
            }
            return allArticles
                .Take(numberOfArticlesOnLoad)
                .ToList();

        }

        public static IEnumerable<BlogArticle> GetOnLoadArticlesSkippingFirst(this NewsBlogBlock model, int numberOfArticlesOnLoad)
        {
            IEnumerable<BlogArticle> allArticles = GetOnLoadArticles(model, numberOfArticlesOnLoad);
            if (allArticles == null || !allArticles.Any())
            {
                return default(List<BlogArticle>);
            }
            return allArticles
                .Skip(1)
                .Take(numberOfArticlesOnLoad)
                .ToList();

        }

        public static BlogArticle GetFirstArticle(this NewsBlogBlock model)
        {
            IEnumerable<BlogArticle> allArticles = model.GetArticles();
            if (allArticles == null || !allArticles.Any())
            {
                return default(BlogArticle);
            }
            return allArticles.First();

        }

        public static IEnumerable<BlogArticle> GetArticles(this NewsBlogBlock model)
        {
            if(model == null || model.NewsBlogBlockBlogCategory == null)
            {
                return default(List<BlogArticle>);
            }
 
            return model
                .NewsBlogBlockBlogCategory
                .Children
                .OfType<BlogArticle>()
                .Where(article => article.BlogArticlePageIntro != null && article.BlogArticlePageIntro.Any())
                .OrderByDescending(article => article.Date)
                .ToList();

        }

        public static int GetNumberOfArticles(this NewsBlogBlock model)
        {
            IEnumerable<BlogArticle> allArticles = model.GetArticles();
            if (allArticles == null)
            {
                return 0;
            }
            return allArticles.Count();

        }
    }
}
