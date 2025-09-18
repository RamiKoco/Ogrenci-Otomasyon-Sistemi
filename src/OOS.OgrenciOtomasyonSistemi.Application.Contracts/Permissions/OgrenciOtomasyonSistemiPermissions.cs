namespace OOS.OgrenciOtomasyonSistemi.Permissions;

public static class OgrenciOtomasyonSistemiPermissions
{
    public const string GroupName = "OgrenciOtomasyonSistemi";


    public const string CreateConst = ".Create";
    public const string UpdateConst = ".Update";
    public const string DeleteConst = ".Delete";
    public const string PrintConst = ".Print";
    public const string TransactionConst = ".Transaction";

    public static class Ayar
    {
        public const string Default = $"{GroupName}.{nameof(Ayar)}";
    }

    public static class Ogrenci
    {
        public const string Default = $"{GroupName}.{nameof(Ogrenci)}";
        public const string Create = Default + CreateConst;
        public const string Update = Default + UpdateConst;
        public const string Delete = Default + DeleteConst;
    }
    public static class Ogretmen
    {
        public const string Default = $"{GroupName}.{nameof(Ogretmen)}";
        public const string Create = Default + CreateConst;
        public const string Update = Default + UpdateConst;
        public const string Delete = Default + DeleteConst;
    }
    public static class Okul
    {
        public const string Default = $"{GroupName}.{nameof(Okul)}";
        public const string Create = Default + CreateConst;
        public const string Update = Default + UpdateConst;
        public const string Delete = Default + DeleteConst;
    }
    public static class OzelKod
    {
        public const string Default = $"{GroupName}.{nameof(OzelKod)}";
        public const string Create = Default + CreateConst;
        public const string Update = Default + UpdateConst;
        public const string Delete = Default + DeleteConst;
    }
}
