
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


        //ogrenci
        var ogrenci = mainGroup.AddPermission(OgrenciOtomasyonSistemiPermissions.Ogrenci.Default,
            L($"{localizePrefix}:{nameof(OgrenciOtomasyonSistemiPermissions.Ogrenci)}"));

        ogrenci.AddChild(OgrenciOtomasyonSistemiPermissions.Ogrenci.Create,
            L($"{localizePrefix}:{nameof(OgrenciOtomasyonSistemiPermissions.Ogrenci)}{OgrenciOtomasyonSistemiPermissions.CreateConst}"));
        ogrenci.AddChild(OgrenciOtomasyonSistemiPermissions.Ogrenci.Update,
            L($"{localizePrefix}:{nameof(OgrenciOtomasyonSistemiPermissions.Ogrenci)}{OgrenciOtomasyonSistemiPermissions.UpdateConst}"));
        ogrenci.AddChild(OgrenciOtomasyonSistemiPermissions.Ogrenci.Delete,
            L($"{localizePrefix}:{nameof(OgrenciOtomasyonSistemiPermissions.Ogrenci)}{OgrenciOtomasyonSistemiPermissions.DeleteConst}"));

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
