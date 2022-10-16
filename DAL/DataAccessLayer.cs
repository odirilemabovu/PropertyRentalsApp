using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace DAL
{
    public class DataAccessLayer
    {

        static string connString = "Data Source = ODIRILE; Initial Catalog = PropertyRentalsDB; Integrated Security = true;";
        SqlConnection dbConn = new SqlConnection(connString);
        SqlCommand dbComm;
        SqlDataAdapter dbAdapter;
        DataTable dt;

        //PropertyType Methods
        public int InsertPropertyType(PropertyType pType)
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_PropertyTyeAdd", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@PropertyTypeDesc", pType.PropertyTypeDesc);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetPropertyType()
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_PropertyTypeDisplay", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();
            return dt;
        }

        //Suburb Methods
        public int InsertSurbub(Surbub surbub)
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_SurbubAdd", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@SurbubDescription", surbub.SurbubDescription);
            dbComm.Parameters.AddWithValue("@PostalCode", surbub.PostalCode);
            dbComm.Parameters.AddWithValue("@CityID", surbub.CityID); // load on the Display member When the form loads

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetSurbub()
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_SurbubDisplay", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();
            return dt;
        }

        //City Methods
        public int InsertCity(City city)
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_CityAdd", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@CityDescription", city.CityDescription);
            dbComm.Parameters.AddWithValue("@ProvinceID", city.ProvinceID);// load on the Display member When the form loads

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetCity()
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_CityDisplay", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();
            return dt;
        }

        // Province Methods
        public int InsertProvince(Province province)
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_ProvinceAdd", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Description", province.Description);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetProvince()
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_ProvinceDisplay", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();
            return dt;
        }
        //PropertyAgent Methods
        public int InsertPropertyAgent(PropertyAgent propertyAgent)
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_PropertyAgentAdd", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@PropertyID", propertyAgent.PropertyID);
            dbComm.Parameters.AddWithValue("@AgentID", propertyAgent.AgentID);
            dbComm.Parameters.AddWithValue("@Date", propertyAgent.Date);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int UpdatePropertyAgent(PropertyAgent propertyAgent)
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_PropertyAgentUpdate", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@PropertyAgentID", propertyAgent.PropertyAgentID);
            dbComm.Parameters.AddWithValue("@PropertyID", propertyAgent.PropertyID);
            dbComm.Parameters.AddWithValue("@AgentID", propertyAgent.AgentID);
            dbComm.Parameters.AddWithValue("@Date", propertyAgent.Date);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetPropertyAgentDate()
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_GetPropertyAgentDate", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();
            return dt;
        }
        public DataTable PropertyAgentDisplay()
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_PropertyAgentDisplay", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();
            return dt;
        }
        //Agent Methods
        public int InsertAgent(Agent agent)
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_AgentAdd", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Name", agent.Name);
            dbComm.Parameters.AddWithValue("@Surname", agent.Surname);
            dbComm.Parameters.AddWithValue("@Email", agent.Email);
            dbComm.Parameters.AddWithValue("@Password", agent.Password);
            dbComm.Parameters.AddWithValue("@Phone", agent.Phone);
            dbComm.Parameters.AddWithValue("@Status", agent.Status);
            dbComm.Parameters.AddWithValue("@AgencyID", agent.AgencyID);
            dbComm.Parameters.AddWithValue("@RoleID", agent.RoleID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int UpdateAgent(Agent agent)
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_AgentUpdate", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@AgentID", agent.AgentID);
            dbComm.Parameters.AddWithValue("@Email", agent.Email);
            dbComm.Parameters.AddWithValue("@Phone", agent.Phone);
            dbComm.Parameters.AddWithValue("@Password", agent.Password);
            dbComm.Parameters.AddWithValue("@Status", agent.Status);


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetAgent()
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_AgentDisplay", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();
            return dt;
        }
        public DataTable GetAgentByName()
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_GetAgentByName", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();
            return dt;
        }
        public DataTable GetAgencyByName()
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_GetAgencyByName", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();
            return dt;
        }
        public int DeleteAgent(Agent agent)
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_AgentDelete", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@AgentID", agent.AgentID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        //Agency Methods
        public int InsertAgency(Agency agency)
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_AgencyAdd", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@AgencyName", agency.AgencyName);
            dbComm.Parameters.AddWithValue("@SurbubID", agency.SurbubID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetAgency()
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_AgencyDisplay", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();
            return dt;
        }
        public int DeleteAgency(Agency agency)
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_AgencyDelete", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@AgencyID", agency.AgencyID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        //Tenant Methods
        public int InsertTenant(Tenant tenant)
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_TenantAdd", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Name", tenant.Name);
            dbComm.Parameters.AddWithValue("@Surname", tenant.Surname);
            dbComm.Parameters.AddWithValue("@Email", tenant.Email);
            dbComm.Parameters.AddWithValue("@Password", tenant.Password);
            dbComm.Parameters.AddWithValue("@Phone", tenant.Phone);
            dbComm.Parameters.AddWithValue("@Status", tenant.Status);
            dbComm.Parameters.AddWithValue("@RoleID", tenant.RoleID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int UpdateTenant(Tenant tenant)
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_TenantUpdate", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@TenantID", tenant.TenantID);
            dbComm.Parameters.AddWithValue("@Email", tenant.Email);
            dbComm.Parameters.AddWithValue("@Phone", tenant.Phone);
            dbComm.Parameters.AddWithValue("@Status", tenant.Status);


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetTenant()
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_TenantDisplay", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();
            return dt;
        }
        public int DeleteTenant(Tenant tenant)
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_TenantDelete", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@TenantID", tenant.TenantID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        //Rental Methods
        public int InsertRental(Rental rental)
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_RentalAdd", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@PropertyAgentID", rental.PropertyAgentID);
            dbComm.Parameters.AddWithValue("@TenantID", rental.TenantID);
            dbComm.Parameters.AddWithValue("@StartDate", rental.StartDate);
            dbComm.Parameters.AddWithValue("@EndDate", rental.EndDate);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int UpdateRental(Rental rental)
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_RentalUpdate", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@RentalID", rental.RentalID);
            dbComm.Parameters.AddWithValue("@StartDate", rental.StartDate);
            dbComm.Parameters.AddWithValue("@EndDate", rental.EndDate);


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetRental()
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_RentalDisplay", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();
            return dt;
        }
        public DataTable GetTenantByName()
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_GetTenantByName", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();
            return dt;
        }
        //Properties Methods
        public int InsertProperties(Property properties)
        {

            dbConn.Open();

            dbComm = new SqlCommand("sp_PropertyAdd", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Description", properties.Description);
            dbComm.Parameters.AddWithValue("@Price", properties.Price);
            dbComm.Parameters.AddWithValue("@Image", properties.Image);
            dbComm.Parameters.AddWithValue("@PropertyTypeID", properties.PropertyTypeID);
            dbComm.Parameters.AddWithValue("@Status", properties.Status);
            dbComm.Parameters.AddWithValue("@SurbubID", properties.SurbubID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetPropeties()
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_PropertyDisplay", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();
            return dt;
        }
        public int UpdateProperty(Property properties)
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_PropertyUpdate", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@PropertyID", properties.PropertyID);
            dbComm.Parameters.AddWithValue("@Price", properties.Price);
            dbComm.Parameters.AddWithValue("@Status", properties.Status);
            dbComm.Parameters.AddWithValue("@PropertyTypeID", properties.PropertyTypeID);
            


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int DeleteProperties(Property properties)
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_PropertyDelete", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@PropertyID", properties.PropertyID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        //Admin Methods
        public int InsertAdmin(Admin admin)
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_AdminAdd", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Name", admin.Name);
            dbComm.Parameters.AddWithValue("@Surname", admin.Surname);
            dbComm.Parameters.AddWithValue("@Email", admin.Email);
            dbComm.Parameters.AddWithValue("@Password", admin.Password);
            dbComm.Parameters.AddWithValue("@Status", admin.Status);
            dbComm.Parameters.AddWithValue("@RoleID", admin.RoleID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;


        }
        public DataTable GetAdmin()
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_AdminDisplay", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();
            return dt;
        }
        public int UpdateAdmin(Admin admin)
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_AdminUpdate", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@AdminID", admin.AdminID);
            dbComm.Parameters.AddWithValue("@Password", admin.Password);
            dbComm.Parameters.AddWithValue("@Status", admin.Status);


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int DeleteAdmin(Admin admin)
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_AdminDelete", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@AdminID", admin.AdminID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }

        public DataTable SignIn(string Email, string Password)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_UserLogin", dbConn);
            dbComm.Parameters.AddWithValue("@Email", Email);
            dbComm.Parameters.AddWithValue("@Password", Password);
            dbComm.CommandType = CommandType.StoredProcedure;

            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);

            dbAdapter.Fill(dt);
            return dt;
        }

        //public DataTable SignIn(string email,string password )
        //{
        //    dbConn.Open();
        //    string sql = "sp_SignIn";
        //    dbComm = new SqlCommand(sql, dbConn);
        //    dbComm.CommandType = CommandType.StoredProcedure;
        //    dbComm.Parameters.AddWithValue("@Email",email);
        //    dbComm.Parameters.AddWithValue("@Password", password);
        //    dbAdapter = new SqlDataAdapter(dbComm);
        //    dt = new DataTable();
        //    dbAdapter.Fill(dt);
        //    dbConn.Close();
        //    return dt;
        //}
        //public DataTable SignIn(User user)
        //{
        //    dbConn.Open();

        //    dbComm = new SqlCommand("sp_SignIn", dbConn);
        //    dbComm.CommandType = CommandType.StoredProcedure;
        //    dbComm.Parameters.AddWithValue("@UserID", user.UserID);
        //    dbComm.Parameters.AddWithValue("@Name", user.Name);
        //    dbComm.Parameters.AddWithValue("@Surname", user.Surname);
        //    dbComm.Parameters.AddWithValue("@Email", user.Email);
        //    dbComm.Parameters.AddWithValue("@Password", user.Password);
        //    dbComm.Parameters.AddWithValue("@RoleDescription", user.RoleDescription);
        //    dbComm.Parameters.AddWithValue("@Status", user.Status);
        //    dbAdapter = new SqlDataAdapter(dbComm);
        //    dt = new DataTable();
        //    dbAdapter.Fill(dt);

        //    dbConn.Close();
        //    return dt;
        //}
        //public DataTable SignIn(string Email, string Password)
        //{
        //    dbConn.Open();

        //    dbComm = new SqlCommand("sp_SignIn", dbConn);
        //    dbComm.CommandType = CommandType.StoredProcedure;
        //    dbComm.Parameters.AddWithValue("@Email", Email);
        //    dbComm.Parameters.AddWithValue("@Password", Password);
        //    //dbComm.Parameters.AddWithValue("@RoleDescription", RoleDescription);
        //    dbAdapter = new SqlDataAdapter(dbComm);
        //    dt = new DataTable();
        //    dbAdapter.Fill(dt);

        //    dbConn.Close();
        //    return dt;
        //}
        //Stop stop stop
        //public DataTable SignIn()
        //{
        //    dbConn.Open();

        //    dbComm = new SqlCommand("sp_SignIn", dbConn);
        //    dbComm.CommandType = CommandType.StoredProcedure;


        //    dbAdapter = new SqlDataAdapter(dbComm);
        //    dt = new DataTable();
        //    dbAdapter.Fill(dt);

        //    dbConn.Close();
        //    return dt;
        //}
    }
}
