using Amazon.CDK;
using Amazon.CDK.AWS.S3;
namespace Foo
{
    public class FooStack : Stack
    {
        internal FooStack(Construct scope, string id, IStackProps props = null) : base(scope, id, props)
        {
            new Bucket(this, "MyFirstBucket", new BucketProps
			    {

			    });
        }
    }
}
