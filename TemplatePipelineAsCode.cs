using System;
using System.Threading.Tasks;

namespace sample_design_patterns
{

    //This class abstracts a simplified Pipeline As Code for any nodejs app
    public abstract class TemplatePipelineAsCode
    {

        //In this Step usually the clean-up, cred setup and git clone takes place
        public abstract void Prepare(String repoApiToken, String repoURL, String branch);

        //In this function the correct compiler is used, e.g.: tsc or CoffeeScript 
        public abstract void BuildNode();

        //In this fucntion typically a static analysis or linter takes place
        public abstract void LintSource();

        //In this step static policies can be verified, e.g.: with OPA
        public abstract void RunPolicyAsCode();

        public abstract void PackageAssets();

        public abstract void Deploy();

        public abstract void UnitTest();

        //Depending on the domain this migth include BDD with behave or ServerSpec, InSpec, etc
        public abstract void IntegrationTest();

        
        //In this step we typically metadata in a supply chain like Grafeas
        public abstract void RecordMetadata();

        public abstract void CreateRelease();

        public abstract void CryptoSignAssets();

        public abstract void Destroy();
        
        public void Build(String repoApiToken, String repoURL, String branch)
        {
            Prepare(repoApiToken, repoURL, branch);

            Task linting = Task.Run(() => LintSource());
            Task policing = Task.Run(() => RunPolicyAsCode());
            Task.WaitAll(linting, policing);

            BuildNode();
            UnitTest();
            PackageAssets();
            CryptoSignAssets();
            Deploy();
            IntegrationTest();

            Task release = Task.Run(() => CreateRelease());
            Task supplyChain = Task.Run(() => RecordMetadata());
            Task.WaitAll(release, supplyChain);

            Destroy();
        }

    }
}
