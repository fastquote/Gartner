using SassImportProject.Contracts;

using YamlDotNet.RepresentationModel;

namespace SassImportProject.BusinessLayer
{
    public class ReadYamlFile:IReadYamlFile
    {
        public async Task<bool> readYamlFiles(string filename)
        {
            await Task.Run(() =>
            {
                try
                {
                    using (StreamReader reader = new StreamReader(filename))
                    {
                        var yaml = new YamlStream();
                        yaml.Load(reader);
                        var mapping = (YamlMappingNode)yaml.Documents[0].RootNode;
                        foreach (var entry in mapping.Children)
                        {
                            Console.WriteLine(((YamlScalarNode)entry.Key).Value);
                        }

                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine("error occured while reading ...");
                    return false;
                }
                return true;
            }).ConfigureAwait(true);
            return true;

        }

    }
}

