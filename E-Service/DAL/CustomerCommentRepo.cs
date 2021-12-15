using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class CustomerCommentRepo:IComment<Comment>
    {
        Entities db;
        public CustomerCommentRepo(Entities db)
        {
            this.db = db;
        }

        public void AddComment(Comment c)
        {
            db.Comments.Add(c);
            db.SaveChanges();
        }
    }
}
