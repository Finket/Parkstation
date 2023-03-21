using Content.Server.Xenoarchaeology.XenoArtifacts.Effects.Systems;

namespace Content.Server.Xenoarchaeology.XenoArtifacts.Effects.Components;

/// <summary>
/// Artifact that EMP
/// </summary>
[RegisterComponent]
[Access(typeof(EmpArtifactSystem))]
public sealed class EmpArtifactComponent : Component
{
    [DataField("range"), ViewVariables(VVAccess.ReadWrite)]
    public float Range = 4f;

    [DataField("energyConsumption"), ViewVariables(VVAccess.ReadWrite)]
    public float EnergyConsumption = 1000000;
}
