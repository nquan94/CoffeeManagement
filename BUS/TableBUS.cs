using System;
using System.Collections.Generic;
using System.Data;

using DAO;
using DTO;

namespace BUS
{
    public class TableBUS
    {
        private static TableBUS instance;

        public static TableBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new TableBUS();
                return TableBUS.instance;
            }
        }
        public List<Table> GetTableList()
        {
            DataTable table;
            try
            {
                table = TableDAO.Instance.GetTableList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            List<Table> lstTable = new List<Table>();
            foreach (DataRow row in table.Rows)
            {
                Table tb = new Table(row);
                lstTable.Add(tb);
            }
            return lstTable;
        }

        public bool InsertTable(string name)
        {
            return TableDAO.Instance.InsertTable(name);
        }

        public bool UpdateTable(int id, string name)
        {
            return TableDAO.Instance.UpdateTable(id, name);
        }

        public bool DeleteTable(int id)
        {
            return TableDAO.Instance.DeleteTable(id);
        }
    }
}