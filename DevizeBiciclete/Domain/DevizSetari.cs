using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevizeBiciclete.Domain
{
    public class DevizSetari
    {
        string titlu = "DEVIZ";
        ServiceData service = new ServiceData();
        CertificatData certificat = new CertificatData();
        SemnaturaServiceData semnatura = new SemnaturaServiceData();
        Bitmap logo;

        public string Titlu { get => titlu; set => titlu = value; }
        public ServiceData Service { get => service; set => service = value; }
        public CertificatData Certificat { get => certificat; set => certificat = value; }
        public SemnaturaServiceData Semnatura { get => semnatura; set => semnatura = value; }
        public Bitmap Logo { get => logo; set => logo = value; }

        public class ServiceData
        {
            string titlu="Service";
            string nume="";
            string adresa = "";
            string email = "";
            string telefon = "";
            string registru = ""; //
            string ro = "";

            public string Titlu { get => titlu; set => titlu = value; } 
            public string Nume { get => nume; set => nume = value; }    
            public string Adresa { get => adresa; set => adresa = value; }
            public string Email { get => email; set => email = value; }
            public string Telefon { get => telefon; set => telefon = value;}
            public string Registru { get => registru; set => registru = value; }
            public string RO { get => ro; set => ro = value; }

        }

        public class CertificatData
        {
            string title="CERTIFICAT DE CALITATE SI GARANTIE";
            string intro;
            List<string> linii;
            string final;

            public string Title { get => title; set => title = value; }
            public string Intro { get => intro; set => intro = value; }
            public List<string> Linii { get => linii; set => linii = value;}
            public string Final { get => final; set => final = value; }
        }

        public class SemnaturaServiceData
        {
            string titlu = "Semnatura Service";
            string text;
            Bitmap image;
            public string Titlu { get => titlu; set => titlu = value;}
            public Bitmap Image { get => image; set => image = value; }
            public string Text { get => text; set => text = value; }
        }

        
    }
}
