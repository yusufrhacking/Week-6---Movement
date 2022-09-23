# Week 6 - Movement

Slides: https://myuva-my.sharepoint.com/:p:/g/personal/jcb2h_virginia_edu/ERjqsUiQ5gpPltv-CAwmhRABWwU55z_7ODFNJVfafb_rJQ?e=ODkXea

Manual: https://docs.unity3d.com/Manual/rigidbody-physics-section.html
https://docs.unity3d.com/ScriptReference/Transform.html
https://docs.unity3d.com/ScriptReference/Rigidbody.html


## Skills

* transform.position / transform.Translate(Vector3)
* rigidbody.MovePosition(Vector3)
* rigidbody.AddForce(Vector3)
* Kinematic Rigidbodies
* transform.rotation / transform.Rotate(Vector3)
* Quaternions
* rigidbody.MoveRotation(Quaternion)
* rigidbody.AddTorque(Vector3)

## Level

1. Complete the 5 "Learning Units" in the Asset folder
	* In unit 01, your goal is to move the red cube to the left
	* In units 02 - 05, your goal is to knock the blue cube off the stage
	* In unit 04, you have a **SPECIAL** goal, which is to knock the blue cube off the stage, BUT leave the red cube ON the stage
	* In each unit, there is either something wrong with a script or an element in the inspector, but never both 
	* Scripts will have commented instructions within them with extra parameters for solving the units (e.g. // Don't change this value!)
	* In each unit, you don't need to write any NEW LINES of code, but you might need to change the code that is written.
	* When you solve the unit, write a comment in the code explaining what you did and why it worked.
2. Open the "WashingMachine" Learning Unit and build an "agitator" that spins around inside the blue washing machine (you will need to create a new script to do this-- use the scripts from #1 as models)
3. Add some marbles to the washing machine 
4. Add some super balls (i.e. very bouncy) to the washing machine (HINT: there are Materials that can affect Physics)
5. If your agitator doesn't do this already, make it such that your agitator can "jam" (or at least slow down) if there are too many balls (HINT: you can't use transform.Rotate() for this)
6. Add the "ballerina" model to your scene. Make the ballerina spin at the EXACT speed as the agitator from #5

## Bosses

### Bowser

Build a simple game level with the following obstacles:

1. Moving lasers (HINT: lasers can just be very skinny capsules / cyllinders)
	* If you touch a laser, you go back to the start of the level.
2. A sequence where you have to jump between moving blocks
	* If you fall into the "pit" around these blocks, you go back to the start of the level
3. A sequence where you have to walk down a narrow bridge avoiding spinning blocks that could knock you off

### Hornet

Build the same as above, with the following changes:

1. The lasers ARE actual lasers (you'll need to use Raycasts and the LineRenderer Component)
2. The blocks "dip" a little when you land on them (but move back to their starting height), i.e. they feel more like wood floating on water than sci-fi floating platforms
3. The blocks spin up to a very fast speed, then slow down
4. The whole room sways back and forth (and everything else continues to work-- you might need to use AddRelativeForce() and AddRelativeTorque())
5. Have a big scary face watch the player the whole time, looking directly at them

### Demon of Hatred

Build a giant working pinball machine that plays itself. The "evil pinball AI" tries to launch the ball towards the player, who starts at the top of the machine and has to try to run all the way down its length and get through the hole in the bottom. If the player gets hit by the ball, they die and restart. If they touch certain parts of the machine, they die and restart.

HINT (you don't need the AI to do perfect torque calculations on the paddles, but it needs to "seem" fair as it launches the ball towards the player)