// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Linq;
using AutoRest.CSharp.Generation.Types;
using AutoRest.CSharp.Input;
using AutoRest.CSharp.Utilities;

namespace AutoRest.CSharp.Output.Models.Types
{
    internal class LowLevelOutputLibrary : OutputLibrary
    {
        private readonly CodeModel _codeModel;
        private readonly BuildContext<LowLevelOutputLibrary> _context;
        private readonly CachedDictionary<OperationGroup, LowLevelRestClient> _restClients;

        public LowLevelOutputLibrary(CodeModel codeModel, BuildContext<LowLevelOutputLibrary> context) : base(codeModel, context)
        {
            _codeModel = codeModel;
            _context = context;
            UpdateListMethodNames();
            _restClients = new CachedDictionary<OperationGroup, LowLevelRestClient>(EnsureRestClients);
        }

        public IEnumerable<LowLevelRestClient> RestClients => _restClients.Values;
        private Dictionary<OperationGroup, LowLevelRestClient> EnsureRestClients()
        {
            var restClients = new Dictionary<OperationGroup, LowLevelRestClient>();
            foreach (var operationGroup in _codeModel.OperationGroups)
            {
                restClients.Add(operationGroup, new LowLevelRestClient(operationGroup, _context));
            }

            return restClients;
        }

        private void UpdateListMethodNames()
        {
            foreach (var operationGroup in _codeModel.OperationGroups)
            {
                foreach (var operation in operationGroup.Operations)
                {
                    var curName = operation.Language.Default.Name;
                    if (curName.Equals("List") || curName.Equals("ListAll"))
                    {
                        operation.Language.Default.Name = "GetAll";
                    }
                    else if (curName.StartsWith("ListBy"))
                    {
                        operation.Language.Default.Name = curName.Replace("List", "GetAll");
                    }
                    else if (curName.StartsWith("List"))
                    {
                        var lastNoun = curName.SplitByCamelCase().LastOrDefault();
                        if (lastNoun != null)
                            curName = curName.Replace(lastNoun, lastNoun.ToPlural(inputIsKnownToBeSingular: false));
                        operation.Language.Default.Name = curName.Replace("List", "Get");
                    }
                }
            }
        }

        public override CSharpType FindTypeForSchema(Schema schema)
        {
            switch (schema.Type)
            {
                case AllSchemaTypes.Choice:
                    return _context.TypeFactory.CreateType(((ChoiceSchema)schema).ChoiceType, false);
                case AllSchemaTypes.SealedChoice:
                    return _context.TypeFactory.CreateType(((SealedChoiceSchema)schema).ChoiceType, false);
                default:
                    // This is technically invalid behavior, we are hitting this in generating responses we throw away.
                    // https://github.com/Azure/autorest.csharp/issues/1108
                    // throw new InvalidOperationException($"FindTypeForSchema of invalid schema {schema.Name} in LowLevelOutputLibrary");
                    return new CSharpType(typeof(object));
            }
        }

        public override CSharpType? FindTypeByName(string originalName) => null;
    }
}
