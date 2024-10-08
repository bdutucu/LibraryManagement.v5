﻿using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace LibraryManagement.v5.Books;

public class Book : AuditedAggregateRoot<Guid>
{
    public string Name { get; set; }

    public Guid AuthorId { get; set; }

    public Guid ShelfId { get; set; }
    public BookType Type { get; set; }

    public DateTime PublishDate { get; set; }

    public string Shelf { get; set; }
}