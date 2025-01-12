namespace Command;

// Command Interface
public interface ICommand
{
    void Execute();
    void Undo();
}

// Receiver: Light
public class Light
{
    public void TurnOn()
    {
        Console.WriteLine("Light is On");
    }

    public void TurnOff()
    {
        Console.WriteLine("Light is Off");
    }
}

// Concrete Command: Turn On Light
public class LightOnCommand : ICommand
{
    private readonly Light _light;

    public LightOnCommand(Light light)
    {
        _light = light;
    }

    public void Execute()
    {
        _light.TurnOn();
    }

    public void Undo()
    {
        _light.TurnOff();
    }
}

// Concrete Command: Turn Off Light
public class LightOffCommand : ICommand
{
    private readonly Light _light;

    public LightOffCommand(Light light)
    {
        _light = light;
    }

    public void Execute()
    {
        _light.TurnOff();
    }

    public void Undo()
    {
        _light.TurnOn();
    }
}

// Invoker: Remote Control
public class RemoteControl
{
    private readonly Stack<ICommand> _commandHistory = new();

    public void PressButton(ICommand command)
    {
        command.Execute();
        _commandHistory.Push(command);
    }

    public void PressUndoButton()
    {
        if (_commandHistory.Count > 0)
        {
            var lastCommand = _commandHistory.Pop();
            lastCommand.Undo();
        }
        else
        {
            Console.WriteLine("No command to undo");
        }
    }
}
