# Test assessment for Unity Engineering candidates

*Test project for applicants:*
Requires Unity 2018.3.0f2 or higher (in older ones some models can be broken)

**Goal:**
Implement a simple city builder where you can place and move buildings and produce resources from these buildings.

* Please, don't spend more than 6 hours on it.
* Please, concentrate on **data structures**, **separation of concerns** and **architecture** of the game. UX, usability and prettiness are not important at all.
* If you didn't implement all features - it's totally fine, feature's list is pretty big. Main goal for us is to see an architecture behind.
* In the end, please, provide a description explaning why you did this task the way you did (why did you choose certain architecture, UI management, data structures, etc) and especially what would you do differently if you would have more time. 
* Feel free to use 3rd party frameworks if needed

**Desired set of features:**

The game should have two main modes:
* **Regular mode:** in which player can select a building by clicking on it and see a it's name on top of it and current production progress (or can start a new production if no production is running)
* **Build mode:** the player can place a new building. When player presses 'build mode' he should see a simple list with building's names and their prices where he can choose a new building to place. He cannot place building on places occupied by other buildings

* Buildings should not be placeable on cells occupied by other buildings
* Placing a building costs resources
* When building is placed it should go through construction phase first (simple progressbar on top of the building) for 10 seconds before it can produce anything.
* Player is be able to select a building in the *regular mode* by clicking on it and see a simple progressbar of current production progress. 

**Building types**

3 Types of production buildings:
* 'Residence' - a building which produces automatically 100 gold every 10 seconds. After production is finished, the next one starts automatically. 
Placing a building cost 100 gold
* 'Wood production building' - a building which player first have to select and press 'start production' (just a simple button which appears on top of the building when we select it) and after it should start producing 50 wood in 10 seconds.
Placing a building cost 150 gold
* 'Steel production building' - same as wood production but produces steel instead. Produces 50 steel in 10 seconds.
Placing a building cost 150 gold and 100 wood


*BONUS FEATURES*: 
* buildings can be moved in the *build mode*

2 additional Types of decoration buildings:
* 'Bench' - a simple bench decoration which player can place.
Placing cost 150 gold and 50 steel
* 'Tree' - a simple decoration which player can place.  
Placing cost 50 gold and 200 wood


*Included Resources:*
* Set of prefabs of buildings with different grid sizes
* Simple grid shader
* Test scene with a grid and a few prefabs placed.
* Some base UI
