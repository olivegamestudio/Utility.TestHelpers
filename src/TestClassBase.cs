using System;
using Newtonsoft.Json;

namespace Utility;

public abstract class TestClassBase
{
    protected void EmitObjectAsJson<T>(T item) where T : class
    {
        string json = JsonConvert.SerializeObject(item, Formatting.Indented);
        Console.WriteLine(json);
    }
}
