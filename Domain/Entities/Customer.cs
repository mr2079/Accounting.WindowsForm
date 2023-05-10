﻿namespace Domain.Entities;

public class Customer : BaseEntity
{
    public string FullName { get; set; } = string.Empty;
    public string Mobile { get; set; } = string.Empty;
    public string? Email { get; set; }


    public List<Transaction> Transactions { get; set; } = null!;
}
