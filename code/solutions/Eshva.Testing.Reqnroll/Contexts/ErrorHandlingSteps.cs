using FluentAssertions;
using Reqnroll;

namespace Eshva.Testing.Reqnroll.Contexts;

/// <summary>
/// Error handling steps.
/// </summary>
[Binding]
public sealed class ErrorHandlingSteps {
  /// <summary>
  /// Initializes a new instance error handling context.
  /// </summary>
  /// <param name="errorHandlingContext">Error handling context.</param>
  /// <exception cref="ArgumentNullException">
  /// Error handling context not specified.
  /// </exception>
  public ErrorHandlingSteps(ErrorHandlingContext errorHandlingContext) {
    _errorHandlingContext = errorHandlingContext ?? throw new ArgumentNullException(nameof(errorHandlingContext));
  }

  /// <summary>
  /// Then no errors are reported step.
  /// </summary>
  [Then("no errors are reported")]
  [Then("не должно быть получено никаких ошибок")]
  public void ThenNoErrorsAreReported() =>
    _errorHandlingContext.LastException.Should().BeNull();

  /// <summary>
  /// Then not supported error should be reported step.
  /// </summary>
  [Then("not supported error should be reported")]
  [Then("я должен получить ошибку неподдерживаемой операции")]
  public void ThenNotSupportedErrorShouldBeReported() =>
    _errorHandlingContext.LastException.Should().NotBeNull().And.BeOfType<NotSupportedException>();

  /// <summary>
  /// Then argument not specified exception should be reported step.
  /// </summary>
  [Then("argument not specified error should be reported")]
  [Then("я должен получить ошибку о неопределённом аргументе")]
  public void ThenArgumentNotSpecifiedErrorShouldBeReported() =>
    _errorHandlingContext.LastException.Should().NotBeNull().And.BeOfType<ArgumentNullException>();

  /// <summary>
  /// Then invalid operation error should be reported step.
  /// </summary>
  [Then("argument out of range error should be reported")]
  [Then("я должен получить ошибку о выходе значения за допустимые границы")]
  public void ThenArgumentOutOfRangeErrorShouldBeReported() =>
    _errorHandlingContext.LastException.Should().NotBeNull().And.BeOfType<ArgumentOutOfRangeException>();

  /// <summary>
  /// Then invalid operation error should be reported step.
  /// </summary>
  [Then("invalid operation error should be reported")]
  [Then("я должен получить ошибку о недопустимой операции")]
  public void ThenInvalidOperationErrorShouldBeReported() =>
    _errorHandlingContext.LastException.Should().NotBeNull().And.BeOfType<InvalidOperationException>();

  private readonly ErrorHandlingContext _errorHandlingContext;
}
