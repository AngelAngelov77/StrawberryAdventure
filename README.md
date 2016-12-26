# StrawberryAdventure
Telerik Academy OOP1 Team Work

Main class: Startup - creates instance of TheGame class. ToDo - to create loop for intercepting keyboard input and moving our hero.

TheGame class - Singleton design pattern.
  To Do - Generates several Maps, Interface to create a hero - hero name and starting characteristics; damage calculation; methods for moving the hero, 

Map class - represents a map, fas Width, Heights, Layout
  To Do - Generate random map, generate items for map, generate NPCs for map

BasicItem class - abstract class, basic for all items

Weapon, BodyArmor, LeggingsArmor, FullArmor, Helmet, Gloves, Boots, Ring, Necklace - successors of BasicItem class

BasicSkill class - abstract class, basic for all skills - To Do to make a constructor setting the properties, to create several successors, defining several classes of skills.

BasicCharacter class - abstract class, basoc for our hero and for NPCs. ToDo to change file name from ICharacter.cs to BasicCharacter.cs, to create constructor.

Character class - class for our hero. ToDo successor of BasicCharacter.

NPC class - clas for NPCs. ToDo successor of BasicCharacter, property Experience - how much experience npc gives our hero after been defeated.
