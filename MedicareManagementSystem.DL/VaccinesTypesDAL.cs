using MedicareManagementSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedicareManagementSystem.DAL
{
    public class VaccinesTypesDAL : IVaccinesTypesDAL
    {
        MedicareManagementSystemContext MedicareManagementSystemContext = new MedicareManagementSystemContext();
        public List<VaccinesTypes> GetAllVaccinesTypes()
        {
            try
            {
                return MedicareManagementSystemContext.VaccinesTypes.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool AddVaccineType(VaccinesTypes newVaccine)
        {
            try
            {
                MedicareManagementSystemContext.Add(newVaccine);
                MedicareManagementSystemContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool UpdateVaccineType(int type, VaccinesTypes vaccineType)
        {
            try
            {
                VaccinesPerPerson copy1 = new VaccinesPerPerson();
                Covid19InfoPerPerson copy2 = new Covid19InfoPerPerson();

                foreach (var item in MedicareManagementSystemContext.VaccinesPerPerson)
                {
                    if (item.VaccineType == type)
                    {
                        foreach (var item1 in MedicareManagementSystemContext.Covid19InfoPerPerson)
                        {
                            if (item1.Covid19PersonalCode == item.Covid19Id)
                            {
                                copy2 = item1;
                                MedicareManagementSystemContext.Covid19InfoPerPerson.Remove(item1);

                            }
                        }
                                copy1 = item;
                        MedicareManagementSystemContext.VaccinesPerPerson.Remove(item);

                    }


                }
                MedicareManagementSystemContext.SaveChanges();


                VaccinesTypes currentVaccineToUpdate = MedicareManagementSystemContext.VaccinesTypes.SingleOrDefault(x => x.Type == type);

                MedicareManagementSystemContext.Entry(currentVaccineToUpdate).CurrentValues.SetValues(vaccineType);
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
        public bool DeleteVaccineType(int type)
        {
            try
            {

                foreach (var item in MedicareManagementSystemContext.VaccinesPerPerson)
                {
                    if (item.VaccineType == type)
                    {
                        MedicareManagementSystemContext.VaccinesPerPerson.Remove(item);

                    }
                }



                VaccinesTypes currentVaccineToDelete = MedicareManagementSystemContext.VaccinesTypes.SingleOrDefault(x => x.Type == type);
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
