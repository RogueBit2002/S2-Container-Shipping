// See https://aka.ms/new-console-template for more information

using LaurensKruis.ContainerShipping;

Ship ship = new Ship(5, 5);

for(int y = ship.Height - 1; y >= 0; y--)
{
    string output = "";
    for (int x = 0; x < ship.Width; x++)
        output += $"{ship[x, y].ToString()} ";

    Console.WriteLine(output);
}