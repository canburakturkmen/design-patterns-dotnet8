using Builder;

var gamingComputer = new Computer.Builder()
    .SetCPU("Intel Core i9")
    .SetGPU("NVIDIA RTX 4090")
    .SetRAM(32)
    .SetStorage(2000)
    .Build();

var officeComputer = new Computer.Builder()
    .SetCPU("Intel Core i5")
    .SetRAM(16)
    .SetStorage(500)
    .Build();

Console.WriteLine(gamingComputer);
Console.WriteLine(officeComputer);