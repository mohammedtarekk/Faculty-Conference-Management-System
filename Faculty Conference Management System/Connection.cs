using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Windows.Forms;
namespace Faculty_Conference_Management_System
{
	public class Connection
	{
        public static int Current_AdminID;
        public static int Current_AuthorID;
        public static int Current_ReviewerID;
        public string conStr { get; set; }
		private OracleDataAdapter adapter { get; set; }
		private OracleCommandBuilder builder { get; set; }
		private DataSet DBdataSet { get; set; }

        OracleConnection con;
		public Connection()
		{
			conStr = "Data Source=orcl; User Id=hr; Password=hr;";
		}

		/// <summary>
		/// Excutes query in disconnected mode
		/// </summary>
		/// <param name="query">SQL query to excute</param>
		/// <returns>DataTable contains data from database</returns>
		public DataSet DisconnectedExcuteQuery(string query)
		{
			adapter = new OracleDataAdapter(query, conStr);
			DBdataSet = new DataSet();
			adapter.Fill(DBdataSet);
            if (DBdataSet.Tables[0].Rows.Count == 0)
                throw new Exception("No papers found !");

            return DBdataSet;
		}

		/// <summary>
		/// Excutes query in disconnected mode
		/// </summary>
		/// <param name="query">SQL query to excute</param>
		/// <param name="parameterName">Parameter name in query</param>
		/// <param name="parameterData">Parameter data send to database</param>
		/// <returns>DataTable contains data from database</returns>
		public DataSet DisconnectedExcuteQuery(string query, string parameterName,string parameterData)
		{
            try
            {
			    adapter = new OracleDataAdapter(query, conStr);
			    adapter.SelectCommand.Parameters.Add(parameterName, parameterData);
			    DBdataSet = new DataSet();
			    adapter.Fill(DBdataSet);
                if (DBdataSet.Tables[0].Rows.Count == 0)
                    throw new Exception("No fata found!");
            }
            catch (Exception e)
            {
                throw;
            }
			return DBdataSet;
		}

        public DataSet DisconnectedExcuteQuery(string query, Queue<string> paramerters)
        {
            try
            {
                adapter = new OracleDataAdapter(query, conStr);
                while(paramerters.Count > 0)
                {
                    adapter.SelectCommand.Parameters.Add(paramerters.Dequeue(), paramerters.Dequeue());
                }
                DBdataSet = new DataSet();
                adapter.Fill(DBdataSet);
                if (DBdataSet.Tables[0].Rows.Count == 0)
                    throw new Exception("No fata found!");
            }
            catch (Exception e)
            {
                throw;
            }
            return DBdataSet;
        }

        internal void addConference(string conferenceDate, string conferencePlace, string paperTitle, string conferenceDuration, string paperID)
        {
            con = new OracleConnection(conStr);
            con.Open();
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = "Add_Conference";
             
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("dates", conferenceDate);
                cmd.Parameters.Add("place", conferencePlace);
                cmd.Parameters.Add("title", paperTitle);
                cmd.Parameters.Add("dur", conferenceDuration);
                cmd.Parameters.Add("id", paperID);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                
            }
            
        }

            internal void Update(DataSet dataSet)
		{
			builder = new OracleCommandBuilder(adapter);
			adapter.Update(dataSet.Tables[0]);
		}

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

