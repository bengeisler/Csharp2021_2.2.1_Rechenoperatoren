
namespace Rechenoperatoren
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblAnzeige = new System.Windows.Forms.Label();
			this.btnModulo = new System.Windows.Forms.Button();
			this.btnTageInWochen = new System.Windows.Forms.Button();
			this.btnInkrement = new System.Windows.Forms.Button();
			this.btnGrößer = new System.Windows.Forms.Button();
			this.btnKleiner = new System.Windows.Forms.Button();
			this.btnGleich = new System.Windows.Forms.Button();
			this.btnUngleich = new System.Windows.Forms.Button();
			this.btnUnd = new System.Windows.Forms.Button();
			this.btnOder = new System.Windows.Forms.Button();
			this.btnXor = new System.Windows.Forms.Button();
			this.btnAusdruck1 = new System.Windows.Forms.Button();
			this.btnAusdruck2 = new System.Windows.Forms.Button();
			this.btnVerknüpfung = new System.Windows.Forms.Button();
			this.btnPlusGleich = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblAnzeige
			// 
			this.lblAnzeige.AutoSize = true;
			this.lblAnzeige.Location = new System.Drawing.Point(24, 18);
			this.lblAnzeige.Name = "lblAnzeige";
			this.lblAnzeige.Size = new System.Drawing.Size(35, 13);
			this.lblAnzeige.TabIndex = 0;
			this.lblAnzeige.Text = "label1";
			// 
			// btnModulo
			// 
			this.btnModulo.Location = new System.Drawing.Point(229, 67);
			this.btnModulo.Name = "btnModulo";
			this.btnModulo.Size = new System.Drawing.Size(75, 23);
			this.btnModulo.TabIndex = 1;
			this.btnModulo.Text = "Modulo";
			this.btnModulo.UseVisualStyleBackColor = true;
			this.btnModulo.Click += new System.EventHandler(this.btnModulo_Click);
			// 
			// btnTageInWochen
			// 
			this.btnTageInWochen.Location = new System.Drawing.Point(229, 96);
			this.btnTageInWochen.Name = "btnTageInWochen";
			this.btnTageInWochen.Size = new System.Drawing.Size(137, 40);
			this.btnTageInWochen.TabIndex = 2;
			this.btnTageInWochen.Text = "Tage in Wochen umrechnen";
			this.btnTageInWochen.UseVisualStyleBackColor = true;
			this.btnTageInWochen.Click += new System.EventHandler(this.btnTageInWochen_Click);
			// 
			// btnInkrement
			// 
			this.btnInkrement.Location = new System.Drawing.Point(229, 154);
			this.btnInkrement.Name = "btnInkrement";
			this.btnInkrement.Size = new System.Drawing.Size(75, 23);
			this.btnInkrement.TabIndex = 3;
			this.btnInkrement.Text = "++";
			this.btnInkrement.UseVisualStyleBackColor = true;
			this.btnInkrement.Click += new System.EventHandler(this.btnInkrement_Click);
			// 
			// btnGrößer
			// 
			this.btnGrößer.Location = new System.Drawing.Point(229, 184);
			this.btnGrößer.Name = "btnGrößer";
			this.btnGrößer.Size = new System.Drawing.Size(75, 23);
			this.btnGrößer.TabIndex = 4;
			this.btnGrößer.Text = ">";
			this.btnGrößer.UseVisualStyleBackColor = true;
			this.btnGrößer.Click += new System.EventHandler(this.btnGrößer_Click);
			// 
			// btnKleiner
			// 
			this.btnKleiner.Location = new System.Drawing.Point(229, 214);
			this.btnKleiner.Name = "btnKleiner";
			this.btnKleiner.Size = new System.Drawing.Size(75, 23);
			this.btnKleiner.TabIndex = 5;
			this.btnKleiner.Text = "<";
			this.btnKleiner.UseVisualStyleBackColor = true;
			this.btnKleiner.Click += new System.EventHandler(this.btnKleiner_Click);
			// 
			// btnGleich
			// 
			this.btnGleich.Location = new System.Drawing.Point(311, 184);
			this.btnGleich.Name = "btnGleich";
			this.btnGleich.Size = new System.Drawing.Size(75, 23);
			this.btnGleich.TabIndex = 6;
			this.btnGleich.Text = "==";
			this.btnGleich.UseVisualStyleBackColor = true;
			this.btnGleich.Click += new System.EventHandler(this.btnGleich_Click);
			// 
			// btnUngleich
			// 
			this.btnUngleich.Location = new System.Drawing.Point(311, 214);
			this.btnUngleich.Name = "btnUngleich";
			this.btnUngleich.Size = new System.Drawing.Size(75, 23);
			this.btnUngleich.TabIndex = 7;
			this.btnUngleich.Text = "!=";
			this.btnUngleich.UseVisualStyleBackColor = true;
			this.btnUngleich.Click += new System.EventHandler(this.btnUngleich_Click);
			// 
			// btnUnd
			// 
			this.btnUnd.Location = new System.Drawing.Point(229, 254);
			this.btnUnd.Name = "btnUnd";
			this.btnUnd.Size = new System.Drawing.Size(75, 29);
			this.btnUnd.TabIndex = 8;
			this.btnUnd.Text = "UND";
			this.btnUnd.UseVisualStyleBackColor = true;
			this.btnUnd.Click += new System.EventHandler(this.btnUnd_Click);
			// 
			// btnOder
			// 
			this.btnOder.Location = new System.Drawing.Point(311, 254);
			this.btnOder.Name = "btnOder";
			this.btnOder.Size = new System.Drawing.Size(75, 29);
			this.btnOder.TabIndex = 9;
			this.btnOder.Text = "ODER";
			this.btnOder.UseVisualStyleBackColor = true;
			this.btnOder.Click += new System.EventHandler(this.btnOder_Click);
			// 
			// btnXor
			// 
			this.btnXor.Location = new System.Drawing.Point(311, 290);
			this.btnXor.Name = "btnXor";
			this.btnXor.Size = new System.Drawing.Size(75, 36);
			this.btnXor.TabIndex = 10;
			this.btnXor.Text = "Exklusives Oder";
			this.btnXor.UseVisualStyleBackColor = true;
			this.btnXor.Click += new System.EventHandler(this.btnXor_Click);
			// 
			// btnAusdruck1
			// 
			this.btnAusdruck1.Location = new System.Drawing.Point(229, 365);
			this.btnAusdruck1.Name = "btnAusdruck1";
			this.btnAusdruck1.Size = new System.Drawing.Size(75, 23);
			this.btnAusdruck1.TabIndex = 11;
			this.btnAusdruck1.Text = "1. Ausdruck";
			this.btnAusdruck1.UseVisualStyleBackColor = true;
			this.btnAusdruck1.Click += new System.EventHandler(this.btnAusdruck1_Click);
			// 
			// btnAusdruck2
			// 
			this.btnAusdruck2.Location = new System.Drawing.Point(229, 395);
			this.btnAusdruck2.Name = "btnAusdruck2";
			this.btnAusdruck2.Size = new System.Drawing.Size(75, 23);
			this.btnAusdruck2.TabIndex = 12;
			this.btnAusdruck2.Text = "2. Ausdruck";
			this.btnAusdruck2.UseVisualStyleBackColor = true;
			this.btnAusdruck2.Click += new System.EventHandler(this.btnAusdruck2_Click);
			// 
			// btnVerknüpfung
			// 
			this.btnVerknüpfung.Location = new System.Drawing.Point(444, 96);
			this.btnVerknüpfung.Name = "btnVerknüpfung";
			this.btnVerknüpfung.Size = new System.Drawing.Size(75, 23);
			this.btnVerknüpfung.TabIndex = 13;
			this.btnVerknüpfung.Text = "+";
			this.btnVerknüpfung.UseVisualStyleBackColor = true;
			this.btnVerknüpfung.Click += new System.EventHandler(this.btnVerknüpfung_Click);
			// 
			// btnPlusGleich
			// 
			this.btnPlusGleich.Location = new System.Drawing.Point(444, 126);
			this.btnPlusGleich.Name = "btnPlusGleich";
			this.btnPlusGleich.Size = new System.Drawing.Size(75, 23);
			this.btnPlusGleich.TabIndex = 14;
			this.btnPlusGleich.Text = "+=";
			this.btnPlusGleich.UseVisualStyleBackColor = true;
			this.btnPlusGleich.Click += new System.EventHandler(this.btnPlusGleich_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnPlusGleich);
			this.Controls.Add(this.btnVerknüpfung);
			this.Controls.Add(this.btnAusdruck2);
			this.Controls.Add(this.btnAusdruck1);
			this.Controls.Add(this.btnXor);
			this.Controls.Add(this.btnOder);
			this.Controls.Add(this.btnUnd);
			this.Controls.Add(this.btnUngleich);
			this.Controls.Add(this.btnGleich);
			this.Controls.Add(this.btnKleiner);
			this.Controls.Add(this.btnGrößer);
			this.Controls.Add(this.btnInkrement);
			this.Controls.Add(this.btnTageInWochen);
			this.Controls.Add(this.btnModulo);
			this.Controls.Add(this.lblAnzeige);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblAnzeige;
		private System.Windows.Forms.Button btnModulo;
		private System.Windows.Forms.Button btnTageInWochen;
		private System.Windows.Forms.Button btnInkrement;
		private System.Windows.Forms.Button btnGrößer;
		private System.Windows.Forms.Button btnKleiner;
		private System.Windows.Forms.Button btnGleich;
		private System.Windows.Forms.Button btnUngleich;
		private System.Windows.Forms.Button btnUnd;
		private System.Windows.Forms.Button btnOder;
		private System.Windows.Forms.Button btnXor;
		private System.Windows.Forms.Button btnAusdruck1;
		private System.Windows.Forms.Button btnAusdruck2;
		private System.Windows.Forms.Button btnVerknüpfung;
		private System.Windows.Forms.Button btnPlusGleich;
	}
}

