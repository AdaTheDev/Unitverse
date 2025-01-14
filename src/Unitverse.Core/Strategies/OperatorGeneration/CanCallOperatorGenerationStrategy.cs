﻿namespace Unitverse.Core.Strategies.OperatorGeneration
{
    using System;
    using System.Collections.Generic;
    using Microsoft.CodeAnalysis.CSharp;
    using Unitverse.Core.Frameworks;
    using Unitverse.Core.Helpers;
    using Unitverse.Core.Models;
    using Unitverse.Core.Options;
    using Unitverse.Core.Resources;

    public class CanCallOperatorGenerationStrategy : IGenerationStrategy<IOperatorModel>
    {
        private readonly IFrameworkSet _frameworkSet;

        public CanCallOperatorGenerationStrategy(IFrameworkSet frameworkSet)
        {
            _frameworkSet = frameworkSet ?? throw new ArgumentNullException(nameof(frameworkSet));
        }

        public bool IsExclusive => false;

        public int Priority => 1;

        public Func<IStrategyOptions, bool> IsEnabled => x => x.OperatorChecksAreEnabled;

        public bool CanHandle(IOperatorModel method, ClassModel model)
        {
            if (method is null)
            {
                throw new ArgumentNullException(nameof(method));
            }

            if (model is null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            return true;
        }

        public IEnumerable<SectionedMethodHandler> Create(IOperatorModel method, ClassModel model, NamingContext namingContext)
        {
            if (method is null)
            {
                throw new ArgumentNullException(nameof(method));
            }

            if (model is null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            var generatedMethod = _frameworkSet.CreateTestMethod(_frameworkSet.NamingProvider.CanCallOperator, namingContext, false, model.IsStatic, "Checks that the " + method.Name + " operator functions correctly.");

            var paramExpressions = new List<CSharpSyntaxNode>();

            foreach (var parameter in method.Parameters)
            {
                var defaultAssignmentValue = AssignmentValueHelper.GetDefaultAssignmentValue(parameter.TypeInfo, model.SemanticModel, _frameworkSet);

                if (parameter.TypeInfo.Type != null)
                {
                    generatedMethod.Arrange(Generate.VariableDeclaration(parameter.TypeInfo.Type, _frameworkSet, parameter.Name, defaultAssignmentValue));
                }

                paramExpressions.Add(SyntaxFactory.IdentifierName(parameter.Name));
            }

            var methodCall = method.Invoke(model, false, _frameworkSet, paramExpressions.ToArray());

            if (methodCall != null)
            {
                var bodyStatement = Generate.ImplicitlyTypedVariableDeclaration("result", methodCall);

                generatedMethod.Act(bodyStatement);
            }

            generatedMethod.Assert(_frameworkSet.AssertionFramework.AssertFail(Strings.PlaceholderAssertionMessage));

            yield return generatedMethod;
        }
    }
}