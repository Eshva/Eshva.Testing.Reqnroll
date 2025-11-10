using System.Globalization;
using Reqnroll;

namespace Eshva.Testing.Reqnroll.Transformations;

/// <summary>
/// Number step argument transformations.
/// </summary>
[Binding]
public sealed class NumberTransformations {
  /// <summary>
  /// Nullable signed byte transformation.
  /// </summary>
  /// <remarks>
  /// <para>
  /// Supports the following special values:
  /// <list type="bullet">
  /// <item><c>&lt;min&gt;</c> — <see cref="sbyte.MinValue"/></item>
  /// <item><c>&lt;max&gt;</c> — <see cref="sbyte.MaxValue"/></item>
  /// <item><c>&lt;null&gt;</c> — <c>null</c></item>
  /// <item><c>null</c> — <c>null</c></item>
  /// </list>
  /// </para>
  /// <para>
  /// Value must be in invariant culture format.
  /// </para>
  /// </remarks>
  /// <param name="value">String argument value.</param>
  /// <returns>
  /// Parsed signed byte value or <c>null</c>.
  /// </returns>
  [StepArgumentTransformation]
  public static sbyte? SignedByteNullableTransformation(string value) =>
    value switch {
      MaxValue => sbyte.MaxValue,
      MinValue => sbyte.MinValue,
      NullValue => null,
      null => null,
      _ => sbyte.Parse(value, NumberStyles.Integer, CultureInfo.InvariantCulture)
    };

  /// <summary>
  /// Nullable unsigned byte transformation.
  /// </summary>
  /// <remarks>
  /// <para>
  /// Supports the following special values:
  /// <list type="bullet">
  /// <item><c>&lt;min&gt;</c> — <see cref="byte.MinValue"/></item>
  /// <item><c>&lt;max&gt;</c> — <see cref="byte.MaxValue"/></item>
  /// <item><c>&lt;null&gt;</c> — <c>null</c></item>
  /// <item><c>null</c> — <c>null</c></item>
  /// </list>
  /// </para>
  /// <para>
  /// Value must be in invariant culture format.
  /// </para>
  /// </remarks>
  /// <param name="value">String argument value.</param>
  /// <returns>
  /// Parsed unsigned byte value or <c>null</c>.
  /// </returns>
  [StepArgumentTransformation]
  public static byte? UnsignedByteNullableTransformation(string value) =>
    value switch {
      MaxValue => byte.MaxValue,
      MinValue => byte.MinValue,
      NullValue => null,
      null => null,
      _ => byte.Parse(value, NumberStyles.Integer, CultureInfo.InvariantCulture)
    };

  /// <summary>
  /// Nullable signed integer transformation.
  /// </summary>
  /// <remarks>
  /// <para>
  /// Supports the following special values:
  /// <list type="bullet">
  /// <item><c>&lt;min&gt;</c> — <see cref="int.MinValue"/></item>
  /// <item><c>&lt;max&gt;</c> — <see cref="int.MaxValue"/></item>
  /// <item><c>&lt;null&gt;</c> — <c>null</c></item>
  /// <item><c>null</c> — <c>null</c></item>
  /// </list>
  /// </para>
  /// <para>
  /// Value must be in invariant culture format.
  /// </para>
  /// </remarks>
  /// <param name="value">String argument value.</param>
  /// <returns>
  /// Parsed signed integer value or <c>null</c>.
  /// </returns>
  [StepArgumentTransformation]
  public static int? SignedIntegerNullableTransformation(string value) =>
    value switch {
      MaxValue => int.MaxValue,
      MinValue => int.MinValue,
      NullValue => null,
      null => null,
      _ => int.Parse(value, NumberStyles.Integer, CultureInfo.InvariantCulture)
    };

  /// <summary>
  /// Nullable unsigned integer transformation.
  /// </summary>
  /// <remarks>
  /// <para>
  /// Supports the following special values:
  /// <list type="bullet">
  /// <item><c>&lt;min&gt;</c> — <see cref="uint.MinValue"/></item>
  /// <item><c>&lt;max&gt;</c> — <see cref="uint.MaxValue"/></item>
  /// <item><c>&lt;null&gt;</c> — <c>null</c></item>
  /// <item><c>null</c> — <c>null</c></item>
  /// </list>
  /// </para>
  /// <para>
  /// Value must be in invariant culture format.
  /// </para>
  /// </remarks>
  /// <param name="value">String argument value.</param>
  /// <returns>
  /// Parsed unsigned integer value or <c>null</c>.
  /// </returns>
  [StepArgumentTransformation]
  public static uint? UnsignedIntegerNullableTransformation(string value) =>
    value switch {
      MaxValue => uint.MaxValue,
      MinValue => uint.MinValue,
      NullValue => null,
      null => null,
      _ => uint.Parse(value, NumberStyles.Integer, CultureInfo.InvariantCulture)
    };

