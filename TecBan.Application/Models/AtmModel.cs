using System;
using System.ComponentModel.DataAnnotations;
using TecBan.Domain.Entities;
namespace TecBan.Application.Models
{
    public class AtmModel 
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Campo cadastro é obrigatório")]
        [DisplayFormat(DataFormatString = "mm/dd/yyyy")]
        [Display(Name = "Data de cadastro")]
        public DateTime atmDTCadastro { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Nome ATM")]
        public string atmNome { get; set; }

        [Required(ErrorMessage = "Campo nome da Ponto de Atendimento é obrigatório")]
        [Range(8, 8)]
        [Display(Name = "Ponto de Atendimento (PA)")]
        public int atmPA { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Código de equipamento TECBAN (PC)")]
        public string atmPC { get; set; }

        [Required(ErrorMessage = "Campo endereço é um campo obrigatório")]
        [StringLength(50)]
        [Display(Name = "Endereço")]
        public string atmEndereco { get; set; }


        [StringLength(50)]
        [Display(Name = "Complemento")]
        public string atmComplemento { get; set; }

        [Required(ErrorMessage = "Campo Bairro é um campo obrigatório")]
        [StringLength(50)]
        [Display(Name = "Bairro")]
        public string atmBairro { get; set; }


        [Required(ErrorMessage = "Campo Cidade é um campo obrigatório")]
        [Range(1, 1)]
        [Display(Name = "Cidade")]
        public int atmCidade { get; set; }

        [Required(ErrorMessage = "Campo UF é um campo obrigatório")]
        [Range(1, 1)]
        [Display(Name = "UF")]
        public int atmUF { get; set; }


        [Required(ErrorMessage = "Campo CEP é um campo obrigatório")]
        [StringLength(8)]
        [Display(Name = "CEP")]
        public string atmCep { get; set; }



        [StringLength(50)]
        [Display(Name = "Ponto de Referência")]
        public string atmPontoRef { get; set; }

        [Required(ErrorMessage = "Campo Longitude é um campo obrigatório")]
        [Range(8, 6)]
        [Display(Name = "Longitude")]
        public int atmLongitude { get; set; }

        [Required(ErrorMessage = "Campo Latitude é um campo obrigatório")]
        [Range(8, 6)]
        [Display(Name = "Latitude")]
        public int atmLatitude { get; set; }
        public virtual Municipios municipios { get; set; }
    }
}
