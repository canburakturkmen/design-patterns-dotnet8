using Command;

var light = new Light();
ICommand lightOnCommand = new LightOnCommand(light);
ICommand lightOffCommand = new LightOffCommand(light);

var remoteControl = new RemoteControl();

// Turn the light on
remoteControl.PressButton(lightOnCommand);

// Turn the light off
remoteControl.PressButton(lightOffCommand);

// Undo the last action (turn the light on again)
remoteControl.PressUndoButton();

// Undo the previous action (turn the light off again)
remoteControl.PressUndoButton();