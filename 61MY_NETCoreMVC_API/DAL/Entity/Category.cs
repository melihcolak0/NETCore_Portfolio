using System.ComponentModel.DataAnnotations;

namespace _61MY_NETCoreMVC_API.DAL.Entity
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
    }
}
