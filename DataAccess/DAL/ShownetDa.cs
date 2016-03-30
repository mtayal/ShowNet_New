using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace DataAccess.DAL
{
    public class ShownetDa : BaseDa
    {
        public ShownetDa(IUnitOfWork unityOfWork)
            : base(unityOfWork)
        {

        }

        //public IEnumerable<HorseShowViewModel> GetHorseShow(int numberOfShows, HorseShowMode? showMode)
        //{
        //    try
        //    {
        //        var Shows = (from x in UnitOfWork.HorseShowRepository.GetQuery()
        //                     where x.StartDate <= DateTime.Now.AddDays(1) && x.IsWWWVisible && x.ShowMode == showMode
        //                     orderby x.StartDate descending
        //                     select new HorseShowViewModel { 
        //                     HorseShowID=x.HorseShowID,
        //                     HorseShowName=x.HorseShowName,
        //                     ShowModeString = GetLabelForShowMode(showMode)

        //                     }).Take(6);
        //        return Shows.ToList();
        //    }
        //    catch (Exception)
        //    {
                
        //        throw;
        //    }
            
        //}

        //public string GetLabelForShowMode(HorseShowMode mode)
        //{
        //    switch (mode)
        //    {
        //        case HorseShowMode.Jumper:
        //            return "H/J";
        //        case HorseShowMode.Dressage:
        //            return "D";
        //        case HorseShowMode.Reining:
        //            return "R";
        //        default:
        //            return "H/J";
        //    }
        //}

        //public HorseShow[] GetShows()
        //{
        //    return new HSO.ShowNetWS().GetVisibleShows(10, HorseShow.HorseShowMode.All);
        //}

        //public HorseShow[] GetActiveHorseShows()
        //{
        //    return new HSO.ShowNetWS().GetVisibleShows(30, null);
        //}
        
    }
}
