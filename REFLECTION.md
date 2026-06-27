Why did you use inheritance?
- I used inheritance because multiple classes (Car(), Boat(), Airplane(), and Helicopter()) uses the same logic as each other. This allows classes to inherit from a parent class.
- In this quiz, the Car(), Boat(), Airplane(), and Helicopter() inherits from the abstract class Vehicle().
- In Vehicle(), the abstract string Move() is declared, and this can be shared to the classes that inherited the parent class.
- By inheritance, the vehicle inherits the condition that it IS A vehicle.

Why did you use interfaces?
- I used interfaces to set contract for what the object (Vehicle) can do.
- IFlyable means the vehicle CAN fly.
- IDriveable means the vehicle CAN drive.
- ISailable means the vehicle CAN sail.
- If a Vehicle can do more than one, then it can implement 2 or more interfaces.
  
Could Helicopter inherit from both Vehicle and Airplane? Why or why not?
- No, because while classes can implement multiple interfaces, it can only inherit from one parent class.
- If Helicopter already inherited from Vehicle, then it cannot inherit from Airplane anymore (or any other classes).
- Or vice versa (which is not logical but) if Helicopter already inherited from Airplane, then it cannot inherit from Vehicle anymore (or any other classes).
  
Why can Helicopter implement both IFlyable and IDriveable?
- Because IFlyable and IDrivable are interfaces, not classes.
- As I mentioned above, classes can implement multiple interfaces.
- So, if Helicopter can both fly and drive, then it can implement both interfaces.
  
If a Submarine can both sail and dive, how would you design it?
- Just like the Helicopter, if a Submarine can both sail and drive, then a Submarine class (Submarine()) will implement both ISailable and IDriveable interfaces.
- This way, Submarine would have a contract from both interfaces, declaring that Submarine CAN sail and CAN drive.
- If I would code it:

* In Program.cs:

var submarine = TransportResolver.Resolve("submarine");

Assert(submarine is ISailable, "");
Assert(submarine is IDriveable, "");
Assert(submarine!.Move() == "Sailing in the water.", "");


* Then in Submarine.cs:

namespace TransportChallenge;

public class Submarine : Vehicle, ISailable, IDriveable
{
    public override string Move()
    {
        return "Sailing in the water.";
    }

}

/// It would still inherit from the parent class (Vehicle()) and would implement ISailable and IDrivable

* Then this would be added in TransportResolver.cs:

else if (input == "submarine") 
{
    return new Submarine();
}

