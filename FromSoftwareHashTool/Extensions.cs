namespace FromSoftwareHashTool
{
    public static class Extensions
    {
        public static int CharCount(this string str, char c)
        {
            int count = 0;
            foreach (char strC in str)
                if (strC == c)
                    count++;
            return count;
        }
    }
}
