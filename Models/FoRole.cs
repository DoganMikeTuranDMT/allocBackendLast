using System;
using System.Collections.Generic;

namespace Allocation.Models
{
    public partial class FoRole
    {
        public FoRole()
        {
            FoRoleSubSkill = new HashSet<FoRoleSubSkill>();
            TrackRole = new HashSet<TrackRole>();
        }

        public int ClientId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public Boolean Template { get; set; }

        public virtual FoClient Client { get; set; }
        public virtual ICollection<FoRoleSubSkill> FoRoleSubSkill { get; set; }
        public virtual ICollection<TrackRole> TrackRole { get; set; }
    }
}
