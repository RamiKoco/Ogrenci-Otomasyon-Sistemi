
namespace OOS.OgrenciOtomasyonSistemi.Permissions
{
    public class OgrenciOtomasyonSistemiPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var localizePrefix = "Permission";
            var mainGroup = context.AddGroup(OgrenciOtomasyonSistemiPermissions.GroupName,
                L($"{localizePrefix}:{OgrenciOtomasyonSistemiPermissions.GroupName}"));

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
          
            // sube
            var sube = mainGroup.AddPermission(OgrenciOtomasyonSistemiPermissions.Sube.Default,
                L($"{localizePrefix}:{nameof(OgrenciOtomasyonSistemiPermissions.Sube)}"));

            sube.AddChild(OgrenciOtomasyonSistemiPermissions.Sube.Create,
                L($"{localizePrefix}:{nameof(OgrenciOtomasyonSistemiPermissions.Sube)}{OgrenciOtomasyonSistemiPermissions.CreateConst}"));
            sube.AddChild(OgrenciOtomasyonSistemiPermissions.Sube.Update,
                L($"{localizePrefix}:{nameof(OgrenciOtomasyonSistemiPermissions.Sube)}{OgrenciOtomasyonSistemiPermissions.UpdateConst}"));
            sube.AddChild(OgrenciOtomasyonSistemiPermissions.Sube.Delete,
                L($"{localizePrefix}:{nameof(OgrenciOtomasyonSistemiPermissions.Sube)}{OgrenciOtomasyonSistemiPermissions.DeleteConst}"));

          

            //Image
            var image = mainGroup.AddPermission(OgrenciOtomasyonSistemiPermissions.Image.Default,
                L($"{localizePrefix}:{nameof(OgrenciOtomasyonSistemiPermissions.Image)}"));

            image.AddChild(OgrenciOtomasyonSistemiPermissions.Image.Create,
                L($"{localizePrefix}:{nameof(OgrenciOtomasyonSistemiPermissions.Image)}{OgrenciOtomasyonSistemiPermissions.CreateConst}"));
            image.AddChild(OgrenciOtomasyonSistemiPermissions.Image.Update,
                L($"{localizePrefix}:{nameof(OgrenciOtomasyonSistemiPermissions.Image)}{OgrenciOtomasyonSistemiPermissions.UpdateConst}"));
            image.AddChild(OgrenciOtomasyonSistemiPermissions.Image.Delete,
                L($"{localizePrefix}:{nameof(OgrenciOtomasyonSistemiPermissions.Image)}{OgrenciOtomasyonSistemiPermissions.DeleteConst}"));

        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<OgrenciOtomasyonSistemiResource>(name);
        }
    }
}
