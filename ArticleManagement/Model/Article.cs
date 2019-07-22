using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ArticleManagement.Model
{
    public class Article
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ArticleId { get; set; }
        public string ArticleName { get; set; }
        public string Topic { get; set; }
        public DateTime RecDate { get; set; }
    }
}
