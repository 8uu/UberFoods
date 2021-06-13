﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace UberFoodsAPI.Data
{
    public class RestaurantData
    {
        public static DataTable GetRestaurants()
        {
            DataTable table = new DataTable();
           SqlDataAdapter da = new SqlDataAdapter("PikaSelect_sp", PublicClass.ConnectionString);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@PikaId", null);
            da.Fill(table);
            return table;
        }
    }
}