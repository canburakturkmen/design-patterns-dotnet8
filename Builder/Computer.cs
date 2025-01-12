namespace Builder;
public class Computer
{
    public string CPU { get; private set; } = string.Empty;
    public string GPU { get; private set; } = string.Empty;
    public int RAM { get; private set; }
    public int Storage { get; private set; }

    public override string ToString() =>
        $"Computer Specifications: CPU={CPU}, GPU={GPU}, RAM={RAM}GB, Storage={Storage}GB";

    // Builder Nested Class
    public class Builder
    {
        private readonly Computer _computer = new();

        public Builder SetCPU(string cpu)
        {
            _computer.CPU = cpu;
            return this;
        }

        public Builder SetGPU(string gpu)
        {
            _computer.GPU = gpu;
            return this;
        }

        public Builder SetRAM(int ram)
        {
            _computer.RAM = ram;
            return this;
        }

        public Builder SetStorage(int storage)
        {
            _computer.Storage = storage;
            return this;
        }

        public Computer Build()
        {
            return _computer;
        }
    }
}