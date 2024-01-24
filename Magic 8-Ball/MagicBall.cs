namespace Magic_8_Ball
{
    internal class MagicBall
    {
        //Fields
        private string[] _phrases;
        private Random _random;

        //Constructor
        public MagicBall()
        {
            try
            {
                //Read the answers from the file
                _phrases = File.ReadAllLines("src/Phrases.txt");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                _phrases = new string[] { "No phrases found. Check file input." };
            }

            _random = new Random();
        }

        //Getters
        public string GetRandomPhrase()
        {
            return _phrases[_random.Next(_phrases.Length)];
        }
    }
}
