using BusinessLogicLayer.DataContext;
using CommonDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Repositories
{
    public class MembersRepository
    {
        private LibraryContext _context;
        public MembersRepository(LibraryContext context) { _context = context; }
        public bool Register(Member m)
        {
            //the method Count(...) counts the number of records matching the condition
            int exists = _context.Members.Count(x => x.Username == m.Username);
            if (exists > 0)
            {
                //user already exists
                return false;
            }
            else
            {
                 //username doesn't exist yet....so we add it into the db
                _context.Members.Add(m);  
                _context.SaveChanges();
                return true;
            }
        
        }

        /// <summary>
        /// Login method will return true if the credentials match any record in the db;
        /// will return false if the login fails
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Login(string username , string password)
        {
            //how many records there exist in the db that match username and password at the same time
            int exists = _context.Members.Count(x => x.Username == username && x.Password == password);

            //var found = _context.Members.SingleOrDefault(x => x.Username == username && x.Password == password);
            //if(found != null) return true; else return false;


            if (exists > 0) { return true; }
            else return false;
        }
    }
}
