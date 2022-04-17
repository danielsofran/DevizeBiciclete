using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevizeBiciclete.Domain
{
    public class DevizData
    {
        ClientData client;
        BicicletaData bicicleta;
        ConstatareData constatare;
        ManoperaData manopera;
        List<PiesaData> piese;

        public ClientData Client { get { return client; } set { client = value; } }
        public BicicletaData Bicicleta { get { return bicicleta; } set { bicicleta = value; } }
        public ConstatareData Constatare { get { return constatare; } set { constatare = value; } }
        public ManoperaData Manopera { get { return manopera; } set { manopera = value;} }
        public List<PiesaData> Piese { get { return piese; } set { piese = value; } }

        public float TotalPiese { get { return piese.Sum((piesa) => piesa.PretTotal);  } }
        public float TotalManopera { get { return manopera.PretTotal; } }
        public float Total { get { return TotalPiese + TotalManopera; } }

        public class ClientData
        {
            string nume;
            string adresa;
            string telefon;
            bool persoanaJuridica;
            public string Nume { get { return nume; } set { nume = value; } }
            public string Adresa { get { return adresa; } set { adresa = value; } }
            public bool PersoanaJuridica { get { return persoanaJuridica; } set { persoanaJuridica = value; } }
            public bool PersoanaFizica { get => !persoanaJuridica; set => persoanaJuridica = !value; }
            public string Telefon { get { return telefon; } set { telefon = value; } }
        }

        public class BicicletaData
        {
            string marca;
            string model;
            string culoare;
            string serie;
            public string Marca { get { return marca; } set { marca = value; } }
            public string Model { get { return model; } set { model = value; } }
            public string Culoare { get { return culoare; } set { culoare = value;} }
            public string Serie { get { return serie; } set { serie = value; } }
        }

        public class ConstatareData
        {
            string motiv;
            DateTime datain;
            DateTime dataout;
            public string Motiv { get { return motiv; } set { motiv = value; } }
            public DateTime DataIn { get { return datain; } set { datain = value; } }
            public DateTime DataOut { get { return dataout; } set { dataout = value; } }
            public string DataInText { get => string.Format("{0}.{1}.{2}", datain.Day, datain.Month, datain.Year); }
            public string DataOutText { get => string.Format("{0}.{1}.{2}", dataout.Day, dataout.Month, dataout.Year); }
        }

        public class ManoperaData
        {
            string nume;
            float durata;
            float pret;
            float discount=0;
            public string Nume { get { return nume; } set { nume = value; } }
            public float Durata { get { return durata; } set { durata = value; } }
            public float Pret { get { return pret; } set { pret = value; } }
            public float Discount { get { return discount; } set { discount = value; } }
            public float PretTotal { get { return pret - pret * discount; } }
        }

        public  class PiesaData
        {
            string cod;
            int nrbuc=1;
            string nume;
            float pret;

            public string Cod { get { return cod; } set { cod = value; } }
            public int NrBuc { get { return nrbuc; } set { nrbuc = value; } }
            public string Nume { get { return nume; } set { nume = value; } }
            public float Pret { get{ return pret; } set { pret = value; } }
            public float PretTotal { get { return pret * nrbuc; } }
        }
    }
}
