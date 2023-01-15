namespace projgrabpani
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void wyœwietlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            string[] linie = File.ReadAllLines("wlasciwosci.txt");
            foreach (string linia in linie)
            {
                string[] temp = linia.Split(';');
                if (listView1.SelectedItems.Count > 0)
                {
                    ListViewItem listviewitem = listView1.SelectedItems[0];
                    if (temp[0] == listviewitem.Text)
                    {
                        wlasciwosci wlasciwosci = new wlasciwosci(temp[0], temp[1], Convert.ToInt32(temp[2]), Convert.ToInt32(temp[3]));
                        form2.tekst = wlasciwosci.siema();
                        form2.ShowDialog();
                    }
                }
            }
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            
        }
    }



    public class wlasciwosci
    {

        

        string nazwa { get; set; }
        string opis { get; set; }

        int cena { get; set; }

        int ocena { get; set; }

        public wlasciwosci(string nazwa, string opis, int cena, int ocena)
        {
            this.nazwa = nazwa;
            this.opis = opis;
            this.cena = cena;
            this.ocena = ocena;

            
        }

        public string siema()
        {
            return nazwa + " Jest to " +  opis + " kosztuje " + cena + "z³. Nasza ocena to: " + ocena;
        }

    }
}