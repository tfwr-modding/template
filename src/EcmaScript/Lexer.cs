using EcmaScript.utils;

namespace EcmaScript.EcmaScript;

public class Lexer
{
    public Result<TokenStream, Exception> Process(string code)
    {
        var stream = new TokenStream();
        var chars = code.ToCharArray();
        var idx = 0;
        
        // Adding an empty line at the start is necessary, otherwise the game does nothing
        stream.Add(new(TokenType.NEW_LINE, "\n", 0));

        while (idx < chars.Length)
        {
            var chr = chars[idx];
            var value = chr.ToString();
            
            switch (chr)
            {
                case ' ' or '\t' or '\n':
                {
                    if (chr == '\n') {
                        stream.Add(new(TokenType.NEW_LINE, value, 0));
                    }

                    idx++;
                    break;
                }
                
                case '(': {
                    stream.Add(new(TokenType.BRACKET_OPEN, value, 0));
                    idx++;
                    break;
                }
                
                case ')': {
                    stream.Add(new(TokenType.BRACKET_CLOSE, value, 0));
                    idx++;
                    break;
                }

                default:
                {
                    if (char.IsLetter(chr) || chr == '_')
                    {
                        var letters = new List<char>();
                        while (idx < chars.Length && (char.IsLetterOrDigit(chars[idx]) || chars[idx] == '_'))
                        {
                            letters.Add(chars[idx]);
                            idx++;
                        }
                        stream.Add(new(TokenType.IDENTIFIER, new string(letters.ToArray()), 0));
                    }
                    else
                    {
                        stream.Add(new(TokenType.UNKNOWN, value, 0));
                        idx++;
                    }
                    break;
                }
            }
        }
        
        return Result<TokenStream, Exception>.Ok(stream);
    }
}
