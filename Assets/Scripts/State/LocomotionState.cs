public interface LocomotionState
{
    void Jump(LocomotionContext context);
    void Fall(LocomotionContext context);
    void Land(LocomotionContext context);
    void Crouch(LocomotionContext context);
}
