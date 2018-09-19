using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.ServiceModel;

namespace VAT_Validator
{
    public partial class VAT_Validator : Form
    { 
        
        string pfad = ""; //speicher für den ersten Pfad
        string name;     //speicher für die Name der Datei
        string vpfad;   //speicher für den Pfad der Datei
        StringBuilder auslesen = new StringBuilder(); //Speicher für das aus der PDF Datei extrahiertes Text.
       
        //string firmenname, adresse; // 
        //bool valid;
        





        public VAT_Validator()
        {
            InitializeComponent();


        }
       
        private void btn_import_Click(object sender, EventArgs e)
        {
            lst_ausgabe.Items.Clear();
            
            DirectoryInfo filefolder = new DirectoryInfo(txt_eingabe.Text);//Directory eingeben und dessen pdf* files in die Textbox eingeben.
            if (filefolder.Exists)
            {
                
            FileInfo[] Files = filefolder.GetFiles("*.pdf");
            pfad = txt_eingabe.Text;

            foreach (FileInfo fn in Files) //Pfad Prüfen
            {

                lst_ausgabe.Items.Add(fn);

            }
            }
            else { MessageBox.Show("Bitte geben Sie ein gültiges Pfad ein!"); }
                 }
        private void axAcroPDF1_Enter(object sender, EventArgs e)//preview
        {
            
        }

        private void lst_ausgabe_SelectedIndexChanged(object sender, EventArgs e)//listbox
        {
            

        }

        private void lst_ausgabe_MouseDoubleClick(object sender, EventArgs e)//Eventhandler bestimmtes pdf auslesen.
        {
            name = lst_ausgabe.GetItemText(lst_ausgabe.SelectedItem);
            axAcroPDF1.LoadFile(pfad+ '/' +name);
        }

        private void VAT_Validator_Load(object sender, EventArgs e)
        {

        }

        private void btn_validate_Click(object sender, EventArgs e)
        {
            
            
            Regex vatnr = new Regex(@"\b(?!ATU68205701)\b\b[A-Z][A-Z][A-Z,0-9]\d{8}\b");//\b(?!)\b-> außer 
            // Regex land = new Regex(@"\b[A-Z][A-Z]\b");
            //  Regex nummer = new Regex(@"[A-Z,0-9]\d{8}\b");

            vpfad = pfad + '/' + name;
            PdfReader leser = new PdfReader(@vpfad);
            ITextExtractionStrategy its = new iTextSharp.text.pdf.parser.LocationTextExtractionStrategy();
            
            using (PdfReader reader = new PdfReader(vpfad))
            {


                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    string thePage = PdfTextExtractor.GetTextFromPage(reader, i, its);
                    string[] theLines = thePage.Split('\n');
                    foreach (var theLine in theLines)
                    {                        
                        auslesen.AppendLine(theLine);
                    }
                }
            }
            
            foreach (Match m in vatnr.Matches(auslesen.ToString())) 
            {
                txt_validate.Clear();
                txt_validate.Text += m.ToString() + Environment.NewLine;
            }
            


        }
    }
}

