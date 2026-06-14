using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;

namespace Content.Shared.Mind;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
public sealed partial class MindLinkComponent : Component
{
    /// <summary>
    /// Available mind channels for this entity
    /// </summary>
    [DataField, AutoNetworkedField]
    public HashSet<ProtoId<MindChannelPrototype>> Channels = new();

    /// <summary>
    /// Special for shadowkins
    /// </summary>
    [DataField]
    public bool MindTelepathy = false;

    public readonly string Action = "ActionShadowkinTransmit";
}

[RegisterComponent]
public sealed partial class AdminMindLinkListenerComponent : Component;
