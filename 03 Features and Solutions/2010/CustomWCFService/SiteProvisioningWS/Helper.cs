using System.IO;
using System.Xml.Serialization;

namespace ServiceTester
{
    public class Helper
    {
        public static string ToString(object Item)
        {
            var writer = new StringWriter();
            var ser = new XmlSerializer(Item.GetType());
            ser.Serialize(writer, Item);
            string result = writer.ToString();
            return result;
        }

        public static T ToObject<T>(string Item)
        {
            var ser = new XmlSerializer(typeof(T));
            var reader = new StringReader(Item);
            return (T)ser.Deserialize(reader);
        }
    }
}