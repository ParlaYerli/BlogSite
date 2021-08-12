using System;
using System.Collections.Generic;

#nullable disable

namespace BlogSite.Entity.Models
{
    public partial class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ContentSummary { get; set; }
        public string ContentMain { get; set; }
        public string PublishDate { get; set; }
        public string Picture { get; set; }
        public string CategoryId { get; set; }
        public int ArticleCount { get; set; }
    }
}
