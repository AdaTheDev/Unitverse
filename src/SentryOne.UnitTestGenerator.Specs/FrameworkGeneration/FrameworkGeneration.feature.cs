// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SentryOne.UnitTestGenerator.Specs.FrameworkGeneration
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Framework Generation")]
    public partial class FrameworkGenerationFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "FrameworkGeneration.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Framework Generation", "\tI am checking ITestFramework for different frameworks", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Framework Generation Test - AssertThrows")]
        [NUnit.Framework.TestCaseAttribute("MsTest", "Assert.ThrowsException<ArgumentNullException>(() => Generate.Arguments(default(st" +
            "ring[])));", null)]
        [NUnit.Framework.TestCaseAttribute("NUnit3", "Assert.Throws<ArgumentNullException>(() => Generate.Arguments(default(string[])))" +
            ";", null)]
        [NUnit.Framework.TestCaseAttribute("XUnit", "Assert.Throws<ArgumentNullException>(() => Generate.Arguments(default(string[])))" +
            ";", null)]
        public virtual void FrameworkGenerationTest_AssertThrows(string framework, string statement, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Framework Generation Test - AssertThrows", null, exampleTags);
#line 4
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
#line 5
 testRunner.Given("I have a class defined as", @"using System;
using System.Collections.Generic;
using System.Linq;

public static class Generate
{
public static IList<string> Test1(out IEnumerable<string> testing)
{
testing = 1
}

public static IList<string> Test2(ref IEnumerable<string> testing)
{
testing = 1
}

  public static IList<string> Arguments(params string[] expressions)
  {
      return ArgumentList(expressions);
  }

  public static IList<string> Arguments(IEnumerable<string> expressions)
  {
      return ArgumentList(expressions);
  }

  private static IList<string> ArgumentList(params string[] expressions)
  {
      return ArgumentList(expressions.AsEnumerable());
  }

  private static IList<string> ArgumentList(IEnumerable<string> expressions)
  {
      var tokens = new List<string>();
      foreach (var expression in expressions)
      {
          if (tokens.Count > 0)
          {
              tokens.Add("","");
          }

          tokens.Add(expression);
      }

      return tokens;
  }
}", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 55
 testRunner.And(string.Format("I set my test framework to \'{0}\'", framework), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
 testRunner.And("I set my mock framework to \'Moq\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
 testRunner.When("I generate tests for the method using the strategy \'NullParameterCheckMethodGener" +
                    "ationStrategy\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 58
 testRunner.Then("I expect a method called \'CannotCallArgumentsWithArrayOfStringWithNullExpressions" +
                    "\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 59
  testRunner.And(string.Format("I expect it to contain the statement \'{0}\'", statement), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Framework Generation Test - AssertFail")]
        [NUnit.Framework.TestCaseAttribute("MsTest", "Assert.Fail(\"Create or modify test\");", null)]
        [NUnit.Framework.TestCaseAttribute("NUnit3", "Assert.Fail(\"Create or modify test\");", null)]
        [NUnit.Framework.TestCaseAttribute("XUnit", "Assert.True(false, \"Create or modify test\");", null)]
        public virtual void FrameworkGenerationTest_AssertFail(string framework, string statement, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Framework Generation Test - AssertFail", null, exampleTags);
#line 67
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
#line 68
 testRunner.Given("I have a class defined as", @"public class TestClass
{
public void Test1(out string tester)
{
tester = ""test""
}

public void Test2(ref string tester)
{
tester = ""test""
}

  public TestClass(string stringProp, ITest iTest)
  {

  }

  public TestClass(int? nullableIntProp, ITest iTest)
  {

  }

  public TestClass(int thisIsAProperty, ITest iTest)
  {

  }

  public void ThisIsAMethod(string methodName, int methodValue)
  {
   System.Console.WriteLine(""Testing this"");
  }

  public string WillReturnAString()
  {
      return ""Hello"";
  }

  private string _thisIsAString = string.Empty;
  public string ThisIsAWriteOnlyString { set { _thisIsAString = value; }}

  public int ThisIsAProperty { get;set;}

  public ITest GetITest { get; }

  public TestClass ThisClass {get;set;}
}", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 117
 testRunner.And(string.Format("I set my test framework to \'{0}\'", framework), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 118
 testRunner.And("I set my mock framework to \'Moq\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 119
 testRunner.When("I generate tests for the method using the strategy \'CanCallMethodGenerationStrate" +
                    "gy\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 120
 testRunner.Then("I expect a method called \'CanCallWillReturnAString\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 121
  testRunner.And(string.Format("I expect it to contain the statement \'{0}\'", statement), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Framework Generation Test - AssertEqual")]
        [NUnit.Framework.TestCaseAttribute("MsTest", "Assert.AreEqual(0, baseValue.CompareTo(equalToBaseValue));", null)]
        [NUnit.Framework.TestCaseAttribute("NUnit3", "Assert.That(baseValue.CompareTo(equalToBaseValue), Is.EqualTo(0));", null)]
        [NUnit.Framework.TestCaseAttribute("XUnit", "Assert.Equal(0, baseValue.CompareTo(equalToBaseValue));", null)]
        public virtual void FrameworkGenerationTest_AssertEqual(string framework, string statement, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Framework Generation Test - AssertEqual", null, exampleTags);
#line 129
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
#line 130
 testRunner.Given("I have a class defined as", @"using System;

namespace AssemblyCore
{
public class TestComparableGeneric : IComparable<TestComparableGeneric>, IComparable<int>, IComparable
{
public TestComparableGeneric(int value)
{
	Value = value;
}

public int Value { get; }

public int CompareTo(TestComparableGeneric obj)
{
	if (obj == null)
	{
		throw new ArgumentNullException();
	}

	return Value.CompareTo(obj.Value);
}

public int CompareTo(int value)
{
	return Value.CompareTo(value);
}

public int CompareTo(object obj)
{
	if (obj is null)
	{
		throw new ArgumentNullException(nameof(obj));
	}

	return Value.CompareTo(obj);
}
}
}", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 172
 testRunner.And(string.Format("I set my test framework to \'{0}\'", framework), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 173
 testRunner.And("I set my mock framework to \'Moq\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 174
 testRunner.When("I generate unit tests for the class using strategy \'ComparableGenerationStrategy\'" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 175
 testRunner.Then("I expect a method called \'ImplementsIComparable\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 176
  testRunner.And(string.Format("I expect it to contain the statement \'{0}\'", statement), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Framework Generation Test - AssertLesser")]
        [NUnit.Framework.TestCaseAttribute("MsTest", "Assert.IsTrue(baseValue.CompareTo(greaterThanBaseValue) < 0);", null)]
        [NUnit.Framework.TestCaseAttribute("NUnit3", "Assert.That(baseValue.CompareTo(greaterThanBaseValue), Is.LessThan(0));", null)]
        [NUnit.Framework.TestCaseAttribute("XUnit", "Assert.True(baseValue.CompareTo(greaterThanBaseValue) < 0);", null)]
        public virtual void FrameworkGenerationTest_AssertLesser(string framework, string statement, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Framework Generation Test - AssertLesser", null, exampleTags);
#line 184
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
#line 185
 testRunner.Given("I have a class defined as", @"using System;

namespace AssemblyCore
{
public class TestComparableGeneric : IComparable<TestComparableGeneric>, IComparable<int>, IComparable
{
public TestComparableGeneric(int value)
{
	Value = value;
}

public int Value { get; }

public int CompareTo(TestComparableGeneric obj)
{
	if (obj == null)
	{
		throw new ArgumentNullException();
	}

	return Value.CompareTo(obj.Value);
}

public int CompareTo(int value)
{
	return Value.CompareTo(value);
}

public int CompareTo(object obj)
{
	if (obj is null)
	{
		throw new ArgumentNullException(nameof(obj));
	}

	return Value.CompareTo(obj);
}
}
}", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 227
 testRunner.And(string.Format("I set my test framework to \'{0}\'", framework), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 228
 testRunner.And("I set my mock framework to \'Moq\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 229
 testRunner.When("I generate unit tests for the class using strategy \'ComparableGenerationStrategy\'" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 230
 testRunner.Then("I expect a method called \'ImplementsIComparable\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 231
  testRunner.And(string.Format("I expect it to contain the statement \'{0}\'", statement), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Framework Generation Test - AssertGreater")]
        [NUnit.Framework.TestCaseAttribute("MsTest", "Assert.IsTrue(greaterThanBaseValue.CompareTo(baseValue) > 0);", null)]
        [NUnit.Framework.TestCaseAttribute("NUnit3", "Assert.That(greaterThanBaseValue.CompareTo(baseValue), Is.GreaterThan(0));", null)]
        [NUnit.Framework.TestCaseAttribute("XUnit", "Assert.True(greaterThanBaseValue.CompareTo(baseValue) > 0);", null)]
        public virtual void FrameworkGenerationTest_AssertGreater(string framework, string statement, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Framework Generation Test - AssertGreater", null, exampleTags);
#line 239
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
#line 240
 testRunner.Given("I have a class defined as", @"using System;

namespace AssemblyCore
{
public class TestComparableGeneric : IComparable<TestComparableGeneric>, IComparable<int>, IComparable
{
public TestComparableGeneric(int value)
{
	Value = value;
}

public int Value { get; }

public int CompareTo(TestComparableGeneric obj)
{
	if (obj == null)
	{
		throw new ArgumentNullException();
	}

	return Value.CompareTo(obj.Value);
}

public int CompareTo(int value)
{
	return Value.CompareTo(value);
}

public int CompareTo(object obj)
{
	if (obj is null)
	{
		throw new ArgumentNullException(nameof(obj));
	}

	return Value.CompareTo(obj);
}
}
}
", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 283
 testRunner.And(string.Format("I set my test framework to \'{0}\'", framework), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 284
 testRunner.And("I set my mock framework to \'Moq\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 285
 testRunner.When("I generate unit tests for the class using strategy \'ComparableGenerationStrategy\'" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 286
 testRunner.Then("I expect a method called \'ImplementsIComparable\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 287
  testRunner.And(string.Format("I expect it to contain the statement \'{0}\'", statement), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Framework Generation Test - AssertNotNull")]
        [NUnit.Framework.TestCaseAttribute("MsTest", "Assert.IsNotNull(instance);", null)]
        [NUnit.Framework.TestCaseAttribute("NUnit3", "Assert.That(instance, Is.Not.Null);", null)]
        [NUnit.Framework.TestCaseAttribute("XUnit", "Assert.NotNull(instance);", null)]
        public virtual void FrameworkGenerationTest_AssertNotNull(string framework, string statement, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Framework Generation Test - AssertNotNull", null, exampleTags);
#line 295
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
#line 296
 testRunner.Given("I have a class defined as", @"using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Collections;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
  public class Form1 : IEnumerable<int>
  {
      public Form1()
      {
           
      }

public IEnumerator<int> GetEnumerator()
      {
          return Enumerable.Empty<int>().GetEnumerator();
      }

      IEnumerator IEnumerable.GetEnumerator()
      {
          return GetEnumerator();
      }
  }
}", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 327
 testRunner.And(string.Format("I set my test framework to \'{0}\'", framework), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 328
 testRunner.And("I set my mock framework to \'Moq\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 329
 testRunner.When("I generate unit tests for the class using strategy \'CanConstructSingleConstructor" +
                    "GenerationStrategy\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 330
 testRunner.Then("I expect a method called \'CanConstruct\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 331
  testRunner.And(string.Format("I expect it to contain the statement \'{0}\'", statement), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Framework Generation Test - AssertIsInstanceOf")]
        [NUnit.Framework.TestCaseAttribute("MsTest", "Assert.IsInstanceOfType(_testClass.GetITest, typeof(ITest));", null)]
        [NUnit.Framework.TestCaseAttribute("NUnit3", "Assert.That(_testClass.GetITest, Is.InstanceOf<ITest>());", null)]
        [NUnit.Framework.TestCaseAttribute("XUnit", "Assert.IsType<ITest>(_testClass.GetITest);", null)]
        public virtual void FrameworkGenerationTest_AssertIsInstanceOf(string framework, string statement, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Framework Generation Test - AssertIsInstanceOf", null, exampleTags);
#line 339
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
#line 340
 testRunner.Given("I have a class defined as", @"public class TestClass
{
public void Test1(out string tester)
{
tester = ""test""
}

public void Test2(ref string tester)
{
tester = ""test""
}

  public TestClass(string stringProp, ITest iTest)
  {

  }

  public TestClass(int? nullableIntProp, ITest iTest)
  {

  }

  public TestClass(int thisIsAProperty, ITest iTest)
  {

  }

  public void ThisIsAMethod(string methodName, int methodValue)
  {
   System.Console.WriteLine(""Testing this"");
  }

  public string WillReturnAString()
  {
      return ""Hello"";
  }

  private string _thisIsAString = string.Empty;
  public string ThisIsAWriteOnlyString { set { _thisIsAString = value; }}

  public int ThisIsAProperty { get;set;}

  public ITest GetITest { get; }

  public TestClass ThisClass {get;set;}
}", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 389
 testRunner.And(string.Format("I set my test framework to \'{0}\'", framework), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 390
 testRunner.And("I set my mock framework to \'Moq\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 391
 testRunner.When("I generate tests for the property using the strategy \'ReadOnlyPropertyGenerationS" +
                    "trategy\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 392
 testRunner.Then("I expect a method called \'CanGetGetITest\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 393
  testRunner.And(string.Format("I expect it to contain the statement \'{0}\'", statement), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Framework Generation Test - AssertThrowsAsync")]
        [NUnit.Framework.TestCaseAttribute("MsTest", "Assert.ThrowsExceptionAsync<ArgumentNullException>(() => _testClass.ThisIsAnAsync" +
            "Method(value, {{{AnyInteger}}}));", null)]
        [NUnit.Framework.TestCaseAttribute("NUnit3", "Assert.ThrowsAsync<ArgumentNullException>(() => _testClass.ThisIsAnAsyncMethod(va" +
            "lue, {{{AnyInteger}}}));", null)]
        [NUnit.Framework.TestCaseAttribute("XUnit", "Assert.ThrowsAsync<ArgumentNullException>(() => _testClass.ThisIsAnAsyncMethod(va" +
            "lue, {{{AnyInteger}}}));", null)]
        public virtual void FrameworkGenerationTest_AssertThrowsAsync(string framework, string statement, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Framework Generation Test - AssertThrowsAsync", null, exampleTags);
#line 401
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
#line 402
 testRunner.Given("I have a class defined as", @"namespace TestNamespace.SubNameSpace
{
  public class TestClass
  {
   public System.Threading.Tasks.Task ThisIsAnAsyncMethod(string methodName, int methodValue)
   {
    System.Console.WriteLine(""Testing this"");
	return System.Threading.Tasks.Task.CompletedTask;
   }

   public System.Threading.Tasks.Task<int> ThisIsAnAsyncMethodWithReturnType(string methodName, int methodValue)
   {
    System.Console.WriteLine(""Testing this"");
	return System.Threading.Tasks.Task.FromResult(0);
   }
  }
}", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 422
 testRunner.And(string.Format("I set my test framework to \'{0}\'", framework), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 423
 testRunner.And("I set my mock framework to \'moq\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 424
 testRunner.When("I generate tests for the method using the strategy \'StringParameterCheckMethodGen" +
                    "erationStrategy\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 425
 testRunner.Then("I expect a method called \'CannotCallThisIsAnAsyncMethodWithInvalidMethodName\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 426
  testRunner.And(string.Format("I expect it to contain a statement like \'{0}\'", statement), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
