using JetBrains.Annotations;

namespace Eshva.Testing.Reqnroll.Contexts;

/// <summary>
/// Error handling context.
/// </summary>
[PublicAPI]
public sealed class ErrorHandlingContext {
  /// <summary>
  /// The last exception caught.
  /// </summary>
  public Exception? LastException { get; set; }
}
