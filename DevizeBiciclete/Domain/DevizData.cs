﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevizeBiciclete.Domain
{
    public class DevizData
    {
        ClientData client = new ClientData();
        BicicletaData bicicleta = new BicicletaData();
        ConstatareData constatare = new ConstatareData();
        List<ManoperaData> manopere = new List<ManoperaData>();
        List<PiesaData> piese = new List<PiesaData>();

        public static DevizData? Empty = null;

        public ClientData Client { get { return client; } set { client = value; } }
        public BicicletaData Bicicleta { get { return bicicleta; } set { bicicleta = value; } }
        public ConstatareData Constatare { get { return constatare; } set { constatare = value; } }
        public List<ManoperaData> Manopere { get { return manopere; } set { manopere = value;} }
        public List<PiesaData> Piese { get { return piese; } set { piese = value; } }

        public float TotalPiese { get { return piese.Sum((piesa) => piesa.PretTotal);  } }
        public float TotalManopera { get { return piese.Sum((manopera) => manopera.PretTotal); } }
        public float Total { get { return TotalPiese + TotalManopera; } }

        public override string ToString()
        {
            string sep = "$dev$", mansep="$manoprepo$", piesesep="$pieserepo$";
            string client = Client.ToString();
            string bicicleta = Bicicleta.ToString();
            string constatare = Constatare.ToString();
            string manopere = "", piese="";
            foreach(var manopera in Manopere)
                manopere+=manopera.ToString()+mansep;
            foreach(var piesa in Piese)
                piese+=piesa.ToString()+piesesep;
            return client+sep+bicicleta+sep+constatare+sep+manopere+sep+piese;
        }

        public static DevizData FromString(string txt)
        {
            if (txt == null || txt == "") throw new Exception("sir vid!");
            string sep = "$dev$", mansep = "$manoprepo$", piesesep = "$pieserepo$";
            string[] tokens = txt.Split(new string[] { sep}, StringSplitOptions.None);
            DevizData deviz = new DevizData();
            deviz.client = ClientData.FromString(tokens[0]);
            deviz.bicicleta = BicicletaData.FromString(tokens[1]);
            deviz.constatare = ConstatareData.FromString(tokens[2]);
            string[] tokensman = tokens[3].Split(new string[] { mansep }, StringSplitOptions.None);
            string[] tokenspiese = tokens[4].Split(new string[] { piesesep }, StringSplitOptions.None);
            foreach(var manopera in tokensman)
                if(manopera is not null && manopera != "")
                    deviz.manopere.Add(ManoperaData.FromString(manopera));
            foreach(var piese in tokenspiese)
                if(piese is not null && piese != "")
                    deviz.piese.Add(PiesaData.FromString(piese));
            return deviz;
        }

        #region Classes
        public class ClientData
        {
            string nume = "";
            string adresa = "";
            string telefon = "";
            bool persoanaJuridica;

            public string Nume { get { return nume; } set { nume = value; } }
            public string Adresa { get { return adresa; } set { adresa = value; } }
            public bool PersoanaJuridica { get { return persoanaJuridica; } set { persoanaJuridica = value; } }
            public bool PersoanaFizica { get => !persoanaJuridica; set => persoanaJuridica = !value; }
            public string Telefon { get { return telefon; } set { telefon = value; } }
            
            public override string ToString()
            {
                string sep = "$cli$";
                return string.Format("{0}{1}{2}{3}{4}{5}{6}", nume, sep, 
                    adresa, sep, telefon, sep, persoanaJuridica.ToString());
            }
            public static ClientData FromString(string txt)
            {
                string sep = "$cli$";
                string[] tokens = txt.Split(new string[] { sep }, StringSplitOptions.None);
                if (tokens.Length != 4) MessageBox.Show("Citire date client eronata!");
                ClientData rez = new ClientData();
                rez.nume = tokens[0];
                rez.adresa = tokens[1];
                rez.telefon = tokens[2];
                rez.persoanaJuridica = bool.Parse(tokens[3]);
                return rez;
            }
            
            public static bool operator==(ClientData c1, ClientData c2)
            {
                return  c1.nume.Egal(c2.nume) && 
                        c1.adresa.Egal(c2.adresa) &&
                        c1.telefon.Egal(c2.telefon) &&
                        c1.persoanaJuridica == c2.persoanaJuridica;
            }
            public static bool operator!=(ClientData c1, ClientData c2) => !(c1 == c2);
        }

        public class BicicletaData
        {
            string marca = "";
            string model = "";
            string culoare = "";
            string serie = "";
            public string Marca { get { return marca; } set { marca = value; } }
            public string Model { get { return model; } set { model = value; } }
            public string Culoare { get { return culoare; } set { culoare = value;} }
            public string Serie { get { return serie; } set { serie = value; } }
            public override string ToString()
            {
                string sep = "$bic$";
                return string.Format("{0}{1}{2}{3}{4}{5}{6}", marca, sep, model, sep, culoare, sep, serie, sep);
            }
            public static BicicletaData FromString(string txt)
            {
                string sep = "$bic$";
                BicicletaData bicicleta = new BicicletaData();
                string[] tokens = txt.Split(new string[] { sep }, StringSplitOptions.None);
                if (tokens.Length != 4) MessageBox.Show("Citire date bicicleta eronata!");
                bicicleta.marca = tokens[0];
                bicicleta.model = tokens[1];
                bicicleta.culoare = tokens[2];
                bicicleta.serie = tokens[3];
                return bicicleta;
            }

            public static bool operator==(BicicletaData b1, BicicletaData b2)
                => b1.marca.Egal(b2.marca) && b1.serie.Egal(b2.serie) && b1.model.Egal(b2.model) && b1.culoare.Egal(b2.culoare);
            public static bool operator !=(BicicletaData b1, BicicletaData b2) => !(b1 == b2);
        }

        public class ConstatareData
        {
            string motiv = "";
            DateTime datain;
            DateTime dataout;
            public string Motiv { get { return motiv; } set { motiv = value; } }
            public DateTime DataIn { get { return datain; } set { datain = value; } }
            public DateTime DataOut { get { return dataout; } set { dataout = value; } }
            public string DataInText { get => string.Format("{0}.{1}.{2}", datain.Day, datain.Month, datain.Year); }
            public string DataOutText { get => string.Format("{0}.{1}.{2}", dataout.Day, dataout.Month, dataout.Year); }

            public override string ToString()
            {
                string sep = "$constat$";
                return string.Format("{0}{1}{2}{3}{4}", motiv, sep, datain.Afis(), sep, dataout.Afis());
            }
            public static ConstatareData FromString(string txt)
            {
                string sep = "$constat$";
                string[] tokens = txt.Split(sep, StringSplitOptions.None);
                ConstatareData data = new ConstatareData();
                data.motiv = tokens[0];
                data.datain = Utils.FormatDate(tokens[1]);
                data.dataout = Utils.FormatDate(tokens[2]);
                return data;
            }
            public static bool operator==(ConstatareData c1, ConstatareData c2)
                => c1.motiv.Egal(c2.motiv) && c1.datain.Egal(c2.datain) && c1.dataout.Egal(c2.dataout);
            public static bool operator!=(ConstatareData c1, ConstatareData c2) => !(c1 == c2);
        }

        public class ManoperaData
        {
            string nume="";
            float durata;
            float pret;
            float discount=0;
            public string Nume { get { return nume; } set { nume = value; } }
            public float Durata { get { return durata; } set { durata = value; } }
            public float Pret { get { return pret; } set { pret = value; } }
            public float Discount { get { return discount; } set { discount = value; } }
            public float PretTotal { get { return pret - pret * discount; } }

            public override string ToString()
            {
                string sep = "$manop$";
                return string.Format("{0}{1}{2}{3}{4}{5}{6}", nume, sep, durata.ToString(), sep, pret.ToString(), sep, discount.ToString());
            }
            public static ManoperaData FromString(string txt)
            {
                string sep = "$manop$";
                string[] tokens = txt.Split(new string[] { sep }, StringSplitOptions.None);
                ManoperaData manopera = new ManoperaData();
                manopera.Nume = tokens[0];
                manopera.Durata = float.Parse(tokens[1]);
                manopera.Pret = float.Parse(tokens[2]);
                manopera.Discount = float.Parse(tokens[3]);
                return manopera;
            }

            public static bool operator==(ManoperaData m1, ManoperaData m2)
                => m1.nume.Egal(m2.nume) && m1.durata == m2.durata && m1.pret == m2.pret && m1.discount == m2.discount;
            public static bool operator!=(ManoperaData m1, ManoperaData m2) => !(m1 == m2);
        }

        public  class PiesaData
        {
            string cod="";
            int nrbuc=1;
            string nume="";
            float pret;

            public string Cod { get { return cod; } set { cod = value; } }
            public int NrBuc { get { return nrbuc; } set { nrbuc = value; } }
            public string Nume { get { return nume; } set { nume = value; } }
            public float Pret { get{ return pret; } set { pret = value; } }
            public float PretTotal { get { return pret * nrbuc; } }

            public override string ToString()
            {
                string sep = "$piesa$";
                return string.Format("{0}{1}{2}{3}{4}{5}{6}", cod, sep, nrbuc.ToString(), sep, nume, sep, pret.ToString());
            }
            public static PiesaData FromString(string txt)
            {
                string sep = "$piesa$";
                string[] tokens = txt.Split(new string[] { sep }, StringSplitOptions.None);
                PiesaData piesa = new PiesaData();
                piesa.cod = tokens[0];
                piesa.nrbuc = int.Parse(tokens[1]);
                piesa.nume = tokens[2];
                piesa.pret = float.Parse(tokens[3]);
                return piesa;
            }
            public static bool operator==(PiesaData p1, PiesaData p2)
                => p1.nume.Egal(p2.nume) && p1.cod.Egal(p2.cod) && p1.nrbuc == p2.nrbuc && p1.pret == p2.pret;
            public static bool operator !=(PiesaData p1, PiesaData p2) => !(p1 == p2);
        }
        #endregion
    }
}
