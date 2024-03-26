namespace BinhSerene.MovieDB;

[EnumKey("MovieDB.MovieKind")]
public enum MovieKind
{
    [Description("Film")]
    Film = 1,
    [Description("Mini Series")]
    MiniSeries = 3,
    [Description("Test Series")]
    TestSeries = 4
}