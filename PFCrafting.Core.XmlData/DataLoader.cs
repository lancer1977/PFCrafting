using System.IO;
using System.Reflection;
using PolyhydraGames.Core.Interfaces;

namespace PFCrafting.Core.XmlData
{
  public  class DataLoader : IAssemblyLoader
    {
        public string Get(string fileName)
        {
            var assembly = typeof(DataLoader).GetTypeInfo().Assembly;
            var address = "PFCrafting.Core.XmlData.XML." + fileName;
            var stream = assembly.GetManifestResourceStream(address);
            var text = "";
            using (var reader = new StreamReader(stream))
            {
                text = reader.ReadToEnd();
            }

            return text;
        }
    }
}
