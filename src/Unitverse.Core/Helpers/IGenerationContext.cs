﻿namespace Unitverse.Core.Helpers
{
    using System.Collections.Generic;
    using Microsoft.CodeAnalysis;
    using Unitverse.Core.Options;

    public interface IGenerationContext : IGenerationStatistics
    {
        IEnumerable<ITypeSymbol> EmittedTypes { get; }

        IGenerationOptions Options { get; }

        IEnumerable<string> GenericTypesVisited { get; }

        IDictionary<string, ITypeSymbol?> GenericTypes { get; }

        bool MocksUsed { get; set; }

        void AddEmittedType(ITypeSymbol typeInfo);

        void AddVisitedGenericType(string identifier);

        bool CurrentModelIsStatic { get; set; }

        SectionedMethodHandler CurrentMethod { get; set; }
    }
}