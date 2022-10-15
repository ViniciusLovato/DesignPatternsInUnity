public class InAirState : LocomotionState
{
    public void Jump(LocomotionContext context)
    {
    }

    public void Fall(LocomotionContext context)
    {
    }

    public void Land(LocomotionContext context)
    {
        context.SetState(new GroundedState());
    }

    public void Crouch(LocomotionContext context)
    {
    }
}
