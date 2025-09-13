using OOS.OgrenciOtomasyonSistemi.Samples;
using Xunit;

namespace OOS.OgrenciOtomasyonSistemi.EntityFrameworkCore.Domains;

[Collection(OgrenciOtomasyonSistemiTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<OgrenciOtomasyonSistemiEntityFrameworkCoreTestModule>
{

}
