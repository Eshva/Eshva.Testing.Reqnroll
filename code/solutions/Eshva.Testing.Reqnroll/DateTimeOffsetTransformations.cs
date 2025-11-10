using System.Globalization;
using Reqnroll;

namespace Eshva.Testing.Reqnroll;

/// <summary>
/// Date-time related step argument transformations.
/// </summary>
[Binding]
public static class DateTimeOffsetTransformations {
  /// <summary>
  /// Date-time offset transformation.
  /// </summary>
  /// <remarks>
  /// <para>
  /// Supports the following special values:
  /// <list type="bullet">
  /// <item><c>&lt;min&gt;</c> — <see cref="DateTimeOffset.MinValue"/></item>
  /// <item><c>&lt;max&gt;</c> — <see cref="DateTimeOffset.MaxValue"/></item>
  /// </list>
  /// </para>
  /// <para>
  /// Value format must be <c>dd.MM.yyyy HH:mm:ss</c>.
  /// </para>
  /// </remarks>
  /// <param name="value">String argument value.</param>
  /// <returns>
  /// Parsed date-time offset at UTC.
  /// </returns>
  [StepArgumentTransformation]
  public static DateTimeOffset DateTimeOffsetTransformation(string value) =>
    value switch {
      MaxValue => DateTimeOffset.MaxValue,
      MinValue => DateTimeOffset.MinValue,
      _ => ParseDateTimeOffset(value)
    };

  /// <summary>
  /// Nullable date-time offset transformation.
  /// </summary>
  /// <remarks>
  /// <para>
  /// Supports the following special values:
  /// <list type="bullet">
  /// <item><c>&lt;min&gt;</c> — <see cref="DateTimeOffset.MinValue"/></item>
  /// <item><c>&lt;max&gt;</c> — <see cref="DateTimeOffset.MaxValue"/></item>
  /// <item><c>&lt;null&gt;</c> — <c>null</c></item>
  /// <item><c>null</c> — <c>null</c></item>
  /// </list>
  /// </para>
  /// <para>
  /// Value format must be <c>dd.MM.yyyy HH:mm:ss</c>.
  /// </para>
  /// </remarks>
  /// <param name="value">String argument value.</param>
  /// <returns>
  /// Parsed date-time offset at UTC.
  /// </returns>
  [StepArgumentTransformation]
  public static DateTimeOffset? DateTimeOffsetNullableTransformation(string value) =>
    value switch {
      NullValue => null,
      null => null,
      _ => DateTimeOffsetTransformation(value)
    };

  private static DateTimeOffset ParseDateTimeOffset(string value) =>
    DateTimeOffset.ParseExact(
      value,
      DateTimeFormat,
      formatProvider: null,
      DateTimeStyles.AssumeUniversal);

  private const string MaxValue = "<max>";
  private const string MinValue = "<min>";
  private const string NullValue = "<null>";
  private const string DateTimeFormat = "dd.MM.yyyy HH:mm:ss";
}
