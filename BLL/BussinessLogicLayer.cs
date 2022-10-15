using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using System.Runtime.InteropServices.WindowsRuntime;

namespace BLL
{
    public class BussinessLogicLayer
    {
        DataAccessLayer dal = new DataAccessLayer();

        //Passing PropertyType methods from the DataAccessLayer to the Business Logic Layer
        public int InsertPropertyType(PropertyType pType)
        {
            return dal.InsertPropertyType(pType);
        }
        public DataTable GetPropertyType()
        {
            return dal.GetPropertyType();
        }

        //Passing Surbub methods from the DataAccessLayer to the Business Logic Layer
        public int InsertSurbub(Surbub surbub)
        {
            return dal.InsertSurbub(surbub);
        }
        public DataTable GetSurbub()
        {
            return dal.GetSurbub();
        }

        //Passing City methods from the DataAccessLayer to the Business Logic Layer
        public int InsertCity(City city)
        {
            return dal.InsertCity(city);
        }
        public DataTable GetCity()
        {
            return dal.GetCity();
        }
        //Passing Province methods from the DataAccessLayer to the Business Logic Layer
        public int InsertProvince(Province province)
        {
            return dal.InsertProvince(province);
        }
        public DataTable GetProvince()
        {
            return dal.GetProvince();
        }
        //Passing PropertyAgent methods from the DataAccessLayer to the Business Logic Layer
        public int InsertPropertyAgent(PropertyAgent propertyAgent)
        {
            return dal.InsertPropertyAgent(propertyAgent);
        }
        public int UpdatePropertyAgent(PropertyAgent propertyAgent)
        {
            return dal.UpdatePropertyAgent(propertyAgent);
        }
        public DataTable PropertyAgentDisplay()
        {
            return dal.PropertyAgentDisplay();
        }
        //Passing Agent methods from the DataAccessLayer to the Business Logic Layer
        public int InsertAgent(Agent agent)
        {
            return dal.InsertAgent(agent);
        }
        public int UpdateAgent(Agent agent)
        {
            return dal.UpdateAgent(agent);
        }
        public DataTable GetAgent()
        {
            return dal.GetAgent();
        }
        public int DeleteAgent(Agent agent)
        {
            return dal.DeleteAgent(agent);
        }
        public DataTable GetAgentByName()
        {
            return dal.GetAgentByName();
        }
        public DataTable GetAgencyByName()
        {
            return dal.GetAgencyByName();
        }
        //Passing Agency methods from the DataAccessLayer to the Business Logic Layer
        public int InsertAgency(Agency agency)
        {
            return dal.InsertAgency(agency);
        }
        public DataTable DisplayAgency()
        {
            return dal.GetAgency();
        }
        public int DeleteAgency(Agency agency)
        {
            return dal.DeleteAgency(agency);
        }

        //Passing Tenant methods from the DataAccessLayer to the Business Logic Layer
        public int InsertTenant(Tenant tenant)
        {
            return dal.InsertTenant(tenant);
        }
        public int UpdateTenant(Tenant tenant)
        {
            return dal.UpdateTenant(tenant);
        }
        public int DeleteTenant(Tenant tenant)
        {
            return dal.DeleteTenant(tenant);
        }
        public DataTable GetTenant()
        {
            return dal.GetTenant();
        }
        //Passing Rental methods from the DataAccessLayer to the Business Logic Layer
        public int InsertRental(Rental rental)
        {
            return dal.InsertRental(rental);
        }
        public int UpdateRental(Rental rental)
        {
            return dal.UpdateRental(rental);
        }
        public DataTable GetRental()
        {
            return dal.GetRental();
        }
        public DataTable GetTenantByName()
        {
            return dal.GetTenantByName();
        }
        //Passing Properties methods from the DataAccessLayer to the Business Logic Layer
        public int InsertProperties(Property properties)
        {
            return dal.InsertProperties(properties);
        }
        public int UpdateProperties(Property properties)
        {
            return dal.UpdateProperty(properties);
        }
        public int DeleteProperties(Property properties)
        {
            return dal.DeleteProperties(properties);
        }
        public DataTable GetProperties()
        {
            return dal.GetPropeties();
        }
        //Passing Admin methods from the DataAccessLayer to the Business Logic Layer
        public int InsertAdmin(Admin admin)
        {
            return dal.InsertAdmin(admin);
        }
        public int UpdateAdmin(Admin admin)
        {
            return dal.UpdateAdmin(admin);
        }
        public int DeleteAdmin(Admin admin)
        {
            return dal.DeleteAdmin(admin);
        }
        public DataTable GetAdmin()
        {
            return dal.GetAdmin();
        }
        public DataTable GetPropertyAgentDate()
        {
            return dal.GetPropertyAgentDate();
        }
        //public DataTable SignIn(User user)
        //{
        //    return dal.SignIn(user);
        //}
        public DataTable SignIn(string email, string password)
        {
            return dal.SignIn(email, password);
        }
        //Stop stop stop //Stop stop stop //Stop stop stop
        //public class SignIn
        //{
        //    public string UserID;
        //    public bool authenticate(string UserName,str)
        //}
    }
}
