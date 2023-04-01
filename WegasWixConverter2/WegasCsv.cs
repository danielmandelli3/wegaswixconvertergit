using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration.Attributes;

namespace WegasWixConverter2
{
    class WegasCsv
    {
        [Name("Numero articolo")]
        public string NumeroArticolo { get; set; }
        [Name("Chiave di ricerca")]
        public string ChiaveDiRicerca { get; set; }
        [Name("Descrizione")]
        public string Descrizione { get; set; }
        [Name("Denominazione")]
        public string Denominazione { get; set; }
        [Name("Libero")]
        public string Libero { get; set; }
        [Name("Annata")]
        public string Annata { get; set; }
        [Name("Gradazione")]
        public string Gradazione { get; set; }
        [Name("Stock attuale")]
        public string StockAttuale { get; set; }
        [Name("Riservazioni (ordini)")]
        public string RiservazioniOrdini { get; set; }
        [Name("Prezzi livello 5")]
        public string PrezziLivello5 { get; set; }
        [Name("Attivo/inattivo")]
        public string AttivoInattivo { get; set; }
    }
}
