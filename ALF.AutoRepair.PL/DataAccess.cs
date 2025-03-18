using System.Xml.Serialization;

namespace ALF.AutoRepair.PL
{
    public static class DataAccess
    {
        public static string XmlFilePath { get; set; } = "";

        public static void SaveToXML(object obj, Type  type)
        {
            if (XmlFilePath == null || XmlFilePath.Trim() == "")
            {
                throw new Exception("File path is not set");
            }

            using (StreamWriter writer = new StreamWriter(XmlFilePath))
            {
                XmlSerializer serializer = new XmlSerializer(type);
                serializer.Serialize(writer, obj);
            }
        }

        public static object? LoadFromXml(Type type)
        {
            if (XmlFilePath == null || XmlFilePath.Trim() == "")
            {
                throw new Exception("File path is not set");
            }
            using (StreamReader reader = new StreamReader(XmlFilePath))
            {
                XmlSerializer serializer = new XmlSerializer(type);
                return serializer.Deserialize(reader);
            }
        }
    }
}
