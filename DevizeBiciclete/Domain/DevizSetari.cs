using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevizeBiciclete.Domain
{
    public class DevizSetari
    {
        static string titlu = "DEVIZ";
        //ServiceData service;
        //CertificatData certificat;
        //SemnaturaServiceData semnatura;
        //Bitmap logo;

        public string Titlu { get => titlu; set => titlu = value; }
        //public ServiceData Service { get => service; set => service = value; }
        //public CertificatData Certificat { get => certificat; set => certificat = value; }
        //public SemnaturaServiceData Semnatura { get => semnatura; set => semnatura = value; }
        //public Bitmap Logo { get => logo; set => logo = value; }

        public static class Service
        {
            static string titlu ="Service";
            static string nume = "";
            static string adresa = "";
            static string email = "";
            static string telefon = "";
            static string registru = ""; //
            static string ro = "";

            public static string Titlu { get => titlu; set => titlu = value; } 
            public static string Nume { get => nume; set => nume = value; }    
            public static string Adresa { get => adresa; set => adresa = value; }
            public static string Email { get => email; set => email = value; }
            public static string Telefon { get => telefon; set => telefon = value;}
            public static string Registru { get => registru; set => registru = value; }
            public static string RO { get => ro; set => ro = value; }

        }

        public static class Certificat
        {
            static string title ="CERTIFICAT DE CALITATE SI GARANTIE";
            static string intro;
            static List<string> linii;
            static string final;

            public static string Title { get => title; set => title = value; }
            public static string Intro { get => intro; set => intro = value; }
            public static List<string> Linii { get => linii; set => linii = value;}
            public static string Final { get => final; set => final = value; }
        }

        public static class SemnaturaService
        {
            static string titlu = "Semnatura Service";
            static string text;
            static Bitmap image;
            public static string Titlu { get => titlu; set => titlu = value;}
            public static Bitmap Image { get => image; set => image = value; }
            public static string Text { get => text; set => text = value; }
        }
    }
}
