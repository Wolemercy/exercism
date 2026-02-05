using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder sb = new StringBuilder("");
        bool isKebab = false;
        char alpha = '\u03B1';
        char omega = '\u03C9';
        for (int i = 0; i<identifier.Length; i++)
        {
            char c = identifier[i];
            if (char.IsWhiteSpace(c))
            {
                sb.Append('_');
            } else if (char.IsControl(c))
            {
                sb.Append("CTRL");
            } else if (char.IsControl(c))
            {
                sb.Append("CTRL");
            } else if (!char.IsLetter(c))
            {
                isKebab = c == '-';
                continue;
            } else if (char.IsLower(c) && c >= alpha && c <= omega)
            {
                continue;
            } else {
                var kebabedChar = isKebab ? char.ToUpper(c) : c;
                sb.Append(kebabedChar);
                isKebab = false;
            }
        }

        return sb.ToString();
    }

}
