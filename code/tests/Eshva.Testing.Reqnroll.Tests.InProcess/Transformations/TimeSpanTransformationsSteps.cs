using System.Globalization;
using FluentAssertions;
using Reqnroll;

namespace Eshva.Testing.Reqnroll.Tests.InProcess.Transformations;

[Binding]
internal sealed class TimeSpanTransformationsSteps {
  [When("I use value (.*) in step accepting nullable time span")]
  public void WhenIUseValueInStepAcceptingNullableTimeSpan(TimeSpan? originalTimeSpan) =>
    _originalTimeSpan = originalTimeSpan;

  [Then(@"gotten time span value should be ([\d\.:]+)")]
  public void ThenGottenTimeSpanValueShouldBeD(string value) =>
    _originalTimeSpan.Should().NotBeNull().And.Be(TimeSpan.Parse(value, CultureInfo.InvariantCulture));

  [Then("gotten time span value should be null")]
  public void ThenGottenTimeSpanValueShouldBeNull() =>
    _originalTimeSpan.Should().BeNull();

  [Then("gotten time span value should be minimal time span")]
  public void ThenGottenTimeSpanValueShouldBeMinimalTimeSpan() =>
    _originalTimeSpan.Should().NotBeNull().And.Be(TimeSpan.MinValue);

  [Then("gotten time span value should be maximal time span")]
  public void ThenGottenTimeSpanValueShouldBeMaximalTimeSpan() =>
    _originalTimeSpan.Should().NotBeNull().And.Be(TimeSpan.MaxValue);

  private TimeSpan? _originalTimeSpan;
}
