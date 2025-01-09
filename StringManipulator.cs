namespace StringManipulatorApp
{
    public class StringManipulator
    {
        public string ReverseString(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public string RemoveWhitespace(string input)
        {
            return string.Concat(input.Where(c => !char.IsWhiteSpace(c)));
        }

        public string ConcatenateStrings(string str1, string str2)
        {
            return str1 + str2;
        }
    }
}
