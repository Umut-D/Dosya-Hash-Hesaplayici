namespace HashLibrary
{
    public static class GenislemeMetodu
    {
        public static string TiresizVeKucukHarfliYaz(this string yazi)
        {
            return yazi.Replace("-","").ToLower();
        }
    }
}