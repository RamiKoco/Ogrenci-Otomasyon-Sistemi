
namespace AbcYazilim.OnMuhasebe.Permissions
{
    public class OnMuhasebePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var localizePrefix = "Permission";
            var mainGroup = context.AddGroup(OnMuhasebePermissions.GroupName,
                L($"{localizePrefix}:{OnMuhasebePermissions.GroupName}"));

            //ayar
            var ayar = mainGroup.AddPermission(OnMuhasebePermissions.Ayar.Default,
                L($"{localizePrefix}:{nameof(OnMuhasebePermissions.Ayar)}"));

          
            //donem
            var donem = mainGroup.AddPermission(OnMuhasebePermissions.Donem.Default,
                L($"{localizePrefix}:{nameof(OnMuhasebePermissions.Donem)}"));

            donem.AddChild(OnMuhasebePermissions.Donem.Create,
                L($"{localizePrefix}:{nameof(OnMuhasebePermissions.Donem)}{OnMuhasebePermissions.CreateConst}"));
            donem.AddChild(OnMuhasebePermissions.Donem.Update,
                L($"{localizePrefix}:{nameof(OnMuhasebePermissions.Donem)}{OnMuhasebePermissions.UpdateConst}"));
            donem.AddChild(OnMuhasebePermissions.Donem.Delete,
                L($"{localizePrefix}:{nameof(OnMuhasebePermissions.Donem)}{OnMuhasebePermissions.DeleteConst}"));

          

            //ogrenci
            var ogrenci = mainGroup.AddPermission(OnMuhasebePermissions.Ogrenci.Default,
                L($"{localizePrefix}:{nameof(OnMuhasebePermissions.Ogrenci)}"));

            ogrenci.AddChild(OnMuhasebePermissions.Ogrenci.Create,
                L($"{localizePrefix}:{nameof(OnMuhasebePermissions.Ogrenci)}{OnMuhasebePermissions.CreateConst}"));
            ogrenci.AddChild(OnMuhasebePermissions.Ogrenci.Update,
                L($"{localizePrefix}:{nameof(OnMuhasebePermissions.Ogrenci)}{OnMuhasebePermissions.UpdateConst}"));
            ogrenci.AddChild(OnMuhasebePermissions.Ogrenci.Delete,
                L($"{localizePrefix}:{nameof(OnMuhasebePermissions.Ogrenci)}{OnMuhasebePermissions.DeleteConst}"));
          
            // sube
            var sube = mainGroup.AddPermission(OnMuhasebePermissions.Sube.Default,
                L($"{localizePrefix}:{nameof(OnMuhasebePermissions.Sube)}"));

            sube.AddChild(OnMuhasebePermissions.Sube.Create,
                L($"{localizePrefix}:{nameof(OnMuhasebePermissions.Sube)}{OnMuhasebePermissions.CreateConst}"));
            sube.AddChild(OnMuhasebePermissions.Sube.Update,
                L($"{localizePrefix}:{nameof(OnMuhasebePermissions.Sube)}{OnMuhasebePermissions.UpdateConst}"));
            sube.AddChild(OnMuhasebePermissions.Sube.Delete,
                L($"{localizePrefix}:{nameof(OnMuhasebePermissions.Sube)}{OnMuhasebePermissions.DeleteConst}"));

          

            //Image
            var image = mainGroup.AddPermission(OnMuhasebePermissions.Image.Default,
                L($"{localizePrefix}:{nameof(OnMuhasebePermissions.Image)}"));

            image.AddChild(OnMuhasebePermissions.Image.Create,
                L($"{localizePrefix}:{nameof(OnMuhasebePermissions.Image)}{OnMuhasebePermissions.CreateConst}"));
            image.AddChild(OnMuhasebePermissions.Image.Update,
                L($"{localizePrefix}:{nameof(OnMuhasebePermissions.Image)}{OnMuhasebePermissions.UpdateConst}"));
            image.AddChild(OnMuhasebePermissions.Image.Delete,
                L($"{localizePrefix}:{nameof(OnMuhasebePermissions.Image)}{OnMuhasebePermissions.DeleteConst}"));

        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<OnMuhasebeResource>(name);
        }
    }
}
