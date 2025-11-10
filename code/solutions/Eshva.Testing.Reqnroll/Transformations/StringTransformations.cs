using Reqnroll;

namespace Eshva.Testing.Reqnroll.Transformations;

/// <summary>
/// Strings step argument transformations.
/// </summary>
[Binding]
public sealed class StringTransformations {
  /// <summary>
  /// Nullable string transformation.
  /// </summary>
  /// <remarks>
  /// Supports the following special values:
  /// <list type="bullet">
  /// <item><c>&lt;empty&gt;</c> — <see cref="string.Empty"/></item>
  /// <item><c>&lt;whitespace&gt;</c> — \r\n \t</item>
  /// <item><c>&lt;null&gt;</c> — <c>null</c></item>
  /// <item><c>null</c> — <c>null</c></item>
  /// </list>
  /// </remarks>
  /// <param name="value">Original string argument value.</param>
  /// <returns>
  /// Original string value or one of supported special values.
  /// </returns>
  [StepArgumentTransformation]
  public static string? StringNullableTransformation(string value) =>
    value switch {
      NullValue => null,
      EmptyValue => string.Empty,
      WhitespaceValue => @"\r\n \t",
      _ => value
    };

  /// <summary>
  /// Nullable string array transformation.
  /// </summary>
  /// <remarks>
  /// <para>
  /// Supports the following special values:
  /// <list type="bullet">
  /// <item><c>&lt;empty&gt;</c> — empty array."/></item>
  /// <item><c>&lt;null&gt;</c> — <c>null</c></item>
  /// <item><c>null</c> — <c>null</c></item>
  /// </list>
  /// </para>
  /// <para>
  /// Items in string argument should be separated with comma or semicolon. Items are trimmed after separation.
  /// </para>
  /// </remarks>
  /// <param name="value">String argument value.</param>
  /// <returns>
  /// String array or one of supported special values.
  /// </returns>
  [StepArgumentTransformation]
  public static string[]? StringArrayNullableTransformation(string value) =>
    value switch {
      NullValue => null,
      null => null,
      EmptyValue => [],
      "" => [],
      _ => value.Split(',', ';').Select(item => item.Trim()).ToArray()
    };

  /// <summary>
  /// Nullable readonly string list transformation.
  /// </summary>
  /// <remarks>
  /// <para>
  /// Supports the following special values:
  /// <list type="bullet">
  /// <item><c>&lt;empty&gt;</c> — empty list."/></item>
  /// <item><c>&lt;null&gt;</c> — <c>null</c></item>
  /// <item><c>null</c> — <c>null</c></item>
  /// </list>
  /// </para>
  /// <para>
  /// Items in string argument should be separated with comma or semicolon. Items are trimmed after separation.
  /// </para>
  /// </remarks>
  /// <param name="value">String argument value.</param>
  /// <returns>
  /// Readonly string list or one of supported special values.
  /// </returns>
  [StepArgumentTransformation]
  public static IReadOnlyList<string>? StringReadOnlyListNullableTransformation(string value) =>
    StringArrayNullableTransformation(value);

  /// <summary>
  /// Nullable string list transformation.
  /// </summary>
  /// <remarks>
  /// <para>
  /// Supports the following special values:
  /// <list type="bullet">
  /// <item><c>&lt;empty&gt;</c> — empty list."/></item>
  /// <item><c>&lt;null&gt;</c> — <c>null</c></item>
  /// <item><c>null</c> — <c>null</c></item>
  /// </list>
  /// </para>
  /// <para>
  /// Items in string argument should be separated with comma or semicolon. Items are trimmed after separation.
  /// </para>
  /// </remarks>
  /// <param name="value">String argument value.</param>
  /// <returns>
  /// String list or one of supported special values.
  /// </returns>
  [StepArgumentTransformation]
  public static List<string>? StringListNullableTransformation(string value) =>
    StringArrayNullableTransformation(value)?.ToList();

  private const string NullValue = "<null>";
  private const string EmptyValue = "<empty>";
  private const string WhitespaceValue = "<whitespace>";
}
