namespace State;

// State Interface
public interface IVendingMachineState
{
    void InsertMoney();
    void EjectMoney();
    void SelectProduct();
    void Dispense();
}

// Concrete State: Waiting for money
public class WaitingForMoneyState : IVendingMachineState
{
    private readonly VendingMachine _vendingMachine;

    public WaitingForMoneyState(VendingMachine vendingMachine)
    {
        _vendingMachine = vendingMachine;
    }

    public void InsertMoney()
    {
        Console.WriteLine("Money inserted. You can now select a product.");
        _vendingMachine.SetState(_vendingMachine.GetReadyState());
    }

    public void EjectMoney()
    {
        Console.WriteLine("No money inserted to eject.");
    }

    public void SelectProduct()
    {
        Console.WriteLine("Please insert money first.");
    }

    public void Dispense()
    {
        Console.WriteLine("Please insert money first.");
    }
}

// Concrete State: Ready to dispense product
public class ReadyState : IVendingMachineState
{
    private readonly VendingMachine _vendingMachine;

    public ReadyState(VendingMachine vendingMachine)
    {
        _vendingMachine = vendingMachine;
    }

    public void InsertMoney()
    {
        Console.WriteLine("Money already inserted. Please select a product.");
    }

    public void EjectMoney()
    {
        Console.WriteLine("Money ejected.");
        _vendingMachine.SetState(_vendingMachine.GetWaitingForMoneyState());
    }

    public void SelectProduct()
    {
        Console.WriteLine("Product selected.");
        _vendingMachine.SetState(_vendingMachine.GetDispenseState());
    }

    public void Dispense()
    {
        Console.WriteLine("Please select a product first.");
    }
}

// Concrete State: Dispensing product
public class DispenseState : IVendingMachineState
{
    private readonly VendingMachine _vendingMachine;

    public DispenseState(VendingMachine vendingMachine)
    {
        _vendingMachine = vendingMachine;
    }

    public void InsertMoney()
    {
        Console.WriteLine("Please wait, dispensing product.");
    }

    public void EjectMoney()
    {
        Console.WriteLine("Money cannot be ejected while dispensing product.");
    }

    public void SelectProduct()
    {
        Console.WriteLine("Product already selected. Dispensing now.");
    }

    public void Dispense()
    {
        Console.WriteLine("Dispensing product.");
        _vendingMachine.SetState(_vendingMachine.GetWaitingForMoneyState());
    }
}

// Context: Vending Machine
public class VendingMachine
{
    private IVendingMachineState _currentState;

    private readonly IVendingMachineState _waitingForMoneyState;
    private readonly IVendingMachineState _readyState;
    private readonly IVendingMachineState _dispenseState;

    public VendingMachine()
    {
        _waitingForMoneyState = new WaitingForMoneyState(this);
        _readyState = new ReadyState(this);
        _dispenseState = new DispenseState(this);

        _currentState = _waitingForMoneyState;
    }

    public void SetState(IVendingMachineState newState)
    {
        _currentState = newState;
    }

    public IVendingMachineState GetWaitingForMoneyState() => _waitingForMoneyState;
    public IVendingMachineState GetReadyState() => _readyState;
    public IVendingMachineState GetDispenseState() => _dispenseState;

    // Delegate all requests to the current state
    public void InsertMoney() => _currentState.InsertMoney();
    public void EjectMoney() => _currentState.EjectMoney();
    public void SelectProduct() => _currentState.SelectProduct();
    public void Dispense() => _currentState.Dispense();
}