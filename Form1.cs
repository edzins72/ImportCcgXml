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
            toolStripLabel.Text = "Ielādēju datus";
            var response = await RequestData.GetProductAsync(Raidijums.Sekundes);
            var dati = DataProcessing.Sekundes(response.XML);
            WriteToFile.WriteCasparXmlFile(dati);
            toolStripLabel.Text = "XML saglabāts";
        }

        private async void buttonZinas1800_Click(object sender, EventArgs e)
        {
            toolStripLabel.Text = "Ielādēju datus";
            var response = await RequestData.GetProductAsync(Raidijums.Zinas1800);
            var dati = DataProcessing.Zinas(response.XML);
            WriteToFile.WriteCasparXmlFile(dati);
            toolStripLabel.Text = "XML saglabāts";
        }

        private async void buttonZinas2000_Click(object sender, EventArgs e)
        {
            toolStripLabel.Text = "Ielādēju datus";
            var response = await RequestData.GetProductAsync(Raidijums.Zinas2000);
            var dati = DataProcessing.Zinas(response.XML);
            WriteToFile.WriteCasparXmlFile(dati);
            toolStripLabel.Text = "XML saglabāts";
        }

        private async void buttonSports_Click(object sender, EventArgs e)
        {
            toolStripLabel.Text = "Ielādēju datus";
            var response = await RequestData.GetProductAsync(Raidijums.Sports);
            WriteToFile.WriteCasparXmlFile(response.XML);
            toolStripLabel.Text = "XML saglabāts";
        }

        private async void buttonDegpunkta_Click(object sender, EventArgs e)
        {
            toolStripLabel.Text = "Ielādēju datus";
            var response = await RequestData.GetProductAsync(Raidijums.Degpunkta);
            WriteToFile.WriteCasparXmlFile(response.XML);
            toolStripLabel.Text = "XML saglabāts";
        }

        private async void buttonVelesanas_Click(object sender, EventArgs e)
        {
            toolStripLabel.Text = "Ielādēju datus";
            var response = await RequestData.GetProductAsync(Raidijums.NovostiPlus);
            var dati = DataProcessing.Zinas(response.XML);
            WriteToFile.WriteCasparXmlFile(dati);
            toolStripLabel.Text = "XML saglabāts";
        }

        private async void buttonVelesanas2200_Click(object sender, EventArgs e)
        {
            toolStripLabel.Text = "Ielādēju datus";
            var response = await RequestData.GetProductAsync(Raidijums.Specializlaidums2200);
            var dati = DataProcessing.Zinas(response.XML);
            WriteToFile.WriteCasparXmlFile(dati);
            toolStripLabel.Text = "XML saglabāts";
        }
    }
}
