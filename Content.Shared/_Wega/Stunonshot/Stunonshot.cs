using Robust.Shared.GameStates;

namespace Content.Shared._Wega.Snunonshot;

[RegisterComponent, NetworkedComponent]
[AutoGenerateComponentState]

public sealed partial class StunonshotComponent : Component
{
    [DataField, AutoNetworkedField]
    public float Stun = 2f;
}