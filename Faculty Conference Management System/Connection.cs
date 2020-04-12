using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace Faculty_Conference_Management_System
{
	public class Connection
	{
		public string conStr = "Data Source=orcl; User Id=hr; Password=hr;";
        OracleConnection con;
       public struct account
        {
           public int ID;
            public string password;
        }
       public static List<account>accounts =new List<account>();
        /*Connection()
		{
			conStr = "Data Source=orcl; User Id=hr; Password=hr;";
            con = new OracleConnection(conStr);
        }*/


        //this function to insert the Author ot reviewer data in oracle DB
        //taking parameter 'type' as a char (A) for Author & (R) for reviewer

        public bool Signup(char type,string fname,string sname,string dob,string add,string pass,string email)
        {    
            con = new OracleConnection(conStr);
            con.Open();
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                if(type=='A')
                cmd.CommandText = "Author_Signup";
                else
                    cmd.CommandText = "Reviewer_Signup";

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("fname", fname);
                cmd.Parameters.Add("sname", sname);
                cmd.Parameters.Add("dob", dob);
                cmd.Parameters.Add("email", email);
                cmd.Parameters.Add("add", add);
                cmd.Parameters.Add("pass", pass);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }


            return true;
        }

        //this function is to get all accounts from Oracle_DB and but it in accounts list
        //taking one parameter as a char (A) for Author & (R) for reviewer
        public bool Get_Accounts(char type)
        {

            accounts.Clear();
            con = new OracleConnection(conStr);
            con.Open();
           try
            {       
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                if (type == 'A')
                    cmd.CommandText = "Get_Authors";
                else
                    cmd.CommandText = "Get_Reviewers";

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("id", OracleDbType.RefCursor, ParameterDirection.Output);

                OracleDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    account a;
                   a.ID =Convert.ToInt32(dr[0]);
                   a.password =Convert.ToString(dr[1]);
                    
                    accounts.Add(a);
                }
                dr.Close();              

            }
            catch  
            {
                return false;
            }
            return true;
        }

        //this function is to return if account is exist or not
      public bool check_exist(int id,string pass)
        {
            for(int i=0;i<accounts.Count;i++)
            {
                if (accounts[i].ID == id && accounts[i].password == pass)
                {
                    return true;
                }
            }
            return false;
        }
	}
}
