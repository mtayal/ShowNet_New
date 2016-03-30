using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class PYRAMID_MAP
    {
        public int PyramidMapID { get; set; }
        public Nullable<int> PyramidCompetitionID { get; set; }
        public Nullable<int> HorseShowID { get; set; }
    }
}
