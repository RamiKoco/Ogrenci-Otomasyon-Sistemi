using OOS.OgrenciOtomasyonSistemi.Samples;
using Xunit;

namespace OOS.OgrenciOtomasyonSistemi.EntityFrameworkCore.Applications;

[Collection(OgrenciOtomasyonSistemiTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<OgrenciOtomasyonSistemiEntityFrameworkCoreTestModule>
{

}
