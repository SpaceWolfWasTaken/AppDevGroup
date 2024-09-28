using GroupWork.Interface;

namespace GroupWork.Modal
{
    public class User : Interface.IDisplay
    {
        private UInt32 Id { get; set; }
        private string Name { get; set; }
        private string Email { get; set; }
        private string Password { get; set; }

        public User()
        {

        }

        public User(uint id, string name, string email, string password)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Password = password;
        }

        public void Display()
        {
            Console.WriteLine($"Your name is: {this.Name}");
            Console.WriteLine($"Your email is: {this.Email}");
        }

        public void Ask()
        {
            Console.Write("Enter your id: ");
            uint id = UInt32.Parse(Console.ReadLine());


            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your email: ");
            string email = Console.ReadLine();

            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Password = password;

            
        }
    }
}
