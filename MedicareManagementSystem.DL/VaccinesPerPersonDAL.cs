using MedicareManagementSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedicareManagementSystem.DAL
{
    public class VaccinesPerPersonDAL : IVaccinesPerPersonDAL
    {
        MedicareManagementSystemContext MedicareManagementSystemContext = new MedicareManagementSystemContext();
        public List<VaccinesPerPerson> GetAllMemberVaccine()
        {
            try
            {
                return MedicareManagementSystemContext.VaccinesPerPerson.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool AddMemberVaccine(VaccinesPerPerson newPerVaccine)
        {
            try
            {
                MedicareManagementSystemContext.Add(newPerVaccine);
                MedicareManagementSystemContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool UpdateMemberVaccine(string covidId, VaccinesPerPerson newVaccine)
        {
            try
            {
                Covid19InfoPerPerson copy1 = new Covid19InfoPerPerson();
                PersonalData copy2 = new PersonalData();

                foreach (var item in MedicareManagementSystemContext.Covid19InfoPerPerson)
                {
                    if (item.Covid19PersonalCode == covidId)
                    {
                        foreach (var item1 in MedicareManagementSystemContext.PersonalData)
                        {
                            if (item1.Id == item.PersonId)
                            {
                                copy2 = item1;
                                MedicareManagementSystemContext.PersonalData.Remove(item1);

                            }
                        }
                        copy1 = item;
                        MedicareManagementSystemContext.Covid19InfoPerPerson.Remove(item);

                    }


                }
                MedicareManagementSystemContext.SaveChanges();


                VaccinesPerPerson currentVaccineToUpdate = MedicareManagementSystemContext.VaccinesPerPerson.SingleOrDefault(x => x.Covid19Id == covidId);

                MedicareManagementSystemContext.Entry(currentVaccineToUpdate).CurrentValues.SetValues(newVaccine);
                MedicareManagementSystemContext.SaveChanges();


                MedicareManagementSystemContext.PersonalData.Add(copy2);
                MedicareManagementSystemContext.SaveChanges();
                MedicareManagementSystemContext.Covid19InfoPerPerson.Add(copy1);
                MedicareManagementSystemContext.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool DeleteMemberVaccine(string covidId)
        {
            try
            {

                VaccinesPerPerson currentVaccineToDelete = MedicareManagementSystemContext.VaccinesPerPerson.SingleOrDefault(x => x.Covid19Id == covidId);
                MedicareManagementSystemContext.Remove(currentVaccineToDelete);
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
    

