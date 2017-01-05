# StrawberryAdventure
Telerik Academy OOP1 Team Work

Main class: Startup - creates instance of TheGame class. ToDo - to create loop for intercepting keyboard input and moving our hero:
 - arrows + (w,a,s,d) move hero, h - shows hero window(skills, skill points), i - shows hero inventory window 

TheGame class - Singleton design pattern.
  To Do - Generates several Maps, Interface to create a hero - hero name and starting characteristics; damage calculation; methods for moving the hero, battle, opening chests, victory condition; 

Map class - represents a map, has Width, Heights, Layout
  To Do - Generate random or static map, generate items for map, generate NPCs for map

BasicItem class - abstract class, basic for all items

Weapon, BodyArmor, LeggingsArmor, Helmet, Gloves, Boots, Ring, Necklace - successors of BasicItem class

BasicSkill class - abstract class, basic for all skills - To Do to make a constructor setting the properties (done), to create several successors (will not be implemented), defining several instances of skills. Skill bonuses works as totalBonus = skillBasicBonus + skillLevel * skillPerLevelBonus. Two types of skills - first increases characteristics with fixed value, second multiply characterisitcs values (second type will not be implemented). hero basic HP = 100, skill 1 gives 50 hp + 30 for every next skill level, skill 2 multiplies hp by (1.05 + 0.05 for every next level). Skill1 is level 5, skill2 is level 3. Total HP = (100 + 50 + 30 * (5 - 1)) * (1.05 + 0.05 * (3 - 1)) = 270* 1.15 = 310. Bonuses from items are counted afterwords.

BasicCharacter class - abstract class, basic for our hero and for NPCs. ToDo to change file name from ICharacter.cs to BasicCharacter.cs (done), to create constructor (done).

Character class - class for our hero. ToDo successor of BasicCharacter (done). Implements methods for equiping items, using potions, slowly regenerating hit points after battle (will not be implemented - after battle hp will be at maximum if win the battle), gaining experience, leveling up (after level up character gains several skill points and has to choose which skills to level), characteristics calculation based on skills, equiped items.

NPC class - clas for NPCs. ToDo successor of BasicCharacter, property Experience - how much experience npc gives our hero after been defeated.

ToDo - Implementation of Chests, Potions(immediate and time (will not be implemented) effects), logic for obstrucles(rock, tree, pit) on map.

Optionally - to create method for visualisation of the map on Console

Skills to be done:

Weapon mastery - increases attack.

Armor mastery - increases defense.

Battle proficiency - increases accuracy.

Agility - increases evasion.

Iron body - increases HP (for increasing level with one - increasing HP with 5 or 10)

Theft mastery - increases chest unlock chance


To be done - experience needed to level up

level 1 - 0 - 999 exp points(EP).

level 2 - 1000 - 1999 EP. (+1000 EP to lvl up)

level 3 - 2000 - 3499 EP. (+1000 EP tp lvl up)

level 4 - 3500 - 5499 EP. (+1500 EP to lvl up)

http://classic.battle.net/diablo2exp/basics/levels.shtml - Diablo 2 model

https://us.battle.net/forums/en/d3/topic/12163276448 - Diablo 3 model

http://www.heroesofmightandmagic.com/heroes3/leveladv.shtml - Heroes 3 model

Implementation: array with int/long values, private method in Character class invoked after winning a battle to check if conditions for leveling up are met.

