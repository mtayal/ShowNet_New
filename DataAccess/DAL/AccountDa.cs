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


                MemberDetailsViewModel md = new MemberDetailsViewModel();

                var MemberDetail = (from data in UnitOfWork.MemberDetailsRepository.GetQuery()
                                    where data.Email == email && data.Password == password
                                    select new MemberDetailsViewModel
                                    {
                                        MemberID = data.MemberID,
                                        Email = data.Email,
                                        FirstName = data.FirstName
                                    }).FirstOrDefault();

                return MemberDetail;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}



