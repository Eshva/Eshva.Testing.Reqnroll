using System.Globalization;
using FluentAssertions;
using Reqnroll;

namespace Eshva.Testing.Reqnroll.Tests.InProcess.Transformations;

[Binding]
internal sealed class DateTimeOffsetTransformationsSteps {
  [When("I use value (.*) in a step accepting non nullable date-time offset value")]
  public void WhenIUseValueInAStepAcceptingNonNullableDateTimeOffsetValue(DateTimeOffset originalValue) =>
    _originalValue = originalValue;

  [When("I use value (.*) in a step accepting nullable date-time offset value")]
  public void WhenIUseValueInAStepAcceptingNullableDateTimeOffsetValue(DateTimeOffset? originalValue) =>
    _originalValue = originalValue;

  [Then(
    @"parsed date-time offset value should be (\d{2}\.\d{2}\.\d{4} \d{2}:\d{2}:\d{2}) at UTC",
    ExpressionType = ExpressionType.RegularExpression)]
  public void ThenParsedValueShouldBeAtUtc(string value) {
    var expected = DateTimeOffset.ParseExact(
      value,
      DateTimeFormat,
      formatProvider: null,
      DateTimeStyles.AssumeUniversal);
    _originalValue.Should().NotBeNull().And.Be(expected);
  }

  [Then("parsed date-time offset value should be maximum date-time value at UTC")]
  public void ThenParsedDateTimeOffsetValueShouldBeMaximumDateTimeValueAtUtc() =>
    _originalValue.Should().NotBeNull().And.Be(DateTimeOffset.MaxValue);

  [Then("parsed date-time offset value should be minimum date-time value at UTC")]
  public void ThenParsedDateTimeOffsetValueShouldBeMinimumDateTimeValueAtUtc() =>
    _originalValue.Should().NotBeNull().And.Be(DateTimeOffset.MinValue);

  [Then("parsed date-time offset value should be null date-time value")]
  public void ThenParsedDateTimeOffsetValueShouldBeNullDateTimeValue() =>
    _originalValue.Should().BeNull();

  private DateTimeOffset? _originalValue;
  private const string DateTimeFormat = "dd.MM.yyyy HH:mm:ss";
}
