using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TecBan.Domain.Entities
{
    public class UFS
    {
        [Key]
        public int ufSigla { get; set; }

        [Required]
        //[StringLength(50)]
        public string ufNome { get; set; }

        public virtual ICollection<Municipios> municipios { get; set; }

    }
}
