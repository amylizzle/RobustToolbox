using Robust.Shared.GameStates;
using Robust.Shared.ViewVariables;

namespace Robust.Shared.GameObjects;

[NetworkedComponent]
public abstract partial class SharedYamlParticlesComponent : Component {
    [ViewVariables(VVAccess.ReadWrite)] public string ParticleType;
}
