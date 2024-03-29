namespace EasyPolicheck.Data;

using System.Text.Json;

public class JobsService
{
    string jobsFile = string.Empty;

    public JobsService()
    {
        //jobsFile = Path.Combine(@"./wwwroot/data", "policheckJobs.json"); 
        jobsFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "policheckJobs.json");
    }

    public void SaveJobs(IEnumerable<JobInfo> jobs)
    {
        File.WriteAllText(jobsFile, JsonSerializer.Serialize(jobs));
    }

    public IEnumerable<JobInfo> LoadJobs()
    {
        if (!File.Exists(jobsFile))
            return Enumerable.Empty<JobInfo>();

        var itemJson = File.ReadAllText(jobsFile);
        return JsonSerializer.Deserialize<IEnumerable<JobInfo>>(itemJson) ?? Enumerable.Empty<JobInfo>();
    }

}