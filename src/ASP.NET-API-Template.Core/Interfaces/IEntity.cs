﻿namespace ASP.NET_API_Template.Core.Interfaces;

public interface IEntity
{
    int Id { get; set; }
    DateTime CreatedDate { get; set; }
    DateTime? ModifiedDate { get; set; }
}
