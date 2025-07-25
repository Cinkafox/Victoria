using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;

namespace Content.Shared.Scoping;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
[Access(typeof(SharedScopeSystem))]
public sealed partial class ScopeComponent : Component
{
    /// <summary>
    /// The entity that's scoping
    /// </summary>
    [ViewVariables, AutoNetworkedField]
    public EntityUid? User;

    /// <summary>
    /// Value to which zoom will be set when scoped in
    /// </summary>
    [DataField, AutoNetworkedField]
    public float Zoom = 1f;

    /// <summary>
    ///     How much to offset the user's view by when scoping.
    /// </summary>
    [DataField, AutoNetworkedField]
    public float Offset = 15;

    /// <summary>
    /// If set to true, the user's movement won't interrupt the scoping action.
    /// </summary>
    [DataField, AutoNetworkedField]
    public bool AllowMovement;

    [DataField, AutoNetworkedField]
    public EntProtoId ScopingToggleAction = "ActionToggleScope";

    [DataField, AutoNetworkedField]
    public EntityUid? ScopingToggleActionEntity;

    [DataField, AutoNetworkedField]
    public bool RequireWielding;

    [DataField, AutoNetworkedField]
    public bool UseInHand;

    [DataField, AutoNetworkedField]
    public Direction? ScopingDirection;

    [DataField, AutoNetworkedField]
    public TimeSpan Delay = TimeSpan.FromSeconds(1);

    [DataField, AutoNetworkedField]
    public EntityUid? RelayEntity;

    [DataField, AutoNetworkedField]
    public bool Attachment;
}
