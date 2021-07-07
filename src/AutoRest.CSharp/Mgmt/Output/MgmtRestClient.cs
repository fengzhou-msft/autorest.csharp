// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Linq;
using AutoRest.CSharp.Input;
using AutoRest.CSharp.Mgmt.AutoRest;
using AutoRest.CSharp.Output.Models;
using AutoRest.CSharp.Output.Models.Requests;
using AutoRest.CSharp.Output.Models.Types;

namespace AutoRest.CSharp.Mgmt.Output
{
    internal class MgmtRestClient : RestClient
    {
        public MgmtRestClient(OperationGroup operationGroup, BuildContext<MgmtOutputLibrary> context)
            : base(operationGroup, context, operationGroup.Language.Default.Name)
        {
        }

        public bool IsByIdMethod(RestClientMethod method)
        {
            var request = method.Operation?.Requests.FirstOrDefault(r => r.Protocol.Http is HttpRequest);
            return request != null && method.Parameters.Count() > 0 && $"/{{{method.Parameters[0].Name}}}".Equals(((HttpRequest)request.Protocol.Http!).Path);
        }
    }
}
