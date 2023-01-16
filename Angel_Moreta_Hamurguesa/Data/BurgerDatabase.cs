using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Angel_Moreta_Hamburguesa.Models;
using SQLite;

namespace Angel_Moreta_Hamburguesa.Data
{
    public class BurgerDatabase
    {
        string _dbPath;
        private SQLiteConnection conn;
        public BurgerDatabase(string DatabasePath)
        {
            _dbPath = DatabasePath;
        }
        private void Init()
        {
            if (conn != null)
            {
                return;
            }

            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<Burger>();
        }
        public int AddNewBurger(Burger burger)
        {
            Init();
            int result = conn.Insert(burger);
            return result;
        }
        public List<Burger> GetAllBurgers()
        {
            Init();
            List<Burger> burgers = conn.Table<Burger>().ToList();
            return burgers;
        }

        public int EditBurger(Burger burger)
        {
            Init();
            int result = 0;
            conn.Update("Update Burger set Name="+burger.Name+" where Id="+burger.Id);
            return result;

        }
    }
}
