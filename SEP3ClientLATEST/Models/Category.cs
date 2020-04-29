using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SEP3ClientLATEST.Models
{
    public class Category
        {
            public int CategoryID { get; set; }
            public String CategoryName { get; set; }
            public ICollection<Song> Songs { get; set; }
        }
}
