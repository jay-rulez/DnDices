using System.Media;

namespace DnDices
{
    public partial class DnDices : Form
    {
        public DnDices()
        {
            InitializeComponent();
            cmbDices.SelectedIndex = 0;
            cmbDices.DropDownStyle = ComboBoxStyle.DropDownList;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rand = new Random();

            int dice = Convert.ToInt32(cmbDices.SelectedItem);
            int dicenumbers = (int)numericNumberDices.Value;
            listBoxResult.Items.Clear();


            for (int ctr = 1; ctr <= dicenumbers; ctr++) {

                SoundPlayer simpleSound = new SoundPlayer("RATTLE1.wav");
                simpleSound.Play();
                Thread.Sleep(1000);

                var result = rand.Next(1, dice + 1);
                listBoxResult.Items.Add(Convert.ToString(result));


            }
            
        }
            
        }
}