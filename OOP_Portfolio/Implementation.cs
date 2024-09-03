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
        /// <summary>
        /// Berechnung von Umfang und Flaeche des Rechtecks
        /// </summary>
        /// <returns></returns>
            public double Umfang()
            {
                return 2 * (Linien[0].Laenge + Linien[1].Laenge);
            }

            public double Flaeche()
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
            /// <summary>
            /// Berrechnung vom Umfang des Dreiecks
            /// </summary>
            /// <returns></returns>
            public double Umfang()
            {
                double umfang = 0;
                foreach (var linie in Linien)
                {
                    umfang += linie.Laenge;
                }
                return umfang;
            }
            /// <summary>
            /// Berrechnung der Flaeche des Dreiecks
            /// </summary>
            /// <returns></returns>
            public double Flaeche()
            {
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
            
            /// <summary>
            /// Berrechnung des Radius des kreises
            /// </summary>
            /// <param name="radius"></param>
            public Kreis(double radius)
            {
                Radius = radius;
                Linie = new Linie(2 * Math.PI * Radius); // Umfanglinie
            }

            public double Umfang()
            {
                return Linie.Laenge;
            }
            /// <summary>
            /// Berrechnung der Flaeche des Kreises
            /// </summary>
            /// <returns></returns>
            public double Flaeche()
            {
                return Math.PI * Radius * Radius;
            }
        }

        public class FormenBehälter
        {
            public List<Rechteck> Rechtecke { get; }
            public List<Dreieck> Dreiecke { get; }
            public List<Kreis> Kreise { get; }
            /// <summary>
            /// Validierung für Formen 
            /// </summary>
            /// <param name="rechtecke"></param>
            /// <param name="dreiecke"></param>
            /// <param name="kreise"></param>
            /// <exception cref="ArgumentException"></exception>
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

            public double GesamteFlaeche()
            {
                double flaeche = 0;
                foreach (var rechteck in Rechtecke)
                {
                    flaeche += rechteck.Flaeche();
                }

                foreach (var dreieck in Dreiecke)
                {
                    flaeche += dreieck.Flaeche();
                }

                foreach (var kreis in Kreise)
                {
                    flaeche += kreis.Flaeche();
                }

                return flaeche;
            }
        }
    }