using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SEP3ClientLATEST.Models
{
    public class Song
    {
        public int SongID { get; set; }
        public String Title { get; set; }
        public String Artist { get; set; }
        public int VoteAmount { get; set; }
        public int Categoryid { get; set; }
        public Category Category { get; set; }
    }
}
