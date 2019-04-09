using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace egyszamjatekGUI0409
{
    public partial class FmEgyszamjatekGUI : Form
    {
        public FmEgyszamjatekGUI()
        {
            InitializeComponent();
        }

        private void tbTippek_TextChanged(object sender, EventArgs e)
        {
            lblDb.Text = $"{tbTippek.Text.TrimEnd(' ').Split(' ').Length} db";
        }

        private void btnHozaad_Click(object sender, EventArgs e)
        {
            if (NevStimmel() && DarabszamStimmel()) Hozaad();
        }

        private void Hozaad()
        {
            var sw = new StreamWriter("egyszamjatek.txt", true, Encoding.UTF8);

            sw.WriteLine($"{tbNev.Text} {tbTippek.Text.TrimEnd(' ')}");
            MessageBox.Show("Sikeresen hozzáadva az állományhoz!");
            sw.Close();


        }

        private bool DarabszamStimmel()
        {
            var sr = new StreamReader("egyszamjatek.txt", Encoding.UTF8);

            if (int.Parse(lblDb.Text.Split(' ')[0]) == sr.ReadLine().Split(' ').Length - 1)
            {
                sr.Close();
                return true;
            }
            else
            {
                sr.Close();
               
                MessageBox.Show("A tippek száma nem megfelelő!");
                return false;
            }
        }

        private bool NevStimmel()
        {
            var sr = new StreamReader("egyszamjatek.txt", Encoding.UTF8);

            while (!sr.EndOfStream)
            {
                if (tbNev.Text == sr.ReadLine().Split(' ')[0])
                {
                    sr.Close();
                    MessageBox.Show("van már ilyen játékos!");
                    return false;

                }
            }
            sr.Close();
            return true;
            
        }
    }
}
