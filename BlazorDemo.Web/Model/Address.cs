namespace BlazorDemo.Web.Model;

public class Address
{
    public int Id { get; set; }

    [Required]
    [MinLength(3, ErrorMessage = "Name must be at least 3 characters.")]
    [MaxLength(50, ErrorMessage = "Name must be 50 characters or less.")]
    public string Name { get; set; } = string.Empty;

    [Required]
    [MinLength(5, ErrorMessage = "Line 1 must be at least 5 characters.")]
    [MaxLength(50, ErrorMessage = "Line 1 must be 50 characters or less.")]
    public string Line1 { get; set; } = string.Empty;

    [MaxLength(50, ErrorMessage = "Line 2 must be 50 characters or less.")]
    public string Line2 { get; set; } = string.Empty;

    [Required]
    [MinLength(3, ErrorMessage = "City must be at least 3 characters.")]
    [MaxLength(50, ErrorMessage = "City must be 50 characters or less.")]
    public string City { get; set; } = string.Empty;

    [Required]
    [MinLength(3, ErrorMessage = "Region must be at least 3 characters.")]
    [MaxLength(20, ErrorMessage = "Region must be 20 characters or less.")]
    public string Region { get; set; } = string.Empty;

    [Required]
    [RegularExpression(@"^([0-9]{5})$", ErrorMessage = "Postal Code must be 5 numbers.")]
    public string PostalCode { get; set; } = string.Empty;
}