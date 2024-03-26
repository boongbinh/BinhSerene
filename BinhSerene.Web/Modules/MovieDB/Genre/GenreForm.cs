﻿using Serenity.ComponentModel;

namespace BinhSerene.MovieDB.Forms;

[FormScript("MovieDB.Genre")]
[BasedOnRow(typeof(GenreRow), CheckNames = true)]
public class GenreForm
{
    public string Name { get; set; }
}