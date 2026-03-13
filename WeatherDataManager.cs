using System;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Xml.Serialization;

public class WeatherDataManager
{
    public void SerializeWeatherData<T>(T data, string filePath)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(T));
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            serializer.Serialize(writer, data);
        }
    }

    public void ExportWeatherDataAsZip<T>(T data, string zipFilePath, string xmlFileName)
    {
        string tempXmlPath = Path.GetTempFileName();
        SerializeWeatherData(data, tempXmlPath);

        using (ZipArchive archive = ZipFile.Open(zipFilePath, ZipArchiveMode.Create))
        {
            archive.CreateEntryFromFile(tempXmlPath, xmlFileName);
        }

        File.Delete(tempXmlPath);
    }
}