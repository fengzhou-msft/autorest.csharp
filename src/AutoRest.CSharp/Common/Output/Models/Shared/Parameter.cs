// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

#pragma warning disable AD0001 // Doesn't understand record decleration, and the anaylizer throws an exception.
#pragma warning disable SA1649 // Doesn't understand record decleration, and the anaylizer throws an exception.

using AutoRest.CSharp.Generation.Types;
using AutoRest.CSharp.Input;

namespace AutoRest.CSharp.Output.Models.Shared
{
    internal record Parameter(string Name, string? Description, CSharpType Type, Constant? DefaultValue, bool ValidateNotNull, ParameterLocation In, bool IsApiVersionParameter = false);
}
