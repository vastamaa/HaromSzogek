using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Haromszogek
{
    public partial class Form1 : Form
    {
        List<DHaromszog> haromszoglista;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            int i = 0;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (haromszoglista == null)
            {
                haromszoglista = new List<DHaromszog>();
            }

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(ofd.FileName))
                {
                    while (!sr.EndOfStream)
                    {
                        i++;
                        try
                        {
                            haromszoglista.Add(new DHaromszog(sr.ReadLine(), i));
                        }
                        catch (Exception error)
                        {
                            gbErrors.Text += $"\n{i}.sor: {error.Message}";
                        }
                        
                    }
                }
            }

            foreach (DHaromszog item in haromszoglista) lbTriangles.Items.Add($"\n{item.SorSzama}.sor: A={item.A} B={item.B} C={item.C}");
        }

        private void lbTriangles_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbDatas.Items.Clear();
            lbDatas.Items.Add($"Kerület={haromszoglista[lbTriangles.SelectedIndex].Kerulet}");
            lbDatas.Items.Add($"Terület={ haromszoglista[lbTriangles.SelectedIndex].Terulet}");
        }
    }
}
