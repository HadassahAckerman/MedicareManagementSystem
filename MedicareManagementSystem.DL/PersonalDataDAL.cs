using MedicareManagementSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedicareManagementSystem.DAL
{
    public class PersonalDataDAL : IPersonalDataDAL
    {

        MedicareManagementSystemContext MedicareManagementSystemContext = new MedicareManagementSystemContext();
        public List<PersonalData> GetAllPersonalData()
        {
            try
            {
                return MedicareManagementSystemContext.PersonalData.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool AddPersonalData(PersonalData newPerson)
        {
            try
            {
                MedicareManagementSystemContext.Add(newPerson);
                MedicareManagementSystemContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //public bool UpdatePersonalData(string id, PersonalData personalData)
        //{
        //    try
        //    {
        //        VaccinesPerPerson copy1=new VaccinesPerPerson();
        //        Covid19InfoPerPerson copy2= new Covid19InfoPerPerson();
        //        foreach (var item in MedicareManagementSystemContext.Covid19InfoPerPerson)
        //        {
        //            if (item.PersonId == id)
        //            {
        //                foreach (var item1 in MedicareManagementSystemContext.VaccinesPerPerson)
        //                {
        //                    if (item.Covid19PersonalCode == item1.Covid19Id)
        //                    {
        //                         copy1 = item1; 
        //                        MedicareManagementSystemContext.VaccinesPerPerson.Remove(item1);

        //                    }
        //                }
        //                copy2 = item;
        //                MedicareManagementSystemContext.Covid19InfoPerPerson.Remove(item);

        //            }
        //        }
        //        MedicareManagementSystemContext.SaveChanges();


        //        PersonalData currentPersonalDataToUpdate = MedicareManagementSystemContext.PersonalData.SingleOrDefault(x => x.Id == id);

        //        MedicareManagementSystemContext.Entry(currentPersonalDataToUpdate).CurrentValues.SetValues(personalData);
        //        MedicareManagementSystemContext.SaveChanges();

        //        MedicareManagementSystemContext.Covid19InfoPerPerson.Add(copy2);
        //        MedicareManagementSystemContext.SaveChanges();

        //        MedicareManagementSystemContext.VaccinesPerPerson.Add(copy1);
        //        MedicareManagementSystemContext.SaveChanges();

        //        return true;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        public bool UpdatePersonalData(PersonalData personalData)
        {
            try
            {

                PersonalData currentPersonalDataToUpdate = MedicareManagementSystemContext.PersonalData.SingleOrDefault(x => x.Id == personalData.Id);

                MedicareManagementSystemContext.Entry(currentPersonalDataToUpdate).CurrentValues.SetValues(personalData);
                MedicareManagementSystemContext.SaveChanges();

               

                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool DeletePersonalData(string id)
        {
            try
            {
                foreach (var item in MedicareManagementSystemContext.Covid19InfoPerPerson)
                {
                    if (item.PersonId == id)
                    {
                        foreach (var item1 in MedicareManagementSystemContext.VaccinesPerPerson)
                        { 
                            if (item.Covid19PersonalCode == item1.Covid19Id)
                            {
                                    MedicareManagementSystemContext.VaccinesPerPerson.Remove(item1);

                            }
                        }
                        MedicareManagementSystemContext.Covid19InfoPerPerson.Remove(item);
                    }     
                }

               
                PersonalData currentPersonalDataToDelete = MedicareManagementSystemContext.PersonalData.SingleOrDefault(x => x.Id == id);
                MedicareManagementSystemContext.Remove(currentPersonalDataToDelete);
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

