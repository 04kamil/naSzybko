using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace fastConnect.Models
{
    public static class TableRepository
    {

        public static void AddPerson(Table tab)
        {
            using (DatabaseEntities db = new DatabaseEntities())
            {
                db.Table.Add(tab);
                db.SaveChanges();
            }
        }

        public static List<Table> GetTabList()
        {
            using (DatabaseEntities db = new DatabaseEntities())
            {
                return db.Table.ToList();
            }
        }
    }
}