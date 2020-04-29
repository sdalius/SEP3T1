using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SEP3ClientLATEST.Models;

namespace SEP3ClientLATEST
{
    public class IndexModel : PageModel
    {
        public List<Song> songList = new List<Song>();

        public String AddSomeSongs()
        {
            songList.Add(new Song()
            {
                Artist = "Artist", Categoryid = 0, SongID = 1,
                Title = "Titlee", VoteAmount = 50
            });
            return "Success";
        }
        public void OnGet()
        {

        }
    }
}