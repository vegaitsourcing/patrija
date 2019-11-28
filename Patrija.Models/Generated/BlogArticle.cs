using System;

namespace Patrija.Models.Generated
{
    public partial class BlogArticle
    {
        public DateTime CustomDate => !Date.Equals(default(DateTime)) ? Date : CreateDate;
    }
}
