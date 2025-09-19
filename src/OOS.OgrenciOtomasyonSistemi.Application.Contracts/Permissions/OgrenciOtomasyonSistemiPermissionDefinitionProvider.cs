
namespace OOS.OgrenciOtomasyonSistemi.Permissions;
public class OgrenciOtomasyonSistemiPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var localizePrefix = "Permission";
        var mainGroup = context.AddGroup(OgrenciOtomasyonSistemiPermissions.GroupName);
        //Define your own permissions here.

        //ayar
        var ayar = mainGroup.AddPermission(OgrenciOtomasyonSistemiPermissions.Ayar.Default,
            L($"{localizePrefix}:{nameof(OgrenciOtomasyonSistemiPermissions.Ayar)}"));

        //donem
        var donem = mainGroup.AddPermission(OgrenciOtomasyonSistemiPermissions.Donem.Default,
            L($"{localizePrefix}:{nameof(OgrenciOtomasyonSistemiPermissions.Donem)}"));

        donem.AddChild(OgrenciOtomasyonSistemiPermissions.Donem.Create,
            L($"{localizePrefix}:{nameof(OgrenciOtomasyonSistemiPermissions.Donem)}{OgrenciOtomasyonSistemiPermissions.CreateConst}"));
        donem.AddChild(OgrenciOtomasyonSistemiPermissions.Donem.Update,
            L($"{localizePrefix}:{nameof(OgrenciOtomasyonSistemiPermissions.Donem)}{OgrenciOtomasyonSistemiPermissions.UpdateConst}"));
        donem.AddChild(OgrenciOtomasyonSistemiPermissions.Donem.Delete,
            L($"{localizePrefix}:{nameof(OgrenciOtomasyonSistemiPermissions.Donem)}{OgrenciOtomasyonSistemiPermissions.DeleteConst}"));


        //ogrenci
        var ogrenci = mainGroup.AddPermission(OgrenciOtomasyonSistemiPermissions.Ogrenci.Default,
            L($"{localizePrefix}:{nameof(OgrenciOtomasyonSistemiPermissions.Ogrenci)}"));

        ogrenci.AddChild(OgrenciOtomasyonSistemiPermissions.Ogrenci.Create,
            L($"{localizePrefix}:{nameof(OgrenciOtomasyonSistemiPermissions.Ogrenci)}{OgrenciOtomasyonSistemiPermissions.CreateConst}"));
        ogrenci.AddChild(OgrenciOtomasyonSistemiPermissions.Ogrenci.Update,
            L($"{localizePrefix}:{nameof(OgrenciOtomasyonSistemiPermissions.Ogrenci)}{OgrenciOtomasyonSistemiPermissions.UpdateConst}"));
        ogrenci.AddChild(OgrenciOtomasyonSistemiPermissions.Ogrenci.Delete,
            L($"{localizePrefix}:{nameof(OgrenciOtomasyonSistemiPermissions.Ogrenci)}{OgrenciOtomasyonSistemiPermissions.DeleteConst}"));

        //ogretmen
        var ogretmen = mainGroup.AddPermission(OgrenciOtomasyonSistemiPermissions.Ogretmen.Default,
            L($"{localizePrefix}:{nameof(OgrenciOtomasyonSistemiPermissions.Ogretmen)}"));

        ogretmen.AddChild(OgrenciOtomasyonSistemiPermissions.Ogretmen.Create,
            L($"{localizePrefix}:{nameof(OgrenciOtomasyonSistemiPermissions.Ogretmen)}{OgrenciOtomasyonSistemiPermissions.CreateConst}"));
        ogretmen.AddChild(OgrenciOtomasyonSistemiPermissions.Ogretmen.Update,
            L($"{localizePrefix}:{nameof(OgrenciOtomasyonSistemiPermissions.Ogretmen)}{OgrenciOtomasyonSistemiPermissions.UpdateConst}"));
        ogretmen.AddChild(OgrenciOtomasyonSistemiPermissions.Ogretmen.Delete,
            L($"{localizePrefix}:{nameof(OgrenciOtomasyonSistemiPermissions.Ogretmen)}{OgrenciOtomasyonSistemiPermissions.DeleteConst}"));

        //okul
        var okul = mainGroup.AddPermission(OgrenciOtomasyonSistemiPermissions.Okul.Default,
            L($"{localizePrefix}:{nameof(OgrenciOtomasyonSistemiPermissions.Okul)}"));

        okul.AddChild(OgrenciOtomasyonSistemiPermissions.Okul.Create,
            L($"{localizePrefix}:{nameof(OgrenciOtomasyonSistemiPermissions.Okul)}{OgrenciOtomasyonSistemiPermissions.CreateConst}"));
        okul.AddChild(OgrenciOtomasyonSistemiPermissions.Okul.Update,
            L($"{localizePrefix}:{nameof(OgrenciOtomasyonSistemiPermissions.Okul)}{OgrenciOtomasyonSistemiPermissions.UpdateConst}"));
        okul.AddChild(OgrenciOtomasyonSistemiPermissions.Okul.Delete,
            L($"{localizePrefix}:{nameof(OgrenciOtomasyonSistemiPermissions.Okul)}{OgrenciOtomasyonSistemiPermissions.DeleteConst}"));

        //ozelKod
        var ozelKod = mainGroup.AddPermission(OgrenciOtomasyonSistemiPermissions.OzelKod.Default,
            L($"{localizePrefix}:{nameof(OgrenciOtomasyonSistemiPermissions.OzelKod)}"));

        ozelKod.AddChild(OgrenciOtomasyonSistemiPermissions.OzelKod.Create,
            L($"{localizePrefix}:{nameof(OgrenciOtomasyonSistemiPermissions.OzelKod)}{OgrenciOtomasyonSistemiPermissions.CreateConst}"));
        ozelKod.AddChild(OgrenciOtomasyonSistemiPermissions.OzelKod.Update,
            L($"{localizePrefix}:{nameof(OgrenciOtomasyonSistemiPermissions.OzelKod)}{OgrenciOtomasyonSistemiPermissions.UpdateConst}"));
        ozelKod.AddChild(OgrenciOtomasyonSistemiPermissions.OzelKod.Delete,
            L($"{localizePrefix}:{nameof(OgrenciOtomasyonSistemiPermissions.OzelKod)}{OgrenciOtomasyonSistemiPermissions.DeleteConst}"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<OgrenciOtomasyonSistemiResource>(name);
    }
}
