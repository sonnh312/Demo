﻿using PetManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetManager.DAO
{
    public class PetDAO
    {
        private static PetDAO instance;

        public static PetDAO Instance
        { get { if (instance == null) instance = new PetDAO();return PetDAO.instance   ; }
            private set { PetDAO.instance = value; }
        }


        private PetDAO() { }

        public static int TableWidth = 50;
        public static int TableHeigh = 50;

        public List<Pet> LoadPetList() 
        {
            List<Pet> petlist = new List<Pet>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTableList");
            foreach(DataRow item in data.Rows)
            {
                Pet table = new Pet(item);
                petlist.Add(table); 
            }


            return petlist;



        }


    }
}
