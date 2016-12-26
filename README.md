# StrawberryAdventure
Telerik Academy OOP1 Team Work

Main class: Startup - creates instance of TheGame class. ToDo - to create loop for intercepting keyboard input and moving our hero.

TheGame class - Singleton design pattern.
  To Do - Generates several Maps, Interface to create a hero - hero name and starting characteristics; damage calculation; methods for moving the hero, 

Map class - represents a map, has Width, Heights, Layout
  To Do - Generate random map, generate items for map, generate NPCs for map

BasicItem class - abstract class, basic for all items

Weapon, BodyArmor, LeggingsArmor, FullArmor, Helmet, Gloves, Boots, Ring, Necklace - successors of BasicItem class

BasicSkill class - abstract class, basic for all skills - To Do to make a constructor setting the properties, to create several successors, defining several classes of skills. Skill bonuses works as totalBonus = skillBasicBonus + skillLevel * skillPerLevelBonus. Two types of skills - first increases characteristics with fixed value, second multiply characterisitcs values. hero basic HP = 100, skill 1 gives 50 hp + 30 for every next skill level, skill 2 multiplies hp by (1.05 + 0.05 for every next level). Skill1 is level 5, skill2 is level 3. Total HP = (100 + 50 + 30 * (5 - 1)) * (1.05 + 0.05 * (3 - 1)) = 270* 1.15 = 310. Bonuses from items are counted afterwords.

BasicCharacter class - abstract class, basic for our hero and for NPCs. ToDo to change file name from ICharacter.cs to BasicCharacter.cs, to create constructor.

Character class - class for our hero. ToDo successor of BasicCharacter. Implements methods for equiping items, using potions, slowly regenerating hit points after battle, gaining experience, leveling up (after level up character gains several skill points and has to choose which skills to level), characteristics calculation based on skills, equiped items.

NPC class - clas for NPCs. ToDo successor of BasicCharacter, property Experience - how much experience npc gives our hero after been defeated.

ToDo - Implementation of Chests, Potions(immediate and time effects), logic for obstrucles(rock, tree, pit) on map.
