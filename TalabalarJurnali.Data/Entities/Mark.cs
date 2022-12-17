using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;

namespace TalabalarJurnali.Data.Entities
{
    public class Mark
    {
        public Guid Id { get; set; }
        public EMarkType Type { get; set; }
        public uint Score { get; set; }
        public Guid UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public virtual AppUser? AppUser { get; set; }
        public virtual DateTime MarkDate { get; set; }
    }
}
