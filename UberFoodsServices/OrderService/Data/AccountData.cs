﻿using OrderService.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace OrderService.Data
{
    public class AccountData
    {
        public static void InsertOrderer(Orderer orderer)
        {
            SqlConnection cnn = new SqlConnection(PublicClass.ConnectionString);
            SqlTransaction tran = default;
            try
            {
                cnn.Open();
                tran = cnn.BeginTransaction();
                InsertOrdererCommand(orderer, cnn, tran);
                tran.Commit();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.StackTrace);
                tran.Rollback();
                throw;
            }
            finally
            {
                cnn.Close();
            }
        }

        private static void InsertOrdererCommand(Orderer orderer, SqlConnection cnn, SqlTransaction tran)
        {
            SqlCommand insert = new SqlCommand("PorositesiInsert_sp", cnn, tran)
            {
                CommandType = CommandType.StoredProcedure
            };
            insert.Parameters.AddWithValue("@Emri", orderer.Name);
            insert.Parameters.AddWithValue("@Mbiemri", orderer.Surname);
            insert.Parameters.AddWithValue("@Email", orderer.Email);
            insert.Parameters.AddWithValue("@AdresaPershkrimi", orderer.Address);

            insert.Parameters.AddWithValue("@MenyraPagesesId", orderer.PaymentType);
            insert.Parameters.AddWithValue("@AdresaX", 1.1);
            insert.Parameters.AddWithValue("@AdresaY", 1.1);
            insert.Parameters.AddWithValue("@AdresaZ", 11.1);
            insert.ExecuteNonQuery();
        }

        public static void InsertDelivery(Delivery delivery)
        {
            SqlConnection cnn = new SqlConnection(PublicClass.ConnectionString);
            SqlTransaction tran = default;
            try
            {
                cnn.Open();
                tran = cnn.BeginTransaction();
                InsertDeliveryCommand(delivery, cnn, tran);
                tran.Commit();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.StackTrace);
                tran.Rollback();
                throw;
            }
            finally
            {
                cnn.Close();
            }
        }

        private static void InsertDeliveryCommand(Delivery delivery, SqlConnection cnn, SqlTransaction tran)
        {
            SqlCommand insert = new SqlCommand("DerguesiInsert_sp", cnn, tran)
            {
                CommandType = CommandType.StoredProcedure
            };
            insert.Parameters.AddWithValue("@Emri", delivery.Name);
            insert.Parameters.AddWithValue("@Mbiemri", delivery.Surname);
            insert.Parameters.AddWithValue("@Email", delivery.Email);
            insert.Parameters.AddWithValue("@AdresaPershkrimi", delivery.Address);
            insert.Parameters.AddWithValue("@MenyraDergesesPershkrimi", delivery.DeliveryType);
            insert.Parameters.AddWithValue("@AdresaX", 1.1);
            insert.Parameters.AddWithValue("@AdresaY", 1.1);
            insert.Parameters.AddWithValue("@AdresaZ", 11.1);
            insert.ExecuteNonQuery();
        }

        public static void InsertCorporateAccount(Account account, Corporate corporate)
        {
            SqlConnection cnn = new SqlConnection(PublicClass.ConnectionString);
            SqlTransaction tran = default;
            try
            {
                cnn.Open();
                tran = cnn.BeginTransaction();
                InsertCorporateAccountCommand(account, corporate, cnn, tran);
                tran.Commit();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.StackTrace);
                tran.Rollback();
                throw;
            }
            finally
            {
                cnn.Close();
            }
        }

        private static void InsertCorporateAccountCommand(Account account, Corporate corporate, SqlConnection cnn, SqlTransaction tran)
        {
            SqlCommand insert = new SqlCommand("MenaxhuesiInsert_sp", cnn, tran)
            {
                CommandType = CommandType.StoredProcedure
            };
            insert.Parameters.AddWithValue("@Emri", account.Name);
            insert.Parameters.AddWithValue("@Mbiemri", account.Surname);
            insert.Parameters.AddWithValue("@Email", account.Email);
            insert.Parameters.AddWithValue("@AdresaPershkrimi", account.Address);
            insert.Parameters.AddWithValue("@AdresaX", 1.1);
            insert.Parameters.AddWithValue("@AdresaY", 1.1);
            insert.Parameters.AddWithValue("@AdresaZ", 11.1);
            insert.Parameters.AddWithValue("@KorporataPershkrimi", account.Address);
            insert.Parameters.AddWithValue("@KorporataEmail", account.Address);
            insert.Parameters.AddWithValue("@Komuna", account.Address);
            insert.ExecuteNonQuery();
        }
    }
}