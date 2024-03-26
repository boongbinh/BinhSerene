using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace BinhSerene.MovieDB.Columns;

[ColumnsScript("MovieDB.Movie")]
[BasedOnRow(typeof(MovieRow), CheckNames = true)]
public class MovieColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int MovieId { get; set; }
    [EditLink]
    [DisplayName("Title in test"), Width(150), AlignRight]
    public string Title { get; set; }
    public string Description { get; set; }
    public string Storyline { get; set; }
    public int Year { get; set; }
    public DateTime ReleaseDate { get; set; }
    public int Runtime { get; set; }
    public MovieKind Kind { get; set; }
    [Width(100), QuickFilter]
    //public string GenreName { get; set; }
    public List<int> GenreList { get; set; }
}