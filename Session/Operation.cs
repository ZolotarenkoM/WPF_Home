using System;
using System.Collections.Generic;
using System.Data;
using Domain;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace Session
{
    public class Operation
    {
        /// <summary>
        /// Class with describes all operations
        /// </summary>
        SqlConnection cn;
        SqlCommand cm;

        private void ConnectTo()
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|Mushko_Home_BD.mdf;Integrated Security=True");
            cm = cn.CreateCommand();
        }

        public Operation()
        {
            ConnectTo();
        }

        /// <summary>
        /// Method for insert item to database
        /// </summary>
        public void Insert(Product p)
        {
            try
            {
                cm.CommandText = "insert into table_product4 (Name,Price,Count,TotalPrice,Type,Date) values(N'" + p.Name + "', '" + p.Price.ToString().Replace(',', '.') + "', '" + p.Count + "', '" + p.TotalPrice.ToString().Replace(',', '.') + "', N'" + p.Type + "', N'" + p.Date.ToString("yyyy-MM-dd") + "')";
                cm.CommandType = CommandType.Text;
                cn.Open();
                cm.ExecuteNonQuery();
            }
            catch (FormatException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (cn != null)
                {
                    cn.Close();
                }
            }
        }

        /// <summary>
        /// Method for delete selected item from database
        /// </summary>
        public void Delete(Product p)
        {
            try
            {
                cm.CommandText = "delete from table_product4 where Id='" + p.Id + "' ";
                cm.CommandType = CommandType.Text;
                cn.Open();
                cm.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                if (cn != null)
                {
                    cn.Close();
                }
            }
        }

        /// <summary>
        /// Method for clear table with all product
        /// </summary>
        public void Clear_table()
        {
            try
            {
                cm.CommandText = "TRUNCATE TABLE table_product4";
                cm.CommandType = CommandType.Text;
                cn.Open();
                cm.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                if (cn != null)
                {
                    cn.Close();
                }
            }
        }

        /// <summary>
        /// Method for select from database product and save in List<Product>
        /// </summary>
        public List<Product> Select(ref bool day, ref bool mounth, ref DateTime date, ref string type)
        {
            var prodList = new List<Product>();
            try
            {
                string sql;
                if (type == "Усі покупки")
                {
                    if (day)
                    {
                        sql = "select * from table_product4 where Date=@Day ORDER BY Date"; // select by Day
                    }
                    else if (mounth)
                    {
                        sql = "select * from table_product4 where month(Date)=@Month ORDER BY Date";
                    }
                    else sql = "select * from table_product4  ORDER BY Date";
                }
                else
                {
                    if (day)
                    {
                        sql = "select * from table_product4 where Date=@Day AND Type=@Type ORDER BY Date"; // select by Day
                    }
                    else if (mounth)
                    {
                        sql = "select * from table_product4 where month(Date)=@Month AND Type=@Type ORDER BY Date"; // select by month
                    }
                    else sql = "select * from table_product4 where Type=@Type ORDER BY Date";
                }
                using (cm = new SqlCommand(sql, cn))
                {
                    cm.Parameters.AddWithValue("@Day", date.Date);
                    cm.Parameters.AddWithValue("@Month", date.Date.Month);
                    cm.Parameters.AddWithValue("@Type", type);
                    cm.CommandType = CommandType.Text;
                    cn.Open();
                    SqlDataReader dr = cm.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            Product p = new Product
                            {
                                Id = dr[0].ToString(),
                                Name = dr[1].ToString(),
                                Price = float.Parse(dr[2].ToString()),
                                Count = (int)dr[3],
                                TotalPrice = float.Parse(dr[4].ToString()),
                                Type = dr[5].ToString(),
                                Date = Convert.ToDateTime(dr[6].ToString().Substring(0, 10))
                            };
                            prodList.Add(p);
                        }
                    }
                }
                return prodList;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (cn != null)
                {
                    cn.Close();
                }
            }
        }

        /// <summary>
        /// Method for register user
        /// </summary>
        public void SignUp(Users u)
        {
            try
            {
                cm.CommandText = "insert into [User] (UserName, Password) values(N'" + u.User + "', '" + u.Passwd + "')";
                cm.CommandType = CommandType.Text;
                cn.Open();
                cm.ExecuteNonQuery();
            }
            catch (FormatException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (cn != null)
                {
                    cn.Close();
                }
            }
        }

        /// <summary>
        /// Method for make hashcode from string value
        /// </summary>
        public string GetHashString(string str)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(str);
            MD5CryptoServiceProvider csp = new MD5CryptoServiceProvider();
            byte[] byteHash = csp.ComputeHash(bytes);
            string hash = string.Empty;
            foreach (byte b in byteHash)
                hash += string.Format("{0:x2}", b);
            return hash;
        }


        /// <summary>
        /// Method for clear all users from base
        /// </summary>
        public void ClearUsers()
        {
            try
            {
                cm.CommandText = "TRUNCATE TABLE [User]";
                cm.CommandType = CommandType.Text;
                cn.Open();
                cm.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                if (cn != null)
                {
                    cn.Close();
                }
            }
        }
    }
}

