namespace InputWatcher
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            KeyboardHook keyboardHook = new KeyboardHook(KeyboardHook_KeyDownEvent, KeyboardHook_KeyUpEvent);

            keyboardHook.Hook();
            Task.Run(() =>
            {
                while (true)
                {
                    Task.Delay(100);
                }
            }).Wait();
        }

        private static void KeyboardHook_KeyDownEvent(object sender, KeyEventArg e)
        {
            Console.WriteLine($"Keyup KeyCode {e.KeyCode}");
        }

        private static void KeyboardHook_KeyUpEvent(object sender, KeyEventArg e)
        {
            Console.WriteLine($"Keydown KeyCode {e.KeyCode}");
        }
    }
}