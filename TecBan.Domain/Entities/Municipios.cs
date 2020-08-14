using System.Collections.Generic;

namespace TecBan.Domain.Entities
{
    public class Municipios
    {
        public int munId { get; set; }
        public string munNome { get; set; }
        public int munUf { get; set; }
        public decimal munISS { get; set; }
        public decimal munICMS { get; set; }
        public decimal munICMSInterno { get; set; }
        public virtual UFS ufs { get; set; }
        public virtual ICollection<ATM> atms { get; set; }
    }
}
