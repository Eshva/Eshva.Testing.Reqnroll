using FluentAssertions;
using Reqnroll;

namespace Eshva.Testing.Reqnroll.Tests.InProcess.Transformations;

[Binding]
internal sealed class StringsTransformationsSteps {
  [When("I use value (.*) in a step accepting nullable string value")]
  public void WhenIUseValueInAStepAcceptingNullableStringValue(string? originalValue) =>
    _originalValue = originalValue;

  [Then("gotten string value should be null")]
  public void ThenGottenStringValueShouldBeNull() =>
    _originalValue.Should().BeNull();

  [Then("gotten string value should be empty string")]
  public void ThenGottenStringValueShouldBeEmptyString() =>
    _originalValue.Should().NotBeNull().And.BeEmpty();

  [Then("gotten string value should be white-space only string")]
  public void ThenGottenStringValueShouldBeWhiteSpaceOnlyString() =>
    _originalValue.Should().NotBeNull().And.BeNullOrWhiteSpace();

  [When("I use value '(.*)' in a step accepting nullable string array")]
  public void WhenIUseValueInAStepAcceptingNullableStringArray(string[]? inlineList) =>
    _originalStringArray = inlineList;

  [When("I use value '(.*)' in a step accepting nullable string list")]
  public void WhenIUseValueInAStepAcceptingNullableStringList(List<string>? inlineList) =>
    _originalStringList = inlineList;

  [When("I use value '(.*)' in a step accepting nullable string readonly list")]
  public void WhenIUseValueInAStepAcceptingNullableStringReadonlyList(IReadOnlyList<string>? inlineList) =>
    _originalStringReadonlyList = inlineList;

  [Then("gotten string array should contain the following strings:")]
  public void ThenGottenStringArrayShouldContainTheFollowingStrings(Table itemList) =>
    _originalStringArray.Should().BeEquivalentTo(itemList.GetStrings());

  [Then("gotten string list should contain the following strings:")]
  public void ThenGottenStringListShouldContainTheFollowingStrings(Table itemList) =>
    _originalStringList.Should().BeEquivalentTo(itemList.GetStrings());

  [Then("gotten string readonly list should contain the following strings:")]
  public void ThenGottenStringReadonlyListShouldContainTheFollowingStrings(Table itemList) =>
    _originalStringReadonlyList.Should().BeEquivalentTo(itemList.GetStrings());

  [Then("gotten string array should be empty")]
  public void ThenGottenStringArrayShouldBeEmpty() =>
    _originalStringArray.Should().NotBeNull().And.BeEmpty();

  [Then("gotten string list should be empty")]
  public void ThenGottenStringListShouldBeEmpty() =>
    _originalStringList.Should().NotBeNull().And.BeEmpty();

  [Then("gotten string readonly list should be empty")]
  public void ThenGottenStringReadonlyListShouldBeEmpty() =>
    _originalStringReadonlyList.Should().NotBeNull().And.BeEmpty();

  [Then("gotten string array should be null")]
  public void ThenGottenStringArrayShouldBeNull() =>
    _originalStringArray.Should().BeNull();

  [Then("gotten string list should be null")]
  public void ThenGottenStringListShouldBeNull() =>
    _originalStringList.Should().BeNull();

  [Then("gotten string readonly list should be null")]
  public void ThenGottenStringReadonlyListShouldBeNull() =>
    _originalStringReadonlyList.Should().BeNull();

  private string? _originalValue;
  private string[]? _originalStringArray;
  private List<string>? _originalStringList;
  private IReadOnlyList<string>? _originalStringReadonlyList;
}
