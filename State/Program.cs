using State;

var vendingMachine = new VendingMachine();

// Customer inserts money
vendingMachine.InsertMoney();

// Customer selects a product
vendingMachine.SelectProduct();

// Dispensing the product
vendingMachine.Dispense();

// Ejecting money after dispensing
vendingMachine.EjectMoney();