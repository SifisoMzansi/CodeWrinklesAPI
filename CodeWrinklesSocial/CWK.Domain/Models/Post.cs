using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWKSocial.Domain.Models
{
    public class Post
    {
        public int Id { set; get; }
        public string Text { set; get; } = null!;
    }
}
