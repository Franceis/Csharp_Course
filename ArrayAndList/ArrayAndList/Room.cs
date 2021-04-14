
namespace ArrayAndList {
    class Room {
        public string Name { get; private set; }
        public string Email { get; private set; }

        public Room(string name, string email) {
            Name = name;
            Email = email;
        }
        public override string ToString() {
            return Name + ", " + Email;
        }
    }
}
