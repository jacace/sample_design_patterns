using System;

namespace sample_design_patterns
{

    //This class implements a Commodity NodeJS Pipeline As Code
    public class CommodityNodejsPipelineAsCode : TemplatePipelineAsCode
    {
        //In this Step usually the clean-up, cred setup and git clone takes place
        public override void Build()
        {
            throw new NotImplementedException();
        }

        public override void CreateRelease()
        {
            throw new NotImplementedException();
        }

        public override void CryptoSignAssets()
        {
            throw new NotImplementedException();
        }

        public override void Deploy()
        {
            throw new NotImplementedException();
        }

        public override void Destroy()
        {
            throw new NotImplementedException();
        }

        public override void IntegrationTest()
        {
            throw new NotImplementedException();
        }

        public override void LintSource()
        {
            throw new NotImplementedException();
        }

        public override void PackageAssets()
        {
            throw new NotImplementedException();
        }

        public override void Prepare(string repoApiToken, string repoURL, string branch)
        {
            throw new NotImplementedException();
        }

        public override void PublishAPIm()
        {
            throw new NotImplementedException();
        }

        public override void RecordMetadata()
        {
            throw new NotImplementedException();
        }

        public override void RunPolicyAsCode()
        {
            throw new NotImplementedException();
        }

        public override void UnitTest()
        {
            throw new NotImplementedException();
        }
    }
}
