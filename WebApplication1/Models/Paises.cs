using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Paises
    {
        [DisplayName("Nombre")]
        public string name { get; set; }
        [DisplayName("Código ISO 3166-1 2")]
        public string alpha2Code { get; set; }

        [DisplayName("Código ISO 3166-1 3")]
        public string alpha3Code { get; set; }


        public List<string> callingCodes { get; set; }

        [DisplayName("Capital")]
        public string capital { get; set; }


        public List<string> altSpellings { get; set; }

        [DisplayName("Región")]
        public string region { get; set; }

        [DisplayName("Subregión")]
        public string subregion { get; set; }

        [DisplayName("Población")]
        public int population { get; set; }

        public List<float> latlng { get; set; }

        public string demonym { get; set; }

        [DisplayName("Área")]
        public double? area { get; set; }

     
        public float? gini { get; set; }

        public List<string> timezones { get; set; }

        public List<string> borders { get; set; }


        public string nativeName { get; set; }

        public string numericCode { get; set; }

        public List<currencies> currencies { get; set; }

        public List<languages> languages { get; set; }

        public translations translations { get; set; }

        public string flag { get; set; }

        public List<regionalBlocs> regionalBlocs { get; set; }

        public string cioc { get; set; }

    }


    public class currencies
    {
        public string code { get; set; }
        public string name { get; set; }

        public string symbol { get; set; }
    }

    public class languages
    {
        public string iso639_1 { get; set; }

        public string iso639_2 { get; set; }

        public string name { get; set; }

        public string nativeName { get; set; }

    
    }

    public class translations
    {
        public string de { get; set; }
        public string es { get; set; }
        public string fr { get; set; }

        public string ja { get; set; }
        public string it { get; set; }
        public string br { get; set; }

        public string pt { get; set; }

        public string nl { get; set; }

        public string fa { get; set; }
    }

    public class regionalBlocs
    {
        public string acronym { get; set; }
        public string name { get; set; }

        public string[] otherAcronyms { get; set; }

        public string[] otherNames { get; set; }


    }

}