        public bool Signup(String type,string fname,string sname,string dob,string add,string pass,string email)
        {    
            con = new OracleConnection(conStr);
            con.Open();
           try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                if(type=="Author")
                    cmd.CommandText = "Author_Signup";
                else if(type=="Reviewer")
                    cmd.CommandText = "Reviewer_Signup";
                else if(type=="Admin")
                    cmd.CommandText = "Admin_Signup";

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
        public bool Get_Accounts(String type)
        {

            accounts.Clear();
            con = new OracleConnection(conStr);
            con.Open();
            try
            {       
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                if (type == "Author")
                    cmd.CommandText = "Get_Authors";
                else if(type == "Reviewer")
                    cmd.CommandText = "Get_Reviewers";
                else if(type == "Admin")
                    cmd.CommandText = "Get_Admins";


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
        public bool check_exist(String type,int id,string pass)
        {
            for(int i=0;i<accounts.Count;i++)
            {
                if (accounts[i].ID == id && accounts[i].password == pass)
                {
                    if (type == "Author")
                        Current_AuthorID = accounts[i].ID;
                    else if (type == "Reviewer")
                        Current_ReviewerID = accounts[i].ID;
                    else if (type == "Admin")
                        Current_AdminID = accounts[i].ID;

                    return true;
                }
            }
            return false;
        }

        public int GetNextID(string type)
        {
            int x = 0;
            con = new OracleConnection(conStr);
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            if (type == "Author")
                cmd.CommandText = "select Author_ID from Author";
            else if (type =="Reviewer")
                cmd.CommandText = "select Reviewer_ID from Reviewer";
            else if (type == "Admin")
                cmd.CommandText = "select Admin_ID from Admin";


            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                x = Convert.ToInt32(dr[0].ToString());
            }

            return x + 1;
        }

        public bool Delete_Author(int id)
        {
            con = new OracleConnection(conStr);
            con.Open();
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = "Delete from Author where AUTHOR_ID=:id";
                cmd.Parameters.Add("id", id);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool Delete_Reviewer(int id)
        {
            con = new OracleConnection(conStr);
            con.Open();
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = "Delete from Reviewer where REVIEWER_ID=:id";
                cmd.Parameters.Add("id", id);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool Update_Author_Data(int id , string firstName, string secondName , string birth ,string email, string address ,string password)
        {
            con = new OracleConnection(conStr);
            con.Open();
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = "update Author set AUTHOR_FNAME=:firstName ,AUTHOR_SNAME=:secondName , AUTHOR_DBIRTH=:birth , AUTHOR_EMAIL:=email , AUTHOR_ADDRESS=:address ,AUTHOR_PASSWORD:=password where AUTHOR_ID=:id ";
                cmd.Parameters.Add("firstName", firstName);
                cmd.Parameters.Add("secondName", secondName);
                cmd.Parameters.Add("birth", birth);
                cmd.Parameters.Add("email", email);
                cmd.Parameters.Add("address", address);
                cmd.Parameters.Add("password", password);
                cmd.Parameters.Add("id", id);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool Update_Reviewer_Data(int id, string firstName, string secondName, string birth, string email, string address, string password)
        {
            con = new OracleConnection(conStr);
            con.Open();
            try 
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = "update Reviewer set REVIEWER_FNAME=:firstName ,REVIEWER_SNAME=:secondName , REVIEWER_DBIRTH=:birth , REVIEWER_EMAIL:=email , REVIEWER_ADDRESS=:address ,REVIEWER_PASSWORD:=password where REVIEWER_ID=:id ";
                cmd.Parameters.Add("firstName", firstName);
                cmd.Parameters.Add("secondName", secondName);
                cmd.Parameters.Add("birth", birth);
                cmd.Parameters.Add("email", email);
                cmd.Parameters.Add("address", address);
                cmd.Parameters.Add("password", password);
                cmd.Parameters.Add("id", id);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            return true;
        }


        public bool submit_paper(string title, string content,int Cat_ID)
        {
            con = new OracleConnection(conStr);
            con.Open();
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into PAPER values (Paper_Seq.nextval,:PAPER_TITLE,:PAPER_CONTENT,:PAPER_CAT,:Author_id)";
                cmd.Parameters.Add("PAPER_TITLE", title);
                cmd.Parameters.Add("PAPER_CONTENT", content);
                cmd.Parameters.Add("PAPER_CAT", Cat_ID);///this row for test only it will be updated
                cmd.Parameters.Add("Author_id", Current_AuthorID);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            return true;
        }


        public List<String> Get_Categories()
        {
            List<String> Cat = new List<string>();
            con = new OracleConnection(conStr);
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;       
            cmd.CommandText = "select Category_Name from RESEARCH_CATEGORYFIELD";
              
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Cat.Add(dr[0].ToString());
            }
            dr.Close();
            return Cat;
        }

        public int Get_CatID(string Cat_Name)
        {
            int Cat_ID = 0 ;
            con = new OracleConnection(conStr);
            con.Open();
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;                
                cmd.CommandText = "Get_CatID";         
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
                cmd.Parameters.Add("name", Cat_Name);
                cmd.ExecuteNonQuery();
                Cat_ID = Convert.ToInt32(cmd.Parameters["id"].Value.ToString());
            }
            catch
            {
                return 0;
            }
            return Cat_ID;
        }
    }
}
