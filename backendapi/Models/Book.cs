using System;
using System.Collections.Generic;

namespace backendapi.Models;

public partial class Book
{
    public int BookId { get; set; }

    public string? BookName { get; set; }

    public string? Author { get; set; }

    public string? PiblishedDate { get; set; }

    public string? Price { get; set; }

    public string? UrlLink { get; set; }

    public string? Descriptions { get; set; }
}
