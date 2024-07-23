namespace InfrastructureService
{
    public class Number
    {
        public static string Seprator(string number)
        {
            if (number.Length == 0)
                number = "0";
            number.Replace(",", "");
            int i = number.Length;
            string b = "";
            while (i > 3)
            {
                i -= 3;
                b = number.Substring(i, 3) + "," + b;
            }
            b = number.Substring(0, i) + "," + b;
            if (b.Substring(0, 1) == ",")
                b = b.Substring(1);
            if (b.Substring(b.Length - 1, 1) == ",")
                b = b.Substring(0, b.Length - 1);
            b = b.Replace("-,", "-");
            return b;
        }
    }
}
