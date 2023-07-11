// Declare a namespace for the project, which helps organize your code and prevent naming conflicts
namespace MyApi.Models
{
    // Declare a public class named 'Customer', which can be accessed by other parts of your application
    public class Customer
    {
        // Declare a public integer property named 'Id'. This will be the unique identifier for each 'Customer' object.
        // 'get; set;' allows this property to be retrieved and changed by other parts of your application
        public int Id { get; set; }

        // Declare a public string property named 'Name'. This will hold the name for each 'Customer' object.
        // 'get; set;' allows this property to be retrieved and changed by other parts of your application
        public string Name { get; set; }

        // Declare a public string property named 'Email'. This will hold the email address for each 'Customer' object.
        // 'get; set;' allows this property to be retrieved and changed by other parts of your application
        public string Email { get; set; }

        // other properties...
    }
}
