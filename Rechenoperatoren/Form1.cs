using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rechenoperatoren
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnModulo_Click(object sender, EventArgs e)
		{
			var zahl1 = 20;
			var zahl2 = 4;
			int ergebnis = zahl1 / zahl2;

			lblAnzeige.Text = 
				zahl1.ToString()
				+ " durch "
				+ zahl2.ToString()
				+ " ist "
				+ ergebnis.ToString()
				+ " Rest "
				+ (zahl1 % zahl2).ToString();
		}

		private void btnTageInWochen_Click(object sender, EventArgs e)
		{
			// Aufgabe: Rechne Tage in Wochen + Tage um
			// ----------------------------------------

			// Variable für Anzahl der Tage anlegen
			var tageAmAnfang = 25;

			// Ergebnisvariable für Wochen anlegen
			int ergebnisInWochen;

			// Ergebnisvariable für Tage anlegen
			int ergebnisInTagen;

			// Tage => Wochen + Tage umrechnen
			ergebnisInWochen = tageAmAnfang / 7; // Ergebnis : 3
			ergebnisInTagen = tageAmAnfang % 7;  // Ergebnis : 4

			// Anzeige: ... Tage sind ... Wochen und ... Tage
			// => Ausgabe auf dem Label
			lblAnzeige.Text =
				tageAmAnfang.ToString()
				+ " Tage sind "
				+ ergebnisInWochen.ToString()
				+ " Wochen und "
				+ ergebnisInTagen.ToString()
				+ " Tage.";

			// Anzahl der Tage: 25



			// Überlegungen:
			// --------------
			// Ergebis in Wochen => Division
			// Ergebnis in Tagen => Modulo
			// => Text-Eigenschaft vom Label beschreiben
			// => int in string umwandeln mit ToString()
			// String-Verknüpfungen mit +
		}

		private void btnInkrement_Click(object sender, EventArgs e)
		{
			int x = 5;
			x++;
			++x;
			x = x + 1;
			lblAnzeige.Text = "Ergebnis: " + x;
		}

		private void btnGrößer_Click(object sender, EventArgs e)
		{
			lblAnzeige.Text =
				"Ist 5 größer 3? "
				+ (5 > 3);
		}

		private void btnKleiner_Click(object sender, EventArgs e)
		{
			lblAnzeige.Text =
				"Ist 5 kleiner 3? "
				+ (5 < 3);
		}

		private void btnGleich_Click(object sender, EventArgs e)
		{
			lblAnzeige.Text =
				"Ist 5 gleich 3? "
				+ (5 == 3);
		}

		private void btnUngleich_Click(object sender, EventArgs e)
		{
			lblAnzeige.Text =
				"Ist 5 ungleich 3? "
				+ (5 != 3);
		}

		private void btnUnd_Click(object sender, EventArgs e)
		{
			lblAnzeige.Text =
				"Ist 5 größer 3 und 5 größer 6? "
				+ ((5 > 3) && (5 > 6));
		}

		private void btnOder_Click(object sender, EventArgs e)
		{
			lblAnzeige.Text =
				"Ist 5 größer 3 oder 5 größer 6? "
				+ ((5 > 3) || (5 > 6));
		}

		private void btnXor_Click(object sender, EventArgs e)
		{
			lblAnzeige.Text =
				"Ist nur 5 größer 3 oder nur 5 größer 6? "
				+ ((5 > 3) ^ (5 > 6));
		}

		private void btnAusdruck1_Click(object sender, EventArgs e)
		{
			// Variable des geeigneten Datentyps erstellen
			Boolean ergebnis;

			// Ergebnis bilden
			ergebnis = (4 > 3) && (-4 > -3);

			// Ergebnis anzeigen
			lblAnzeige.Text =
				"Das Ergebnis des Ausdrucks 4 > 3 && -4 > -3 ist: "
				+ ergebnis;
		}

		private void btnAusdruck2_Click(object sender, EventArgs e)
		{
			// Variable des geeigneten Datentyps erstellen
			Boolean ergebnis;

			// Ergebnis bilden
			ergebnis = (4 > 3) || (-4 > -3);
			
			// Ergebnis anzeigen (mit Zwischenvariable)
			lblAnzeige.Text =
				"Das Ergebnis des Ausdrucks 4 > 3 || -4 > -3 ist: "
				+ ergebnis;

			// Ergebnis anzeigen (direkt)
			lblAnzeige.Text =
				"Das Ergebnis des Ausdrucks 4 > 3 || -4 > -3 ist: "
				+ ((4 > 3) || (-4 > -3));
		}

		private void btnVerknüpfung_Click(object sender, EventArgs e)
		{
			//lblAnzeige.Text = "Hallo" + " Welt.";
			//lblAnzeige.Text = 5.ToString();
			lblAnzeige.Text = 
				"Angezeigte Zahl: " 
				+ 5
				+ " "
				+ 6;

			// lblAnzeige.Text = 5; funktioniert nicht!
		}

		private void btnPlusGleich_Click(object sender, EventArgs e)
		{
			var x = 5;
			x += 5; // Kurzform von: x = x + 5;
			lblAnzeige.Text = x.ToString();

			lblAnzeige.Text += "Hallo";
			lblAnzeige.Text += " Welt";

			var ergebnis = 2+2 > 2+3;
			x = 2 * (2 + 3);
		}
	}
}
