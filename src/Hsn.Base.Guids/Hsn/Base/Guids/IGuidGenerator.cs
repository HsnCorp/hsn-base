using System;

namespace Hsn.Base.Guids;

/// <summary>
/// Used to generate Ids.
/// </summary>
public interface IGuidGenerator
{
    /// <summary>
    /// Creates a new <see cref="Guid"/>.
    /// </summary>
    Guid Create();
}