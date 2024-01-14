using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.ReposAdmin
{
    internal class SNoteRepo : Repo, INote<Note, int>
    {
        public List<Note> Get()
        {
            return db.Notes.ToList();
        }
        public Note Get(int id)
        {
            return db.Notes.Find(id);
        }
    }
}
