public class LocomotionStatePattern : LocomotionState, LocomotionContext
{
    private LocomotionState currentState;

    public void Jump(LocomotionContext context) => currentState.Jump(context);

    public void Fall(LocomotionContext context) => currentState.Fall(context);

    public void Land(LocomotionContext context) => currentState.Land(context);

    public void Crouch(LocomotionContext context) => currentState.Crouch(context);

    public void SetState(LocomotionState newState) => currentState = newState;
}
