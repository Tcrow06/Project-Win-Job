﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHub
{
    public class AccountDAO
    {
        private DBConection db = new DBConection(); 
        public AccountDAO() { }
       
        public DataTable CheckEmailExists(string email)
        {
            string sql = $@"select * from Account
                            where accountEmail = '{email}'";
            return  db.CheckExists(sql);
        }
        public void AddAcount(Account account)
        {
            string sqlgeMaxId = $@"SELECT accountType, MAX(idAccount)as id 
                                    FROM Account  
                                    where accountType = {account.Type} 
                                    group by accountType";
            SqlDataReader dr = db.loadData(sqlgeMaxId);
            if (dr.Read())
            {
                account.Id = int.Parse(dr["id"].ToString())+1;
            }
            string sql = $@"insert into Account(idAccount, accountEmail, accountPass, accountType) 
                            values ('{account.Id}','{account.Email}', '{account.Pass}','{account.Type}')";
            db.ThucThi(sql);
        }
    }

}