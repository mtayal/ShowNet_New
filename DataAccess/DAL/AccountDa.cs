using DataAccess.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;
using System.Data.Entity.Validation;

namespace DataAccess.DAL
{
    public class AccountDa : BaseDa
    {
        public AccountDa(IUnitOfWork unityOfWork)
            : base(unityOfWork)
        {
        }
        public void Registration(MemberDetailsViewModel x)
        {
            try
            {
                UnitOfWork.MemberDetailsRepository.Insert(new MEMBER_DETAILS { sms =String.Empty,DateJoined=DateTime.Now, Salutation = x.Salutation, FirstName = x.FirstName, LastName = x.LastName, UserName = x.UserName, Password = x.Password, PasswordHint = x.PasswordHint, Email = x.Email, AreaCode = x.AreaCode, Phone = x.Phone, Address1 = x.Address1, Address2 = x.Address2, City = x.City, State = x.State, Zip = x.Zip, Mode=x.Mode });
                UnitOfWork.Save();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public MemberDetailsViewModel Login(string email, string password)
        {
            try
            {


                var MemberDetail = (from data in UnitOfWork.MemberDetailsRepository.GetQuery()
                                    where (data.Email == email || data.UserName == email) && data.Password == password
                                    select new MemberDetailsViewModel
                                    {
                                        MemberID = data.MemberID,
                                        Email = data.Email,
                                        UserName = data.UserName
                                    }).FirstOrDefault();

                return MemberDetail;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public MemberDetailsViewModel EditMyShowNet(int memberId)
        {
            try
            {
                MemberDetailsViewModel md = new MemberDetailsViewModel();

                var MemberDetail = (from data in UnitOfWork.MemberDetailsRepository.GetQuery()
                                    where data.MemberID == memberId
                                    select new MemberDetailsViewModel
                                    {
                                        MemberID = data.MemberID,
                                        Salutation = data.Salutation,
                                        FirstName = data.FirstName.Trim(),
                                        LastName = data.LastName.Trim(),
                                        UserName = data.UserName.Trim(),
                                        Password = data.Password,
                                        PasswordHint = data.PasswordHint.Trim(),
                                        Email = data.Email.Trim(),
                                        AreaCode = data.AreaCode.Trim(),
                                        Phone = data.Phone.Trim(),
                                        Address1 = data.Address1.Trim(),
                                        Address2 = data.Address2.Trim(),
                                        City = data.City.Trim(),
                                        State = data.State.Trim(),
                                        ConfirmPassword = data.Password,
                                        Zip = data.Zip.Trim()
                                    }).FirstOrDefault();

                return MemberDetail;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool UpdateMyShowNet(MemberDetailsViewModel md_New)
        {
            try
            {
                MEMBER_DETAILS md = new MEMBER_DETAILS();
                md = UnitOfWork.MemberDetailsRepository.GetQuery().FirstOrDefault(x => x.MemberID == md_New.MemberID);

                md.Salutation = md_New.Salutation;
                md.FirstName = md_New.FirstName;
                md.LastName = md_New.LastName;
                md.UserName = md_New.UserName;
                md.Password = md_New.Password;
                md.PasswordHint = md_New.PasswordHint;
                md.Email = md_New.Email;
                md.AreaCode = md_New.AreaCode;
                md.Phone = md_New.Phone;
                md.Address1 = md_New.Address1;
                md.Address2 = md_New.Address2;
                md.City = md_New.City;
                md.State = md_New.State;
                md.Zip = md_New.Zip;

                UnitOfWork.MemberDetailsRepository.Update(md);
                UnitOfWork.MemberDetailsRepository.context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}



