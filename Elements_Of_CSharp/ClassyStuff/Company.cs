using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassyStuff
{
    class Company : IManagable
    {
        string companyName;
        List<AbstractEmployee> company_list = new List<AbstractEmployee>();

        public string CompanyName { get => companyName; set => companyName = value; }

        public void Fire(AbstractEmployee e)
        {
            company_list.Remove(e);
        }

        public void Hire(AbstractEmployee e)
        {
            company_list.Add(e);
        }

        public void Raise(AbstractEmployee e, AbstractEmployee higher)
        {
            int index = company_list.IndexOf(e);
            company_list[index] = higher;
        }
    }
}
