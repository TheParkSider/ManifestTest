using System;
using System.Management.Automation;

namespace DllCmdlet
{
    [Cmdlet(VerbsCommon.Get, "MessageFromDll")]
    [OutputType(typeof(string))]

    public class GetMessageFromDll : PSCmdlet
    {
        protected override void ProcessRecord()
        {
            WriteObject("Hi, DLL!");
        }
    }
}