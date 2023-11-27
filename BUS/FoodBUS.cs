using System;
using System.Collections.Generic;
using System.Data;

using DTO;
using DAO;

namespace BUS
{
    public class FoodBUS
    {
        private static FoodBUS instance;

        public static FoodBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new FoodBUS();
                return FoodBUS.instance;
            }
        }

        private FoodBUS() { }

        public DataTable GetAllFood()
        {
            try
            {
                return FoodDAO.Instance.GetAllFood();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetListFoodByCategoryID(int categoryID)
        {
            try
            {
                return FoodDAO.Instance.GetListFoodByCategoryID(categoryID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool InsertFood(Food newFood)
        {
            return FoodDAO.Instance.InsertFood(newFood);
        }

        public bool UpdateFood(Food food)
        {
            return FoodDAO.Instance.UpdateFood(food);
        }

        public bool DeleteFood(int ID)
        {
            return FoodDAO.Instance.DeleteFood(ID);
        }
    }
}