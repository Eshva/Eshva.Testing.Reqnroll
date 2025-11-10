using System.Globalization;
using Reqnroll;

namespace Eshva.Testing.Reqnroll.Transformations;

/// <summary>
/// Time span related step argument transformations.
/// </summary>
[Binding]
public static class TimeSpanTransformations {
  /// <summary>
  /// Time span transformation.
  /// </summary>
  /// <remarks>
  /// Supports the following special values:
  /// <list type="bullet">
  /// <item><c>&lt;min&gt;</c> — <see cref="TimeSpan.MinValue"/></item>
  /// <item><c>&lt;max&gt;</c> — <see cref="TimeSpan.MaxValue"/></item>
  /// <item><c>&lt;null&gt;</c> — <c>null</c></item>
  /// <item><c>null</c> — <c>null</c></item>
  /// </list>
  /// </remarks>
  /// <param name="value">String argument value.</param>
  /// <returns>
  /// Parsed time span.
  /// </returns>
  [StepArgumentTransformation]
  public static TimeSpan? TimeSpanNullableTransformation(string value) =>
    value switch {
      MaxValue => TimeSpan.MaxValue,
      MinValue => TimeSpan.MinValue,
      NullValue => null,
      null => null,
      _ => TimeSpan.Parse(value, CultureInfo.InvariantCulture)
    };

  private const string MaxValue = "<max>";
  private const string MinValue = "<min>";
  private const string NullValue = "<null>";
}
