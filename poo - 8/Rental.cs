using System; using System.Globalization;

namespace poo___8 {
    public class Rental {
        
        public String Name { get; set; }
        public String Email { get; set; }

        public Rental(string name, string email) {
            Name = name;
            Email = email;
        }

        public override string ToString() {
            return Name + ", " + Email;
        }
    }
}