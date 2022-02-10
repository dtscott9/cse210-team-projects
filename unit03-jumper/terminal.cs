namespace terminal
{
    public class Terminal
    {
        private string displayWord;


        // public SetDisplayWord()
        // {

        // }

        public string CreateDisplayWord(string guessWord) //gues word is the word the user trys to guess
        {
            string tempWord = "";
            for (int i = 0; i < guessWord.Length; i++)
            {
                tempWord = tempWord + "_";
            }
            return tempWord;
        }
    }
}