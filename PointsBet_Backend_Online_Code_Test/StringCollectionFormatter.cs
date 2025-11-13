namespace PointsBet_Backend_Online_Code_Test;


    /*
    Improve a block of code as you see fit in C#.
    You may make any improvements you see fit, for example:
      - Cleaning up code
      - Removing redundancy
      - Refactoring / simplifying
      - Fixing typos
      - Any other light-weight optimisation
    */
    public static class StringCollectionFormatter
    {

        //Code to improve
        public static string ToCommaSeparatedQuotedString(string[] items, string quote)
        {
            if(!IsValidInput(items, quote))
            {
                return string.Empty;
            }
           
            return string.Join(", ", items
                .Where(i => !string.IsNullOrEmpty(i))
                .Select(i => ToQuotedString(i, quote)));
        }

        private static bool IsValidInput(string[] items, string quote)
        {
            return items != null && items.Length > 0 && !string.IsNullOrEmpty(quote);
        }

        private static string ToQuotedString(string item, string quote)
        {
            return $"{quote}{item}{quote}";
        }
    }

