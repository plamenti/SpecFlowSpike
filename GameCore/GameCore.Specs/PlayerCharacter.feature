﻿Feature: PlayerCharacter
	In order play the game
	As a human player
	I want my character attributes to be correctly represented 

Scenario Outline: Health reduction
	Given I am a new player
	When I take <damage> damage
	Then My health should now be <remainingHealth>

	Examples: 
	| damage | remainingHealth |
	| 0      | 100             |
	| 40     | 60              |
	| 50     | 50              |

Scenario: Taking too much damage should results in player death
	Given I am a new player
	When I take 100 damage
	Then I should be death

Scenario: Elf race characters get additional 20 damage resistance
	Given I am a new player
	And I have a damage resistance of 10
	And I am an Elf
	When I take 40 damage
	Then My health should now be 90

Scenario: Elf race characters get additional 20 damage resistance using data table
	Given I am a new player
	And I have the following attributes
	| attribute  | value |
	| Race       | Elf   |
	| Resistance | 10    |
	When I take 40 damage
	Then My health should now be 90