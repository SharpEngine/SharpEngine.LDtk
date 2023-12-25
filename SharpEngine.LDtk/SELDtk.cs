using SharpEngine.Core.Manager;

namespace SharpEngine.LDtk;

/// <summary>
/// Static class with extensions and add version functions
/// </summary>
public static class SELDtk
{
    /// <summary>
    /// Add versions to DebugManager
    /// </summary>
    public static void AddVersions()
    {
        DebugManager.Versions.Add("SharpEngine.LDtk", "1.0.0");
    }
}
