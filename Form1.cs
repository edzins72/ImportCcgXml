using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImportCcgXml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void buttonSekundes_Click(object sender, EventArgs e)
        {
            toolStripLabel.Text = "Ielādēju 900''";
            var response = await RequestData.GetProductAsync(Raidijums.Sekundes);
            var dati = DataProcessing.Sekundes(response.XML);
            WriteToFile.WriteCasparXmlFile(dati);
            toolStripLabel.Text = "900'' xml saglabāts";
        }

        private async void buttonZinas1800_Click(object sender, EventArgs e)
        {
            toolStripLabel.Text = "Ielādēju Ziņas 18:00";
            var response = await RequestData.GetProductAsync(Raidijums.Zinas1800);
            var dati = DataProcessing.Zinas(response.XML);
            WriteToFile.WriteCasparXmlFile(dati);
            toolStripLabel.Text = "Ziņas 18:00 xml saglabāts";
        }

        private async void buttonZinas2000_Click(object sender, EventArgs e)
        {
            toolStripLabel.Text = "Ielādēju Ziņas 20:00";
            var response = await RequestData.GetProductAsync(Raidijums.Zinas2000);
            var dati = DataProcessing.Zinas(response.XML);
            WriteToFile.WriteCasparXmlFile(dati);
            toolStripLabel.Text = "Ziņas 20:00 xml saglabāts";
        }

        private async void buttonSports_Click(object sender, EventArgs e)
        {
            toolStripLabel.Text = "Ielādēju Sporta ziņas";
            var response = await RequestData.GetProductAsync(Raidijums.Sports);
            WriteToFile.WriteCasparXmlFile(response.XML);
            toolStripLabel.Text = "Sporta ziņas xml saglabāts";
        }

        private async void buttonDegpunkta_Click(object sender, EventArgs e)
        {
            toolStripLabel.Text = "Ielādēju Degpunktā";
            var response = await RequestData.GetProductAsync(Raidijums.Degpunkta);
            WriteToFile.WriteCasparXmlFile(response.XML);
            toolStripLabel.Text = "Degpunktā xml saglabāts";
        }

        private async void buttonVelesanas_Click(object sender, EventArgs e)
        {
            toolStripLabel.Text = "Ielādēju 900'' Vēlēšanām";
            var response = await RequestData.GetProductAsync(Raidijums.Sekundes);
            var dati = DataProcessing.Zinas(response.XML);
            WriteToFile.WriteCasparXmlFile(dati);
            toolStripLabel.Text = "900'' Vēlēšanām xml saglabāts";
        }

        private async void buttonVelesanas2200_Click(object sender, EventArgs e)
        {
            toolStripLabel.Text = "Ielādēju Speciālizlaidumu 22:00";
            var response = await RequestData.GetProductAsync(Raidijums.Specializlaidums2200);
            var dati = DataProcessing.Zinas(response.XML);
            WriteToFile.WriteCasparXmlFile(dati);
            toolStripLabel.Text = "Speciālizlaidums 22:00 xml saglabāts";
        }
    }
}
