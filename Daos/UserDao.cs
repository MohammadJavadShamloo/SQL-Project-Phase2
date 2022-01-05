using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using Model;
using Repository;

namespace AliBaba.Daos
{

    public class UserDao : Repository<User, int>
    {
        static string CS = "server=DESKTOP-THHK7LG\\MSSQLSERVER01; database=alibaba; integrated security=true";
        static int TotalRowsAffected = 0;

        public List<User> FindAll()
        {
            var users = new List<User>();

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM [User]", con);
                con.Open();

                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        User user = new User();
                        user.user_id = Convert.ToInt32(rdr["user_id"]);
                        user.gender = Convert.ToBoolean(rdr["gender"]);
                        user.first_name = Convert.ToString(rdr["first_name"]);
                        user.last_name = Convert.ToString(rdr["last_name"]);
                        user.telephone = Convert.ToString(rdr["telephone"]);
                        user.national_id = Convert.ToString(rdr["national_id"]);
                        user.birth_data = Convert.ToDateTime(rdr["birth_data"]);
                        user.email = Convert.ToString(rdr["email"]);
                        user.mobile_phone = Convert.ToString(rdr["mobile_phone"]);
                        user.account_number = Convert.ToString(rdr["account_number"]);
                        user.card_number = Convert.ToString(rdr["card_number"]);
                        user.shaba_number = Convert.ToString(rdr["shaba_number"]);
                        user.balance = Convert.ToDouble(rdr["balance"]);
                        users.Add(user);
                    }
                }
            }
            return users;
        }

        public User FindById(int id)
        {
            User user = new User();

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM [User]", con);
                con.Open();

                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        if (id == Convert.ToInt32(rdr["user_id"]))
                        {
                            user.user_id = id;
                            user.gender = Convert.ToBoolean(rdr["gender"]);
                            user.first_name = Convert.ToString(rdr["first_name"]);
                            user.last_name = Convert.ToString(rdr["last_name"]);
                            user.telephone = Convert.ToString(rdr["telephone"]);
                            user.national_id = Convert.ToString(rdr["national_id"]);
                            user.birth_data = Convert.ToDateTime(rdr["birth_data"]);
                            user.email = Convert.ToString(rdr["email"]);
                            user.mobile_phone = Convert.ToString(rdr["mobile_phone"]);
                            user.account_number = Convert.ToString(rdr["account_number"]);
                            user.card_number = Convert.ToString(rdr["card_number"]);
                            user.shaba_number = Convert.ToString(rdr["shaba_number"]);
                            user.balance = Convert.ToDouble(rdr["balance"]);
                        }
                    }
                }
            }
            return user;
        }

        public List<User> FindByIDs(Collection<int> ids)
        {

            throw new NotImplementedException();
        }

        public Boolean DeleteByID(int id)
        {

            string query = $"DELETE FROM [User] WHERE [user_id] = {id}";
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                TotalRowsAffected = cmd.ExecuteNonQuery();
            }
            if (TotalRowsAffected == 0)
                return false;
            return true;
        }

        public Boolean DeleteByIDs(Collection<int> ids)
        {

            throw new NotImplementedException();
        }

        public User Save(User E)
        {
            User user = new User();
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "INSERT INTO Books VALUES ('" + E.user_id + "'," + E.gender + "," + E.first_name + "," + E.last_name + ")";
                TotalRowsAffected = cmd.ExecuteNonQuery();

                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        if (E.user_id == Convert.ToInt32(rdr["user_id"]))
                        {
                            user.user_id = E.user_id;
                            user.gender = Convert.ToBoolean(rdr["gender"]);
                            user.first_name = Convert.ToString(rdr["first_name"]);
                            user.last_name = Convert.ToString(rdr["last_name"]);
                            user.telephone = Convert.ToString(rdr["telephone"]);
                            user.national_id = Convert.ToString(rdr["national_id"]);
                            user.birth_data = Convert.ToDateTime(rdr["birth_data"]);
                            user.email = Convert.ToString(rdr["email"]);
                            user.mobile_phone = Convert.ToString(rdr["mobile_phone"]);
                            user.account_number = Convert.ToString(rdr["account_number"]);
                            user.card_number = Convert.ToString(rdr["card_number"]);
                            user.shaba_number = Convert.ToString(rdr["shaba_number"]);
                            user.balance = Convert.ToDouble(rdr["balance"]);
                        }
                    }
                }

            }
            return user;
        }
    }
}