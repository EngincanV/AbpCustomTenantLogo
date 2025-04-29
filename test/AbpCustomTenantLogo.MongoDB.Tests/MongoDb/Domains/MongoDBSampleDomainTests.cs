using AbpCustomTenantLogo.Samples;
using Xunit;

namespace AbpCustomTenantLogo.MongoDB.Domains;

[Collection(AbpCustomTenantLogoTestConsts.CollectionDefinitionName)]
public class MongoDBSampleDomainTests : SampleDomainTests<AbpCustomTenantLogoMongoDbTestModule>
{

}
