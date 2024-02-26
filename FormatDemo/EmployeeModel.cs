using System.Security.Cryptography.X509Certificates;

namespace FormatDemo;

public class EmployeeModel : IFormattable
{
    public string? FirstName { get; set; }
    public string? MiddleName { get; set; }
    public string? LastName { get; set; }

    public override string ToString()
    {
        return ToString(null, null);
    }

    public string ToString(string? format)
    {
        return ToString(format, null);
    }

    public string ToString(string? format, IFormatProvider? formatProvider)
    {
        format = format?.ToUpper();

        if (string.IsNullOrWhiteSpace(format) || format == "G")
        {
            return $"{FirstName} {LastName}";
        }

        switch (format)
        {
            case "L":
            case "LOGIN":
                return $"{FirstName?.Substring(0, 1)}{LastName}";
            case "S":
            case "SORTABLE":
                return $"{LastName}, {FirstName} {MiddleName}";
            default:
                return $"{FirstName} {LastName}";
        }
    }
}