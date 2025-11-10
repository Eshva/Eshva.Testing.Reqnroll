using Reqnroll;

namespace Eshva.Testing.Reqnroll.Tests.InProcess.Transformations;

internal static class StringsTable {
  public static IReadOnlyList<string> GetStrings(this Table table) =>
    table.Rows.Select(row => row.Single().Value).ToArray();
}
