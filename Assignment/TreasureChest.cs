namespace Assignment
{
    public class TreasureChest
    {
        private State _state = State.Locked;
        private readonly Material _material;
        private readonly LockType _lockType;
        private readonly LootQuality _lootQuality;

        // Default Constructor
        public TreasureChest()
        {
            _material = Material.Iron;
            _lockType = LockType.Expert;
            _lootQuality = LootQuality.Green;
        }

        // Document these methods with XML documentation
        public TreasureChest(State state) : this()
        {
            _state = state;
        }

        public TreasureChest(Material material, LockType lockType, LootQuality lootQuality)
        {
            _material = material;
            _lockType = lockType;
            _lootQuality = lootQuality;
        }

        // This is called a getter
        public State GetState()
        {
            return _state;
        }

        public State Manipulate(Action action)
        {
            switch (action)
            {
                case Action.Open:
                    Open();
                    break;
                case Action.Close:
                    Close();
                    break;
                case Action.Lock:
                    Lock();
                    break;
                case Action.Unlock:
                    Unlock();
                    break;
                default:
                    Console.WriteLine("Invalid action");
                    break;
            }
            return _state;
        }public void Unlock()
        {
            // We should check if the chest is Locked
            if (_state == State.Locked)
            {
                _state = State.Closed;
            }
            else if (_state == State.Closed)
            {
                Console.WriteLine("The chest needs to be Locked!");
            }
            else
            {
                Console.WriteLine("The chest needs to be closed , then locked.");
            }
        }

        public void Lock()
        {
            // We should check if the chest is Closed
            if (_state == State.Closed)
            {
                _state = State.Locked;
            }
            else if (_state == State.Locked)
            {
                Console.WriteLine("The chest is already Locked!");
            }
            else
            {
                Console.WriteLine("Close the Chest.");
            }
        }

        public void Open()
        {
            // We should check if the chest is closed
            if (_state == State.Closed)
            {
                _state = State.Open;
            }
            else if (_state == State.Open)
            {
                Console.WriteLine("The chest is already open!");
            }
            else if (_state == State.Locked)
            {
                Console.WriteLine("The chest cannot be opened because it is locked.");
            }
        }

        public void Close()
        {
            // We should check if the chest is open
            if (_state == State.Open)
            {
                _state = State.Closed;
            }
            else if (_state == State.Closed)
            {
                Console.WriteLine("The chest is already closed!");
            }
            else if (_state == State.Locked)
            {
                Console.WriteLine("The chest cannot be closed because it is  already locked.");
            }
        }

        public override string ToString()
        {
            return $"A {_state} chest with the following properties:\nMaterial: {_material}\nLock Type: {_lockType}\nLoot Quality: {_lootQuality}";
        }

        private static void ConsoleHelper(string prop1, string prop2, string prop3)
        {
            Console.WriteLine($"Choose from the following properties.\n1.{prop1}\n2.{prop2}\n3.{prop3}");
        }

        public enum State { Open, Closed, Locked };
        public enum Action { Open, Close, Lock, Unlock };
        public enum Material { Oak, RichMahogany, Iron };
        public enum LockType { Novice, Intermediate, Expert };
        public enum LootQuality { Grey, Green, Purple };
    }
}
