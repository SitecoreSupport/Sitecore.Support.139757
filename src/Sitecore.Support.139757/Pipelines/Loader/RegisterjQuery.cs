namespace Sitecore.Support.Pipelines.Loader
{
    using Sitecore.Pipelines;
    using System.Web.UI;

    public class RegisterjQuery
    {
        public void Process(PipelineArgs args)
        {
            ScriptResourceDefinition definition = new ScriptResourceDefinition
            {
                #region Original code
                //Path = "~/sitecore/controls/shell/Controls/Lib/jQuery/jquery-1.10.2.min.js", 
                #endregion
                #region Modified code
                Path = "~/sitecore/shell/Controls/Lib/jQuery/jquery-1.10.2.min.js", 
                #endregion
                CdnPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.10.2.min.js",
                CdnDebugPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.10.2.js"
            };
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", definition);
        }
    }
}
