namespace training26;
internal class Program {
   public static bool areBracketsBalanced (string input) {
      var stack = new Stack<char> ();
      var bracketPairs = new Dictionary<char, char>
      {
         { ')', '(' },                                  // we are going to do this with Lifo concept
			{ ']', '[' },
         { '}', '{' }
      };
      foreach (var ch in input) {
         if (bracketPairs.ContainsValue (ch)) {
            stack.Push (ch);
         } else if (bracketPairs.ContainsKey (ch)) {
            if (stack.Count == 0 || stack.Pop () != bracketPairs[ch])  // if the stack is empty or the top of the stack doesn't match the corresponding opening bracket
            {
               return false;
            }
         }
      }
      return stack.Count == 0;
   }

   public static void Main () {
      Console.WriteLine ("Enter a string with brackets to check if they are balanced:");
      string input = Console.ReadLine ();
      bool x = areBracketsBalanced (input);
      Console.WriteLine ($"The brackets in the string are {(x ? "balanced" : "not balanced")}.");
   }
   }
