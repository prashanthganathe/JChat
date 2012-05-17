using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace BizService
{
    public class Group : ICRUD
    {
        public int Id { get; set; }
        public string GName { get; set; }
       // private string conString = ConfigurationSettings.AppSettings["ConnectionString"].ToString();

        JEntities a = new JEntities(ConfigurationSettings.AppSettings["ConnectionString"].ToString());

        public int Create(object obj)
        {
           a.Groups.AddObject(


           
            if (obj.GetType().ToString() == "List<BizService.GroupClass>")
            {
                List<BizService.GroupClass> grpCls = (List<BizService.GroupClass>)obj;
                SqlConnection con = new SqlConnection(conString);
                SqlCommand com = new SqlCommand();
                com.Connection = con;

                foreach (GroupClass g in grpCls)
                {
                    if (!IsExist(g.GName))
                    {
                        try
                        {
                            com.CommandType = System.Data.CommandType.StoredProcedure;
                            com.CommandText = "CreateGroup";
                            com.Parameters.AddWithValue("@GName", g.GName);
                            con.Open();
                            com.ExecuteNonQuery();
                            con.Close();
                        }
                        catch (Exception ex)
                        {
                            return -1;
                        }
                        finally
                        {
                            con.Dispose();
                            com.Dispose();
                        }
                    }
                }
            }
            return -1;
        }



        public int Update(IEnumerable<GroupClass> obj)
        {
            if (obj.GetType().ToString() == "List<BizService.GroupClass>")
            {
                List<BizService.GroupClass> grpCls = (List<BizService.GroupClass>)obj;
            }
            return -1;
        }

        public int GetList()
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public int Create(object obj)
        {
            throw new NotImplementedException();
        }

        public int Update(object obj)
        {
            throw new NotImplementedException();
        }

        public bool IsExist(object obj)
        {
            string gname = (string)obj;
            SqlConnection con = new SqlConnection(conString);
            SqlCommand com = new SqlCommand();
            com.Connection = con;

            return true;
           
        }
    }
}
