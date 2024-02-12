namespace EasyPolicheck.Data;

using System.Text.Json;
using System.Text.Json.Nodes;

public class JobsService
{
    string jobsFile = string.Empty;
    public JsonArray jsonArray = new JsonArray();

    public JobsService()
    {
        jobsFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "jobs.json");
    }

    public void SaveJobs(JsonArray jobs)
    {
        File.WriteAllText(jobsFile, JsonSerializer.Serialize(jobs));
    }

    public JsonArray LoadJobs()
    {
        if (!File.Exists(jobsFile))
            return new JsonArray();

        var itemJson = File.ReadAllText(jobsFile);

        try
        {
            var deserializedJobs = JsonSerializer.Deserialize<JsonArray>(itemJson);
            return deserializedJobs;
        }
        catch
        {
            return new JsonArray();
        }


    }

}