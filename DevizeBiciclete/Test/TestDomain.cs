﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevizeBiciclete.Domain;
using System.Diagnostics;

namespace DevizeBiciclete.Test
{
    static class TestDomain
    {
        static DevizData.ClientData clientData;
        static DevizData.BicicletaData bicicletaData;
        static DevizData.ConstatareData constatareData;
        static DevizData.ManoperaData manoperaData;
        static DevizData.PiesaData piesaData;
        static DevizData devizData;
        static void testClientData()
        {
            clientData = new DevizData.ClientData();
            clientData.PersoanaJuridica = true;
            clientData.Adresa = "c.r.vivu";
            clientData.Telefon = "0729010188";
            clientData.Nume = "Daniel";
            Debug.Assert(DevizData.ClientData.FromString(clientData.ToString()) == clientData, "error fromstring tostring");
        }

        static void testBicicletaData()
        {
            bicicletaData = new DevizData.BicicletaData();
            bicicletaData.Serie = "xb";
            bicicletaData.Marca = "cross";
            bicicletaData.Culoare = "verde";
            bicicletaData.Model = "mtb";
            Debug.Assert(DevizData.BicicletaData.FromString(bicicletaData.ToString()) == bicicletaData);
        }

        static void testConstatareData()
        {
            constatareData = new DevizData.ConstatareData();
            constatareData.Motiv = "bani";
            constatareData.DataIn = new DateTime(2022, 02, 22);
            constatareData.DataOut = new DateTime(2022, 03, 05);
            Debug.Assert(DevizData.ConstatareData.FromString(constatareData.ToString()) == constatareData);
        }

        static void testManoperaData()
        {
            manoperaData = new DevizData.ManoperaData();
            manoperaData.Nume = "reparatii";
            manoperaData.Durata = 2.5f;
            manoperaData.Pret = 200f;
            Debug.Assert(DevizData.ManoperaData.FromString(manoperaData.ToString()) == manoperaData);
        }

        static void testPiesaData()
        {
            piesaData = new DevizData.PiesaData();
            piesaData.Nume = "piesa";
            piesaData.Pret = 50f;
            piesaData.Cod = "1v3cuy3v7vc683";
            piesaData.NrBuc = 3;
            Debug.Assert(DevizData.PiesaData.FromString(piesaData.ToString()) == piesaData);
        }

        static void testDeviz()
        {
            devizData = new DevizData();
            devizData.Client = clientData;
            devizData.Bicicleta = bicicletaData;
            devizData.Constatare = constatareData;
            devizData.Manopere.Add(manoperaData);
            devizData.Manopere.Add(manoperaData);
            devizData.Piese.Add(piesaData);
            devizData.Piese.Add(piesaData);
            devizData.Piese.Add(piesaData);
            Debug.Assert(DevizData.FromString(devizData.ToString()).Constatare == constatareData);
        }

        public static void Run()
        {
            testClientData();
            testBicicletaData();
            testConstatareData();
            testManoperaData();
            testPiesaData();
            testDeviz();
            MessageBox.Show(Application.StartupPath);
            string pdfpath = Application.StartupPath + "testpdf.pdf";
            
        }
    }
}