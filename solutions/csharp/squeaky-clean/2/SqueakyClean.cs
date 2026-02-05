using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder sb = new StringBuilder("");
        bool isAfterDash = false;
        for (int i = 0; i<identifier.Length; i++)
        {
            char c = identifier[i];
            if (char.IsWhiteSpace(c))
            {
                sb.Append('_');
            } else if (char.IsControl(c))
            {
                sb.Append("CTRL");
            } else if (!char.IsLetter(c))
            {
                isAfterDash = c == '-';
                continue;
            } else if (char.IsLower(c) && c >= 'α' && c <= 'ω')
            {
                continue;
            } else {
                var kebabedChar = isAfterDash ? char.ToUpperInvariant(c) : c;
                sb.Append(kebabedChar);
                isAfterDash = false;
            }
        }

        return sb.ToString();
    }

}
