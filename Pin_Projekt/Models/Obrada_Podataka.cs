using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pin_Projekt.Models
{
    public class Obrada_Podataka
    {
        
        public int ID { get; set; }
        [Display(Name = "Unos Ime Proizvoda")]
        public string Ime_Proizvoda { get; set; }
        [Display(Name = "Unos Tržišta")]
        public string Tržište { get; set; }
        [Display(Name = "Datum")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [Display(Name = "Provjera Etikete")]
        public string Etiketa { get; set; }
        [Display(Name = "Sila začepljenosti jedinica(NM)")]
        public int Čep { get; set; }
        [Display(Name = "Izgled Proizvoda(općenito)")]
        public string Izgled_Proizvoda { get; set; }


    }
}
