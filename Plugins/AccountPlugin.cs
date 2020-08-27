using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// remember: Must assigned asseblemy to deploy it to dynamics
/// </summary>
namespace SF365.Plugins
{
    /// <summary>
    /// acts at the root
    /// </summary>
    [CrmPluginRegistration(MessageNameEnum.Update,
        "account",
        StageEnum.PreOperation,
        ExecutionModeEnum.Synchronous,
        "name",
        "Pre-Update Account",
        1000,
        IsolationModeEnum.Sandbox, // set to sandbox for dynamics 365 online
        Image1Name = "PreImage",
        Image1Type = ImageTypeEnum.PreImage,
        Image1Attributes ="name")]
    public class AccountPlugin : PluginBase
    {
        /// <summary>
        /// contructor is for someone logging in the background
        /// </summary>
        /// <param name="AccountPlugin"></param>
        public AccountPlugin() : base(typeof(AccountPlugin))
        {
        }

        /// <summary>
        /// plugin needs to be stateless, therefore everything we inside this function must be done with the local context
        /// </summary>
        /// <param name="localcontext"></param>
        protected override void ExecuteCrmPlugin(LocalPluginContext localcontext)
        {
            throw new InvalidPluginExecutionException("Working on it");
            // base.ExecuteCrmPlugin(localcontext);
        }
    }
}
