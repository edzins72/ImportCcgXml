namespace ImportCcgXml
{
    class DataProcessing
    {
        public static string Zinas(string xmlDati)
        {
            xmlDati = xmlDati.Replace("TV3/TITLE/SEKUNDES", "TV3/TITLE/ZINAS");
            xmlDati = xmlDati.Replace("rgba(255, 81, 0, 150)", "rgba(128, 0, 0, 192)");
            return xmlDati;
        }

        public static string Sekundes(string xmlDati)
        {
            xmlDati = xmlDati.Replace("TV3/TITLE/ZINAS", "TV3/TITLE/SEKUNDES");
            xmlDati = xmlDati.Replace("rgba(128, 0, 0, 192)", "rgba(255, 81, 0, 150)");
            return xmlDati;
        }
    }
}
