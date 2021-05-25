using System;
using System.IO;
using System.Threading.Tasks;

namespace ImportCcgXml
{
    internal class WriteToFile
    {
        public static void WriteCasparXmlFile(string text)
        {
            var pathWithEnv = "%USERPROFILE%";
            var filePath = Environment.ExpandEnvironmentVariables(pathWithEnv);
            File.WriteAllText($@"{filePath}\titru_fails.xml", text);
        }
    }
}