using System;
using System.Collections.Generic;

namespace Allocation.Models
{
    public partial class FoSubSkill
    {
        public FoSubSkill()
        {
            FoRoleSubSkill = new HashSet<FoRoleSubSkill>();
            UserSubSkill = new HashSet<UserSubSkill>();
        }

        public int ClientId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int SkillId { get; set; }
        public int? IdealProficiency { get; set; }

        public virtual FoClient Client { get; set; }
        public virtual FoSkill FoSkill { get; set; }
        public virtual ICollection<FoRoleSubSkill> FoRoleSubSkill { get; set; }
        public virtual ICollection<UserSubSkill> UserSubSkill { get; set; }
    }
}
