using System;
using System.Text.RegularExpressions;

namespace PersonalInfoStorage
{
    internal class PasswordAnalysis
    {
        private bool ThereIsUpperCase(string text)
        {
            int i = 0;
            bool f = false;
            while (f == false && i < text.Length)
            {
                if (Char.IsUpper(text[i]))
                    f = true;
                i++;
            }
            return f;
        }
        private bool ThereIsLowerCase(string text)
        {
            int i = 0;
            bool f = false;
            while (f == false && i < text.Length)
            {
                if (Char.IsLower(text[i]))
                    f = true;
                i++;
            }
            return f;
        }

        private bool ThereIsNumber(string text)
        {
            int i = 0;
            bool f = false;
            while (f == false && i < text.Length)
            {
                if (Char.IsNumber(text[i]))
                    f = true;
                i++;
            }
            return f;
        }

        private bool ThereIsSpecSymb(string text)
        {
            const string Pattern = @"[`~!@#№$;%^&*():?_\-+=\.,><}\]{[/|]+";
            Regex r = new Regex(pattern: Pattern, RegexOptions.Compiled);
            Match match = r.Match(text);
            return match.Success;
        }

        public bool CheckPassword(int value, string pass)
        {
            if (value == 1 && pass.Length >= 8
                && ThereIsNumber(pass))
                return true;

            if (value == 2 && pass.Length >= 8
                && ThereIsNumber(pass) && ThereIsUpperCase(pass) && ThereIsLowerCase(pass))
                return true;

            if (value == 3 && pass.Length >= 8
                && ThereIsNumber(pass) && ThereIsUpperCase(pass) && ThereIsLowerCase(pass)
                && ThereIsSpecSymb(pass))
                return true;
            return false;
        }
    }
}
