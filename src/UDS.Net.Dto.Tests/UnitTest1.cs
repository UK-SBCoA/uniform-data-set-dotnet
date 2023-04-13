using System.Text.Json;

namespace UDS.Net.Dto.Tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        var list = new List<FormDto> {
            new A1Dto { Id = 1, VisitId = 1, Kind = "A1", Status = "Pending" }
        };

        var json = JsonSerializer.Serialize(list);

        Console.WriteLine(json);

        Assert.IsTrue(json.Contains("A1Dto"));

        var listDeserialized = JsonSerializer.Deserialize<List<FormDto>>(json);

        Assert.AreEqual(listDeserialized[0].GetType(), list[0].GetType());


    }

    [TestMethod]
    public void TestVisit()
    {
        var visit = new VisitDto
        {
            Id = 1,
            Kind = "IVP",
            Version = "UDS3",
            ParticipationId = 1,
            Number = 1,
            Forms = new List<FormDto> {
                new A1Dto { Id = 1, VisitId = 1, Kind = "A1", Status = "Pending" },
                new A2Dto { Id = 1, VisitId = 1, Kind = "A2", Status = "Pending"}
            }
        };

        var json = JsonSerializer.Serialize(visit);

        Console.WriteLine(json);

        Assert.IsTrue(json.Contains("A1Dto"));

        var visitDeserialized = JsonSerializer.Deserialize<VisitDto>(json);

        Assert.AreEqual(visit.Forms.Count(), visitDeserialized.Forms.Count());

        Assert.AreEqual(visit.Forms.First().GetType(), visitDeserialized.Forms.First().GetType());

    }
}
