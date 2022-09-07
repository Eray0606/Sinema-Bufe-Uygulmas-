namespace Sinema_büfe_uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        int kasatutar;
        private void button2_Click(object sender, EventArgs e)
        {
            int mısır, bilet, su, cay, toplam;

            mısır = Convert.ToInt32(textmısır.Text);
            su=Convert.ToInt32(textsu.Text);
            cay=Convert.ToInt32(textcay.Text);  
            bilet=Convert.ToInt32(textbilet.Text);


            toplam = (mısır * 4 + su * 1 + cay * 2 + bilet * 8);

            label14.Text = toplam.ToString();
            kasatutar = kasatutar + toplam;

            label15.Text = kasatutar.ToString();


            listBox1.Items.Add("Toplam tutar" + toplam);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textmısır.Text = "";
            textsu.Text = "";
            textcay.Text = "";
            textbilet.Text = "";
            
            label15.Text = "";
            textmısır.Focus();
        }
    }
}