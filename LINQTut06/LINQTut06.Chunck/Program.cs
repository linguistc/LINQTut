using LINQTut06.Shared;

var emps = Repository.LoadEmployees();

var chunks = emps.Chunk(10).ToList();

for (int i = 0; i < chunks.Count; ++i)
    chunks[i].Print($"Chunk #{i + 1}");