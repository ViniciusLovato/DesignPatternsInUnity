public class CrouchingState : LocomotionState
{
    public void Jump(LocomotionContext context)
    {
        context.SetState(new GroundedState());
    }

    public void Fall(LocomotionContext context)
    {
        context.SetState(new InAirState());
    }

    public void Land(LocomotionContext context)
    {
    }

    public void Crouch(LocomotionContext context)
    {
        context.SetState(new GroundedState());
    }
}
