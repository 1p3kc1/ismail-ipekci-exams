namespace Odev34_Constructor_Invoice.Models;

public class Invoice
{
    public string InvoiceNo { get; set; } 
    public string CustomerName { get; set; } 

    public decimal Amount { get; set; }

    public decimal TaxRate { get; set; }

    public decimal TotalAmount { get; set; }

    public Invoice(string invoiceNo, string customerName, decimal amount)
    {
        InvoiceNo = invoiceNo;
        CustomerName = customerName;
        Amount = amount;
        TaxRate = 0.20m;
    }

    public Invoice(string invoiceNo, string customerName, decimal amount, decimal taxRate)
    {
        InvoiceNo = invoiceNo;
        CustomerName = customerName;
        Amount = amount;
        TaxRate = taxRate;
    }
}