using System.ComponentModel.DataAnnotations;

namespace BooksWebShop.Models;

public class Category
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public int DisplayOrder { get; set; }



}
