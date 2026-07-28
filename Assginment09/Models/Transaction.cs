using System;

namespace Assginment09.Models;


public class Transaction
{
    public string Type { get; set; } = "";
    public decimal Amount { get; set; }
    public DateTime Time { get; set; }
}