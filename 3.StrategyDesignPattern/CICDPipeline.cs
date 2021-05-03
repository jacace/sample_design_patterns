public class  CICDPipeline 
{

    IBuildStrategy strategy=null;

    public CICDPipeline(IBuildStrategy buildStrategy)
    {
        this.strategy=buildStrategy;
    }

    public void Build(){
        this.strategy.Build();
    }

}