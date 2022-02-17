﻿namespace Unitverse.Specs
{
    using Unitverse.Core.Options;

    // ENHANCE - add fluent assertions to specs
    public class GenerationOptions : IGenerationOptions
    {
        public GenerationOptions(TestFrameworkTypes testFramework, MockingFrameworkType mockFramework)
        {
            FrameworkType = testFramework;
            MockingFrameworkType = mockFramework;
        }

        public static IUnitTestGeneratorOptions Get(TestFrameworkTypes testFramework, MockingFrameworkType mockFramework)
        {
            return new UnitTestGeneratorOptions(new GenerationOptions(testFramework, mockFramework), new DefaultNamingOptions(), new DefaultStrategyOptions(), false);
        }

        public TestFrameworkTypes FrameworkType { get; }
        public MockingFrameworkType MockingFrameworkType { get; }
        public bool CreateProjectAutomatically { get; } = true;
        public bool AddReferencesAutomatically { get; } = true;
        public bool AllowGenerationWithoutTargetProject { get; } = true;
        public string TestProjectNaming { get; } = "{0}.Tests";
        public string TestFileNaming { get; } = "{0}Tests";
        public string TestTypeNaming { get; } = "{0}Tests";

        public bool UseFluentAssertions { get; }

        public bool AutoDetectFrameworkTypes { get; }

        public bool EmitUsingsOutsideNamespace { get; }

        public bool PartialGenerationAllowed { get; } = false;

        public bool EmitTestsForInternals { get; } = false;

        public bool AutomaticallyConfigureMocks { get; } = true;

        public bool EmitSubclassForProtectedMethods { get; } = true;

        public string ArrangeComment => "Arrange";

        public string ActComment => "Act";

        public string AssertComment => "Assert";
    }
}