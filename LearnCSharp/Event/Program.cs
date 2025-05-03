using Event;

Switch switch1 = new Switch();

Fan fan = new Fan();
Bulb bulb = new Bulb();

switch1.OnPress += fan.Rotate;
switch1.OnPress += bulb.Light;

while (true)
{
    string line = Console.ReadLine();

    if (line == "e")
        break;

    switch1.Press();
}

switch1.OnPress -= bulb.Light;
switch1.Press();