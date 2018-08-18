Feature: PlayerCharacter
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