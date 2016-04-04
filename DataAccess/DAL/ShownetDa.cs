using CommanLibrary;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;
using AutoMapper;

namespace DataAccess.DAL
{
    public class ShownetDa : BaseDa
    {
        public ShownetDa(IUnitOfWork unityOfWork)
            : base(unityOfWork)
        {

        }

        public IEnumerable<HorseShowViewModel> GetHorseShow(int numberOfShows, HorseShowMode showMode)
        {
            try
            {
                DateTime nowPlusOne=DateTime.Now.AddDays(1);
                string mode = GetLabelForShowMode(showMode);
                var Shows = (from x in UnitOfWork.HorseShowRepository.GetQuery()
                             where x.StartDate <= nowPlusOne && x.IsWWWVisible //&& x.ShowMode == showMode
                             orderby x.StartDate descending
                             select new HorseShowViewModel
                             {
                                 HorseShowID = x.HorseShowID,
                                 HorseShowName = x.HorseShowName,
                                 ShowModeString = mode,
                                 StartDate=x.StartDate

                             }).Take(numberOfShows);
                return Mapper.Map <IEnumerable<HorseShowViewModel>> (Shows.ToList());
            }
            catch (Exception)
            {

                throw;
            }

        }
        public IEnumerable<HorseShowViewModel> GetUpComingHorseShow(int numberOfShows, HorseShowMode showMode)
        {
            try
            {
                var Shows = (from x in UnitOfWork.HorseShowRepository.GetQuery()
                             where x.StartDate > DateTime.Now 
                             orderby x.StartDate descending
                             select new HorseShowViewModel
                             {
                                 HorseShowID = x.HorseShowID,
                                 HorseShowName = x.HorseShowName,
                                 StartDate = x.StartDate,
                                 EndDate=x.EndDate

                             }).Take(numberOfShows);
                return Mapper.Map<IEnumerable<HorseShowViewModel>>(Shows.ToList());
            }
            catch (Exception)
            {

                throw;
            }

        }

        public string GetLabelForShowMode(HorseShowMode mode)
        {
            switch (mode)
            {
                case HorseShowMode.Jumper:
                    return "H/J";
                case HorseShowMode.Dressage:
                    return "D";
                case HorseShowMode.Reining:
                    return "R";
                default:
                    return "H/J";
            }
        }

        

        
        
    }
}
