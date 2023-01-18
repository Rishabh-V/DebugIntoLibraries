using Google.Cloud.Language.V1;
using Document = Google.Cloud.Language.V1.Document;

namespace DebugIntoLibraries;

internal class Program
{
    private static void Main(string[] args)
    {
        AnalyzeEntities();
        Console.ReadLine();
    }

    private static void AnalyzeEntities()
    {
        var client = LanguageServiceClient.Create();
        Document document = Document.FromPlainText("Open Telemetry is required for all modern applications for effective observability.");
        AnalyzeEntitiesResponse response = client.AnalyzeEntities(document);
        Console.WriteLine($"Detected language: {response.Language}");
        Console.WriteLine("Detected entities:");
        foreach (Entity entity in response.Entities)
        {
            Console.WriteLine($"  {entity.Name} ({(int)(entity.Salience * 100)}%)");
        }
    }
}