using FluentAssertions;
using Reqnroll;

namespace Eshva.Testing.Reqnroll.Tests.InProcess.Transformations;

[Binding]
internal sealed class NumberTransformationsSteps {
  [When("I use value (.*) in a step accepting nullable signed byte value")]
  public void WhenIUseValueInAStepAcceptingNullableSignedByteValue(sbyte? value) =>
    _originalSignedByte = value;

  [Then("gotten signed byte value should be null")]
  public void ThenGottenSignedByteValueShouldBeNull() =>
    _originalSignedByte.Should().BeNull();

  [Then("gotten signed byte value should be minimum value")]
  public void ThenGottenSignedByteValueShouldBeMinimumValue() =>
    _originalSignedByte.Should().Be(sbyte.MinValue);

  [Then("gotten signed byte value should be maximum value")]
  public void ThenGottenSignedByteValueShouldBeMaximumValue() =>
    _originalSignedByte.Should().Be(sbyte.MaxValue);

  [When("I use value (.*) in a step accepting nullable unsigned byte value")]
  public void WhenIUseValueInAStepAcceptingNullableUnsignedByteValue(byte? value) =>
    _originalUnsignedByte = value;

  [Then("gotten unsigned byte value should be null")]
  public void ThenGottenUnsignedByteValueShouldBeNull() =>
    _originalUnsignedByte.Should().BeNull();

  [Then("gotten unsigned byte value should be minimum value")]
  public void ThenGottenUnsignedByteValueShouldBeMinimumValue() =>
    _originalUnsignedByte.Should().Be(byte.MinValue);

  [Then("gotten unsigned byte value should be maximum value")]
  public void ThenGottenUnsignedByteValueShouldBeMaximumValue() =>
    _originalUnsignedByte.Should().Be(byte.MaxValue);


  [When("I use value (.*) in a step accepting nullable signed integer value")]
  public void WhenIUseValueInAStepAcceptingNullableSignedIntegerValue(int? value) =>
    _originalSignedInteger = value;

  [Then("gotten signed integer value should be null")]
  public void ThenGottenSignedIntegerValueShouldBeNull() =>
    _originalSignedInteger.Should().BeNull();

  [Then("gotten signed integer value should be minimum value")]
  public void ThenGottenSignedIntegerValueShouldBeMinimumValue() =>
    _originalSignedInteger.Should().Be(int.MinValue);

  [Then("gotten signed integer value should be maximum value")]
  public void ThenGottenSignedIntegerValueShouldBeMaximumValue() =>
    _originalSignedInteger.Should().Be(int.MaxValue);

  [When("I use value (.*) in a step accepting nullable unsigned integer value")]
  public void WhenIUseValueInAStepAcceptingNullableUnsignedIntegerValue(uint? value) =>
    _originalUnsignedInteger = value;

  [Then("gotten unsigned integer value should be null")]
  public void ThenGottenUnsignedIntegerValueShouldBeNull() =>
    _originalUnsignedInteger.Should().BeNull();

  [Then("gotten unsigned integer value should be minimum value")]
  public void ThenGottenUnsignedIntegerValueShouldBeMinimumValue() =>
    _originalUnsignedInteger.Should().Be(uint.MinValue);

  [Then("gotten unsigned integer value should be maximum value")]
  public void ThenGottenUnsignedIntegerValueShouldBeMaximumValue() =>
    _originalUnsignedInteger.Should().Be(uint.MaxValue);


  [When("I use value (.*) in a step accepting nullable signed short integer value")]
  public void WhenIUseValueInAStepAcceptingNullableSignedShortIntegerValue(short? value) =>
    _originalSignedShortInteger = value;

  [Then("gotten signed short integer value should be null")]
  public void ThenGottenSignedShortIntegerValueShouldBeNull() =>
    _originalSignedShortInteger.Should().BeNull();

  [Then("gotten signed short integer value should be minimum value")]
  public void ThenGottenSignedShortIntegerValueShouldBeMinimumValue() =>
    _originalSignedShortInteger.Should().Be(short.MinValue);

  [Then("gotten signed short integer value should be maximum value")]
  public void ThenGottenSignedShortIntegerValueShouldBeMaximumValue() =>
    _originalSignedShortInteger.Should().Be(short.MaxValue);

  [When("I use value (.*) in a step accepting nullable unsigned short integer value")]
  public void WhenIUseValueInAStepAcceptingNullableUnsignedShortIntegerValue(ushort? value) =>
    _originalUnsignedShortInteger = value;

  [Then("gotten unsigned short integer value should be null")]
  public void ThenGottenUnsignedShortIntegerValueShouldBeNull() =>
    _originalUnsignedShortInteger.Should().BeNull();

  [Then("gotten unsigned short integer value should be minimum value")]
  public void ThenGottenUnsignedShortIntegerValueShouldBeMinimumValue() =>
    _originalUnsignedShortInteger.Should().Be(ushort.MinValue);

  [Then("gotten unsigned short integer value should be maximum value")]
  public void ThenGottenUnsignedShortIntegerValueShouldBeMaximumValue() =>
    _originalUnsignedShortInteger.Should().Be(ushort.MaxValue);


  [When("I use value (.*) in a step accepting nullable signed long integer value")]
  public void WhenIUseValueInAStepAcceptingNullableSignedLongIntegerValue(long? value) =>
    _originalSignedLongInteger = value;

  [Then("gotten signed long integer value should be null")]
  public void ThenGottenSignedLongIntegerValueShouldBeNull() =>
    _originalSignedLongInteger.Should().BeNull();

  [Then("gotten signed long integer value should be minimum value")]
  public void ThenGottenSignedLongIntegerValueShouldBeMinimumValue() =>
    _originalSignedLongInteger.Should().Be(long.MinValue);

  [Then("gotten signed long integer value should be maximum value")]
  public void ThenGottenSignedLongIntegerValueShouldBeMaximumValue() =>
    _originalSignedLongInteger.Should().Be(long.MaxValue);

  [When("I use value (.*) in a step accepting nullable unsigned long integer value")]
  public void WhenIUseValueInAStepAcceptingNullableUnsignedLongIntegerValue(ulong? value) =>
    _originalUnsignedLongInteger = value;

  [Then("gotten unsigned long integer value should be null")]
  public void ThenGottenUnsignedLongIntegerValueShouldBeNull() =>
    _originalUnsignedLongInteger.Should().BeNull();

  [Then("gotten unsigned long integer value should be minimum value")]
  public void ThenGottenUnsignedLongIntegerValueShouldBeMinimumValue() =>
    _originalUnsignedLongInteger.Should().Be(ulong.MinValue);

  [Then("gotten unsigned long integer value should be maximum value")]
  public void ThenGottenUnsignedLongIntegerValueShouldBeMaximumValue() =>
    _originalUnsignedLongInteger.Should().Be(ulong.MaxValue);


  private sbyte? _originalSignedByte;
  private byte? _originalUnsignedByte;
  private int? _originalSignedInteger;
  private uint? _originalUnsignedInteger;
  private short? _originalSignedShortInteger;
  private ushort? _originalUnsignedShortInteger;
  private long? _originalSignedLongInteger;
  private ulong? _originalUnsignedLongInteger;
}
