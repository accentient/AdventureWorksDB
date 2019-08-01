using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventureWorks.Tests
{
  [TestClass()]
  public class HumanResourcesTests : SqlDatabaseTestClass
  {

    public HumanResourcesTests()
    {
      InitializeComponent();
    }

    [TestInitialize()]
    public void TestInitialize()
    {
      base.InitializeTest();
    }
    [TestCleanup()]
    public void TestCleanup()
    {
      base.CleanupTest();
    }

    [TestMethod()]
    public void uspUpdateEmployeeHireInfo_Test()
    {
      SqlDatabaseTestActions testActions = this.uspUpdateEmployeeHireInfo_TestData;
      // Execute the pre-test script
      // 
      System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
      SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
      // Execute the test script
      // 
      System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
      SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
      // Execute the post-test script
      // 
      System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
      SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
    }
    [TestMethod()]
    public void uspUpdateEmployeeLogin_Test()
    {
      SqlDatabaseTestActions testActions = this.uspUpdateEmployeeLogin_TestData;
      // Execute the pre-test script
      // 
      System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
      SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
      try
      {
        // Execute the test script
        // 
        System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
        SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
      }
      finally
      {
        // Execute the post-test script
        // 
        System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
        SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
      }
    }
    [TestMethod()]
    public void uspUpdateEmployeePersonalInfo_Test()
    {
      SqlDatabaseTestActions testActions = this.uspUpdateEmployeePersonalInfo_TestData;
      // Execute the pre-test script
      // 
      System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
      SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
      try
      {
        // Execute the test script
        // 
        System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
        SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
      }
      finally
      {
        // Execute the post-test script
        // 
        System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
        SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
      }
    }



    #region Designer support code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction uspUpdateEmployeeHireInfo_Test_TestAction;
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HumanResourcesTests));
      Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction uspUpdateEmployeeLogin_Test_TestAction;
      Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction uspUpdateEmployeePersonalInfo_Test_TestAction;
      this.uspUpdateEmployeeHireInfo_TestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
      this.uspUpdateEmployeeLogin_TestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
      this.uspUpdateEmployeePersonalInfo_TestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
      uspUpdateEmployeeHireInfo_Test_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
      uspUpdateEmployeeLogin_Test_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
      uspUpdateEmployeePersonalInfo_Test_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
      // 
      // uspUpdateEmployeeHireInfo_TestData
      // 
      this.uspUpdateEmployeeHireInfo_TestData.PosttestAction = null;
      this.uspUpdateEmployeeHireInfo_TestData.PretestAction = null;
      this.uspUpdateEmployeeHireInfo_TestData.TestAction = uspUpdateEmployeeHireInfo_Test_TestAction;
      // 
      // uspUpdateEmployeeHireInfo_Test_TestAction
      // 
      resources.ApplyResources(uspUpdateEmployeeHireInfo_Test_TestAction, "uspUpdateEmployeeHireInfo_Test_TestAction");
      // 
      // uspUpdateEmployeeLogin_TestData
      // 
      this.uspUpdateEmployeeLogin_TestData.PosttestAction = null;
      this.uspUpdateEmployeeLogin_TestData.PretestAction = null;
      this.uspUpdateEmployeeLogin_TestData.TestAction = uspUpdateEmployeeLogin_Test_TestAction;
      // 
      // uspUpdateEmployeeLogin_Test_TestAction
      // 
      resources.ApplyResources(uspUpdateEmployeeLogin_Test_TestAction, "uspUpdateEmployeeLogin_Test_TestAction");
      // 
      // uspUpdateEmployeePersonalInfo_TestData
      // 
      this.uspUpdateEmployeePersonalInfo_TestData.PosttestAction = null;
      this.uspUpdateEmployeePersonalInfo_TestData.PretestAction = null;
      this.uspUpdateEmployeePersonalInfo_TestData.TestAction = uspUpdateEmployeePersonalInfo_Test_TestAction;
      // 
      // uspUpdateEmployeePersonalInfo_Test_TestAction
      // 
      resources.ApplyResources(uspUpdateEmployeePersonalInfo_Test_TestAction, "uspUpdateEmployeePersonalInfo_Test_TestAction");
    }

    #endregion


    #region Additional test attributes
    //
    // You can use the following additional attributes as you write your tests:
    //
    // Use ClassInitialize to run code before running the first test in the class
    // [ClassInitialize()]
    // public static void MyClassInitialize(TestContext testContext) { }
    //
    // Use ClassCleanup to run code after all tests in a class have run
    // [ClassCleanup()]
    // public static void MyClassCleanup() { }
    //
    #endregion

    private SqlDatabaseTestActions uspUpdateEmployeeHireInfo_TestData;
    private SqlDatabaseTestActions uspUpdateEmployeeLogin_TestData;
    private SqlDatabaseTestActions uspUpdateEmployeePersonalInfo_TestData;
  }
}
