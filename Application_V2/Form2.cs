using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_V2
{
    public partial class Form2 : Form
    {
        public Form2(String location)
        {
            InitializeComponent();
            image.ImageLocation = location;
        }

        public List<List<string>> medList = new List<List<string>>();
        //public string[,] medList = new string[640, 9];
        //public string[] medList = new string[640];
        public List<List<string>> medsubList = new List<List<string>>();
        public List<List<string>> medsubList1 = new List<List<string>>();
        public List<List<string>> medsubList2 = new List<List<string>>();
        public List<string> medrow = new List<string>();
        public List<string> medrow1 = new List<string>();
        public List<string> medrow2 = new List<string>();
        //ListViewItem item = new ListViewItem(subitems);
        //listView2.Items.Add(item);
        //listView2.Items.Add(sStr);

        public string name = "";
        public Class1 c = new Class1();

        private void Form2_Load(object sender, EventArgs e)
        {
            using (Microsoft.VisualBasic.FileIO.TextFieldParser parser = new Microsoft.VisualBasic.FileIO.TextFieldParser(@"C:\Users\Thilini\source\repos\Application_V2\Application_V2\MedicinesDb.csv"))
            {

                int i = 0;
                //int k = 0;
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                //List<string> row1 = parser.ReadFields().ToList();
                //medList.Add(row1);
                //listView2.Items.Add(row1[0]);

                while (!parser.EndOfData)
                {
                    List<string> row = parser.ReadFields().ToList();
                    //string name = row[0];
                    //medList[i][m] = row[m];
                    medList.Add(row);

                    ListViewItem lv = new ListViewItem(medList[i][0], 0);
                    lv.SubItems.Add(medList[i][3]);
                    listView2.Items.Add(lv);
                    i += 1;
                    //listView2.Items.Add("New Row");
                }
                medList.RemoveAt(0);
            }

        }




        private void Sstring_TextChanged(object sender, EventArgs e)
        {

        }

        private void Estring_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Dose_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //ListViewItem l1 = new ListViewItem("DDDDDDDDDDD");
            listView2.Items.Add("Button Clicked");
        }

        private void Sstring_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                listView2.Items.Clear();
                //listView2.Items.Add("Enter pressed after first field");
                String sStr = Sstring.Text;
                int slen = sStr.Length;
                listView2.Items.Add(sStr);
                int vr = 0;

                foreach (var row in medList)
                {

                    name = row[0];
                    string sletters = name.Substring(0, slen);
                    //listView2.Items.Add(sletters);
                    // foreach (var colval in row)

                    //Compare medicine name's first letters. 
                    if (sStr.ToUpper() == sletters.ToUpper())
                    {
                        medsubList.Add(row);
                        if (row[1].ToUpper() == "NILL")
                        {
                            row[1] = "";
                        }
                        if (row[2].ToUpper() == "SAME")
                        {
                            row[2] = row[0];
                        }
                        string fullname = row[0] + " " + row[1] + " (" + row[2] + ")";
                        medrow.Add(fullname);
                        string rowname = row[0] + " " + row[1];
                        string instructions = row[4] + " " + row[7];
                        ListViewItem lv1 = new ListViewItem(rowname);
                        lv1.SubItems.Add(row[2]);
                        lv1.SubItems.Add(row[3]);
                        lv1.SubItems.Add(row[5]);
                        lv1.SubItems.Add(row[6]);
                        lv1.SubItems.Add(row[8]);
                        lv1.SubItems.Add(instructions);
                        listView1.Items.Add(lv1);
                    }
                    vr += 1;
                    
                    medrow = c.Noduplicates(medrow);
                    
                }

                c.Displaynames(medrow, listView2);

                Estring.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void Estring_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                listView2.Items.Clear();
                listView1.Items.Clear();
                String eStr = Estring.Text;
                int elen = eStr.Length;
                //int vr = 0;

                foreach (var line in medsubList)
                {
                    string label = line[0];
                    string eletters = label.Substring((label.Length - elen), elen); //elen = 3
                    //listView2.Items.Add(eletters);
                    //Compare medicine name's end letters. 
                    
                    if (eStr.ToUpper() == eletters.ToUpper()) //eletters.Contain(eStr)
                    {
                        //listView2.Items.Add(line[0]);
                        medsubList1.Add(line);
                        if (line[1].ToUpper() == "NILL")
                        {
                            line[1] = "";
                        }
                        if (line[2].ToUpper() == "SAME")
                        {
                            line[2] = line[0];
                        }
                        string fullname = line[0] + " " + line[1] + " (" + line[2] + ")";
                        medrow1.Add(fullname);
                        string rowname = line[0] + " " + line[1];
                        string instructions = line[4] + " " + line[7];
                        ListViewItem lv1 = new ListViewItem(rowname);
                        lv1.SubItems.Add(line[2]);
                        lv1.SubItems.Add(line[3]);
                        lv1.SubItems.Add(line[5]);
                        lv1.SubItems.Add(line[6]);
                        lv1.SubItems.Add(line[8]);
                        lv1.SubItems.Add(instructions);
                        listView1.Items.Add(lv1);
                        
                    }
                    
                    //vr += 1;
                }
                
                //listView2.Items.Add("Before remove duplicates");
                //c.Displaynames(medrow1, listView2);
                medrow1 = c.Noduplicates(medrow1);

                //listView2.Items.Add("After remove duplicates");
                c.Displaynames(medrow1, listView2);

                Dose.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void Dose_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                listView2.Items.Clear();
                String dStr = Dose.Text;
                int vr = 0;

                foreach (var line in medsubList)
                {
                    string dosage = line[3];
                    
                    //listView2.Items.Add(eletters);
                    //Compare medicine name's first letters. 

                    if (dStr == dosage)
                    {
                        medsubList2.Add(line);
                        if (line[1].ToUpper() == "NILL")
                        {
                            line[1] = "";
                        }
                        if (line[2].ToUpper() == "SAME")
                        {
                            line[2] = line[0];
                        }
                        string fullname = line[0] + " " + line[1] + " (" + line[2] + ")";
                        medrow2.Add(fullname);
                        listView1.Items.Clear();
                        string rowname = line[0] + " " + line[1];
                        string instructions = line[4] + " " + line[7];
                        ListViewItem lv1 = new ListViewItem(rowname);
                        lv1.SubItems.Add(line[2]);
                        lv1.SubItems.Add(line[3]);
                        lv1.SubItems.Add(line[5]);
                        lv1.SubItems.Add(line[6]);
                        lv1.SubItems.Add(line[8]);
                        lv1.SubItems.Add(instructions);
                        listView1.Items.Add(lv1);
                    }

                    vr += 1;
                    medrow2 = c.Noduplicates(medrow2);
                }
                c.Displaynames(medrow2, listView2);


                Age.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void Age_KeyDown(object sender, KeyEventArgs e)
        {
            Age.Focus();
            e.SuppressKeyPress = true;
        }

        
    }
}
