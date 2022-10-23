using MedicareManagementSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedicareManagementSystem.DAL
{
    public class Covid19InfoPerPersonDAL : ICovid19InfoPerPersonDAL
    {
        MedicareManagementSystemContext MedicareManagementSystemContext = new MedicareManagementSystemContext();

        public List<Covid19InfoPerPerson> GetAllCovid19InfoPerPerson()
        {
            try
            {
                return MedicareManagementSystemContext.Covid19InfoPerPerson.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool AddCovid19InfoPerPerson(Covid19InfoPerPerson newCovid19PersonalData)
        {
            try
            {
                MedicareManagementSystemContext.Add(newCovid19PersonalData);
                MedicareManagementSystemContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public bool UpdateCovid19InfoPerPerson(string covid19PerCode, Covid19InfoPerPerson newInfo)
        {
            try
            {
                VaccinesPerPerson copy1 = new VaccinesPerPerson();

                foreach (var item in MedicareManagementSystemContext.VaccinesPerPerson)
                {
                    if (item.Covid19Id == covid19PerCode)
                    {

                        copy1 = item;
                        MedicareManagementSystemContext.VaccinesPerPerson.Remove(item);

                    }
                }

                MedicareManagementSystemContext.SaveChanges();


                Covid19InfoPerPerson currentInfoToUpdate = MedicareManagementSystemContext.Covid19InfoPerPerson.SingleOrDefault(x => x.Covid19PersonalCode == covid19PerCode);

                MedicareManagementSystemContext.Entry(currentInfoToUpdate).CurrentValues.SetValues(newInfo);
                MedicareManagementSystemContext.SaveChanges();


                MedicareManagementSystemContext.VaccinesPerPerson.Add(copy1);
                MedicareManagementSystemContext.SaveChanges();


                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool DeleteMemberInfo(string covidId)
        {
            try
            {

                Covid19InfoPerPerson currentInfoToDelete = MedicareManagementSystemContext.Covid19InfoPerPerson.SingleOrDefault(x => x.Covid19PersonalCode == covidId);
                MedicareManagementSystemContext.Remove(currentInfoToDelete);
                MedicareManagementSystemContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}

