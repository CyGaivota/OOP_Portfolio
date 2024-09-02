using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Portfolio
{
   

        public class Linie
        {
            public double Laenge { get; }

            public Linie(double laenge)
            {
                Laenge = laenge;
            }
        }

        public class Rechteck
        {
            private List<Linie> Linien { get; }

            public Rechteck(double laenge, double breite)
            {
                Linien = new List<Linie> { new Linie(laenge), new Linie(breite), new Linie(laenge), new Linie(breite) };
            }

            public double Umfang()
            {
                return 2 * (Linien[0].Laenge + Linien[1].Laenge);
            }

            public double Fläche()
            {
                return Linien[0].Laenge * Linien[1].Laenge;
            }
        }

        public class Dreieck
        {
            private List<Linie> Linien { get; }

            public Dreieck(double a, double b, double c)
            {
                Linien = new List<Linie> { new Linie(a), new Linie(b), new Linie(c) };
            }

            public double Umfang()
            {
                double umfang = 0;
                foreach (var linie in Linien)
                {
                    umfang += linie.Laenge;
                }
                return umfang;
            }

            public double Fläche()
            {
                // Berechnung der Fläche mit Heronscher Formel
                double s = Umfang() / 2;
                double a = Linien[0].Laenge;
                double b = Linien[1].Laenge;
                double c = Linien[2].Laenge;
                return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            }
        }

        public class Kreis
        {
            public double Radius { get; }
            private Linie Linie { get; }

            public Kreis(double radius)
            {
                Radius = radius;
                Linie = new Linie(2 * Math.PI * Radius); // Umfanglinie
            }

            public double Umfang()
            {
                return Linie.Laenge;
            }

            public double Fläche()
            {
                return Math.PI * Radius * Radius;
            }
        }

        public class FormenBehälter
        {
            public List<Rechteck> Rechtecke { get; }
            public List<Dreieck> Dreiecke { get; }
            public List<Kreis> Kreise { get; }

            public FormenBehälter(List<Rechteck> rechtecke, List<Dreieck> dreiecke, List<Kreis> kreise)
            {
                // Validierung für Rechtecke
                if (rechtecke == null || rechtecke.Count != 2)
                {
                    throw new ArgumentException("Der Behälter muss genau zwei Rechtecke enthalten.");
                }
                Rechtecke = rechtecke;

                // Validierung für Dreiecke
                if (dreiecke != null && dreiecke.Count > 4)
                {
                    throw new ArgumentException("Der Behälter darf maximal vier Dreiecke enthalten.");
                }
                Dreiecke = dreiecke ?? new List<Dreieck>();

                // Validierung für Kreise
                if (kreise == null || kreise.Count < 1 || kreise.Count > 3)
                {
                    throw new ArgumentException("Der Behälter muss zwischen ein und drei Kreise enthalten.");
                }
                Kreise = kreise;
            }

            public double GesamterUmfang()
            {
                double umfang = 0;
                foreach (var rechteck in Rechtecke)
                {
                    umfang += rechteck.Umfang();
                }

                foreach (var dreieck in Dreiecke)
                {
                    umfang += dreieck.Umfang();
                }

                foreach (var kreis in Kreise)
                {
                    umfang += kreis.Umfang();
                }

                return umfang;
            }

            public double GesamteFläche()
            {
                double fläche = 0;
                foreach (var rechteck in Rechtecke)
                {
                    fläche += rechteck.Fläche();
                }

                foreach (var dreieck in Dreiecke)
                {
                    fläche += dreieck.Fläche();
                }

                foreach (var kreis in Kreise)
                {
                    fläche += kreis.Fläche();
                }

                return fläche;
            }
        }
    }