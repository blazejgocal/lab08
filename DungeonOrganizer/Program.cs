using DungeonOrganizer.Characters;
using DungeonOrganizer.UI;
using DungeonOrganizer.Items;
using DungeonOrganizer.World;
using InventoryItem = DungeonOrganizer.Items.Item;
using MapItem = DungeonOrganizer.World.Item;

Player player = new Player("Ada", 100);
Enemy enemy = new Enemy("Goblin", 30);
DungeonOrganizer.Items.Item item =
    new DungeonOrganizer.Items.Item("Mikstura", 15);
DungeonOrganizer.Items.Weapon weapon =
    new DungeonOrganizer.Items.Weapon("Miecz", 8);
InventoryItem mikstura = new InventoryItem("Mikstura", 15);
MapItem mapItem = new MapItem("!");

GamePrinter.ShowHeader("Dungeon Organizer");
GamePrinter.ShowCharacter(player.Name, player.Health);
GamePrinter.ShowCharacter(enemy.Name, enemy.Health);
GamePrinter.ShowItem(item.Name, item.Price);
GamePrinter.ShowWeapon(weapon.Name, weapon.Damage);
Console.WriteLine($"Przedmiot: {mikstura.Name}, cena: {mikstura.Price}");
Console.WriteLine($"Symbol na mapie: {mapItem.Symbol}");