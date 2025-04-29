using AbpCustomTenantLogo.MongoDB;
using AbpCustomTenantLogo.Samples;
using Xunit;

namespace AbpCustomTenantLogo.MongoDb.Applications;

[Collection(AbpCustomTenantLogoTestConsts.CollectionDefinitionName)]
public class MongoDBSampleAppServiceTests : SampleAppServiceTests<AbpCustomTenantLogoMongoDbTestModule>
{

}
