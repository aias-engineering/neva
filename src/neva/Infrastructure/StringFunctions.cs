namespace NeVa.Infrastructure
{
    public static class StringFunctions
    {
        public static string ToValueString<T>(this T item)
        {
            if (item == null)
                return "null";
            if (item is string)
                return string.Format("'{0}'", item);
            return item.ToString();
        }
    }
}