  /// <summary>
  /// Nullable signed long integer transformation.
  /// </summary>
  /// <remarks>
  /// <para>
  /// Supports the following special values:
  /// <list type="bullet">
  /// <item><c>&lt;min&gt;</c> — <see cref="long.MinValue"/></item>
  /// <item><c>&lt;max&gt;</c> — <see cref="long.MaxValue"/></item>
  /// <item><c>&lt;null&gt;</c> — <c>null</c></item>
  /// <item><c>null</c> — <c>null</c></item>
  /// </list>
  /// </para>
  /// <para>
  /// Value must be in invariant culture format.
  /// </para>
  /// </remarks>
  /// <param name="value">String argument value.</param>
  /// <returns>
  /// Parsed signed long integer value or <c>null</c>.
  /// </returns>
  [StepArgumentTransformation]
  public static long? SignedLongNullableTransformation(string value) =>
    value switch {
      MaxValue => long.MaxValue,
      MinValue => long.MinValue,
      NullValue => null,
      null => null,
      _ => long.Parse(value, NumberStyles.Integer, CultureInfo.InvariantCulture)
    };

  /// <summary>
  /// Nullable unsigned long integer transformation.
  /// </summary>
  /// <remarks>
  /// <para>
  /// Supports the following special values:
  /// <list type="bullet">
  /// <item><c>&lt;min&gt;</c> — <see cref="ulong.MinValue"/></item>
  /// <item><c>&lt;max&gt;</c> — <see cref="ulong.MaxValue"/></item>
  /// <item><c>&lt;null&gt;</c> — <c>null</c></item>
  /// <item><c>null</c> — <c>null</c></item>
  /// </list>
  /// </para>
  /// <para>
  /// Value must be in invariant culture format.
  /// </para>
  /// </remarks>
  /// <param name="value">String argument value.</param>
  /// <returns>
  /// Parsed unsigned long integer value or <c>null</c>.
  /// </returns>
  [StepArgumentTransformation]
  public static ulong? UnsignedLongNullableTransformation(string value) =>
    value switch {
      MaxValue => ulong.MaxValue,
      MinValue => ulong.MinValue,
      NullValue => null,
      null => null,
      _ => ulong.Parse(value, NumberStyles.Integer, CultureInfo.InvariantCulture)
    };

  /// <summary>
  /// Nullable signed short integer transformation.
  /// </summary>
  /// <remarks>
  /// <para>
  /// Supports the following special values:
  /// <list type="bullet">
  /// <item><c>&lt;min&gt;</c> — <see cref="short.MinValue"/></item>
  /// <item><c>&lt;max&gt;</c> — <see cref="short.MaxValue"/></item>
  /// <item><c>&lt;null&gt;</c> — <c>null</c></item>
  /// <item><c>null</c> — <c>null</c></item>
  /// </list>
  /// </para>
  /// <para>
  /// Value must be in invariant culture format.
  /// </para>
  /// </remarks>
  /// <param name="value">String argument value.</param>
  /// <returns>
  /// Parsed signed short integer value or <c>null</c>.
  /// </returns>
  [StepArgumentTransformation]
  public static short? SignedShortNullableTransformation(string value) =>
    value switch {
      MaxValue => short.MaxValue,
      MinValue => short.MinValue,
      NullValue => null,
      null => null,
      _ => short.Parse(value, NumberStyles.Integer, CultureInfo.InvariantCulture)
    };

  /// <summary>
  /// Nullable unsigned short integer transformation.
  /// </summary>
  /// <remarks>
  /// <para>
  /// Supports the following special values:
  /// <list type="bullet">
  /// <item><c>&lt;min&gt;</c> — <see cref="ushort.MinValue"/></item>
  /// <item><c>&lt;max&gt;</c> — <see cref="ushort.MaxValue"/></item>
  /// <item><c>&lt;null&gt;</c> — <c>null</c></item>
  /// <item><c>null</c> — <c>null</c></item>
  /// </list>
  /// </para>
  /// <para>
  /// Value must be in invariant culture format.
  /// </para>
  /// </remarks>
  /// <param name="value">String argument value.</param>
  /// <returns>
  /// Parsed unsigned short integer value or <c>null</c>.
  /// </returns>
  [StepArgumentTransformation]
  public static ushort? UnsignedShortNullableTransformation(string value) =>
    value switch {
      MaxValue => ushort.MaxValue,
      MinValue => ushort.MinValue,
      NullValue => null,
      null => null,
      _ => ushort.Parse(value, NumberStyles.Integer, CultureInfo.InvariantCulture)
    };

  private const string MaxValue = "<max>";
  private const string MinValue = "<min>";
  private const string NullValue = "<null>";
}
