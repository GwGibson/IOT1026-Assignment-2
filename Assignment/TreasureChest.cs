using System;

namespace Assignment
{
    public class TreasureChest
    {
        private State _state = State.Open;
        private readonly Material _material;
        private readonly LockType _lockType;
        private readonly LootQuality _lootQuality;

        // Default Constructor
        public TreasureChest()
        {
            _material = Material.Bronze;
            _lockType = LockType.Basic;
            _lootQuality = LootQuality.Common;
        }

        // Parameterized Constructor
        public TreasureChest(Material material, LockType lockType, LootQuality lootQuality)
        {
            _material = material;
            _lockType = lockType;
            _lootQuality = lootQuality;
        }

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
            }
            return _state;
        }

        public void Unlock()
        {
            if (_state == State.Locked)
            {
                _state = State.Closed;
                Console.WriteLine("The chest is unlocked.");
            }
            else
            {
                Console.WriteLine("The chest is already unlocked.");
            }
        }

        public void Lock()
        {
            if (_state == State.Closed)
            {
                _state = State.Locked;
                Console.WriteLine("The chest is locked.");
            }
            else
            {
                Console.WriteLine("The chest cannot be locked in the current state.");
            }
        }

        public void Open()
        {
            if (_state == State.Closed)
            {
                _state = State.Open;
                Console.WriteLine("The chest is now open.");
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
            if (_state == State.Open)
            {
                _state = State.Closed;
                Console.WriteLine("The chest is now closed.");
            }
            else if (_state == State.Closed)
            {
                Console.WriteLine("The chest is already closed!");
            }
            else if (_state == State.Locked)
            {
                Console.WriteLine("The chest cannot be closed because it is locked.");
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
        public enum Action { Open, Close, Lock, Unlock };

        public enum State { Open, Closed, Locked };

        public enum Material
        {
            Bronze,
            Silver,
            Gold
        }

        public enum LockType
        {
            Basic,
            Advanced,
            Master
        }

        public enum LootQuality
        {
            Common,
            Rare,
            Legendary
        }
    }
}