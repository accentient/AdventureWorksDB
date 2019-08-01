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
  public class AuctionTests : SqlDatabaseTestClass
  {

    public AuctionTests()
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

    #region Designer support code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction CategoryInsert_Bikes_NotEmpty_TestAction;
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuctionTests));
      Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition notEmptyResultSetCondition1;
      Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExecutionTimeCondition executionTimeCondition1;
      Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction CategoryInsert_Bikes_NotEmpty_PretestAction;
      Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction CategoryInsert_Duplicate_Fails_TestAction;
      Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction CategoryInsert_Duplicate_Fails_PretestAction;
      Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction testInitializeAction;
      Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction uspCategoryDelete_Test_TestAction;
      Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction uspCategoryInsert_Test_TestAction;
      Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction uspCategorySelect_Test_TestAction;
      Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction uspListingDelete_Test_TestAction;
      Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction uspListingInsert_Test_TestAction;
      Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction uspListingSelect_Test_TestAction;
      Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction uspListingUpdate_Test_TestAction;
      this.CategoryInsert_Bikes_NotEmptyData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
      this.CategoryInsert_Duplicate_FailsData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
      this.uspCategoryDelete_TestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
      this.uspCategoryInsert_TestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
      this.uspCategorySelect_TestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
      this.uspListingDelete_TestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
      this.uspListingInsert_TestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
      this.uspListingSelect_TestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
      this.uspListingUpdate_TestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
      CategoryInsert_Bikes_NotEmpty_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
      notEmptyResultSetCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition();
      executionTimeCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExecutionTimeCondition();
      CategoryInsert_Bikes_NotEmpty_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
      CategoryInsert_Duplicate_Fails_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
      CategoryInsert_Duplicate_Fails_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
      testInitializeAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
      uspCategoryDelete_Test_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
      uspCategoryInsert_Test_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
      uspCategorySelect_Test_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
      uspListingDelete_Test_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
      uspListingInsert_Test_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
      uspListingSelect_Test_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
      uspListingUpdate_Test_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
      // 
      // CategoryInsert_Bikes_NotEmpty_TestAction
      // 
      CategoryInsert_Bikes_NotEmpty_TestAction.Conditions.Add(notEmptyResultSetCondition1);
      CategoryInsert_Bikes_NotEmpty_TestAction.Conditions.Add(executionTimeCondition1);
      resources.ApplyResources(CategoryInsert_Bikes_NotEmpty_TestAction, "CategoryInsert_Bikes_NotEmpty_TestAction");
      // 
      // notEmptyResultSetCondition1
      // 
      notEmptyResultSetCondition1.Enabled = true;
      notEmptyResultSetCondition1.Name = "notEmptyResultSetCondition1";
      notEmptyResultSetCondition1.ResultSet = 1;
      // 
      // executionTimeCondition1
      // 
      executionTimeCondition1.Enabled = true;
      executionTimeCondition1.ExecutionTime = System.TimeSpan.Parse("00:00:05");
      executionTimeCondition1.Name = "executionTimeCondition1";
      // 
      // CategoryInsert_Bikes_NotEmpty_PretestAction
      // 
      resources.ApplyResources(CategoryInsert_Bikes_NotEmpty_PretestAction, "CategoryInsert_Bikes_NotEmpty_PretestAction");
      // 
      // CategoryInsert_Duplicate_Fails_TestAction
      // 
      resources.ApplyResources(CategoryInsert_Duplicate_Fails_TestAction, "CategoryInsert_Duplicate_Fails_TestAction");
      // 
      // CategoryInsert_Duplicate_Fails_PretestAction
      // 
      resources.ApplyResources(CategoryInsert_Duplicate_Fails_PretestAction, "CategoryInsert_Duplicate_Fails_PretestAction");
      // 
      // testInitializeAction
      // 
      resources.ApplyResources(testInitializeAction, "testInitializeAction");
      // 
      // CategoryInsert_Bikes_NotEmptyData
      // 
      this.CategoryInsert_Bikes_NotEmptyData.PosttestAction = null;
      this.CategoryInsert_Bikes_NotEmptyData.PretestAction = CategoryInsert_Bikes_NotEmpty_PretestAction;
      this.CategoryInsert_Bikes_NotEmptyData.TestAction = CategoryInsert_Bikes_NotEmpty_TestAction;
      // 
      // CategoryInsert_Duplicate_FailsData
      // 
      this.CategoryInsert_Duplicate_FailsData.PosttestAction = null;
      this.CategoryInsert_Duplicate_FailsData.PretestAction = CategoryInsert_Duplicate_Fails_PretestAction;
      this.CategoryInsert_Duplicate_FailsData.TestAction = CategoryInsert_Duplicate_Fails_TestAction;
      // 
      // uspCategoryDelete_TestData
      // 
      this.uspCategoryDelete_TestData.PosttestAction = null;
      this.uspCategoryDelete_TestData.PretestAction = null;
      this.uspCategoryDelete_TestData.TestAction = uspCategoryDelete_Test_TestAction;
      // 
      // uspCategoryDelete_Test_TestAction
      // 
      resources.ApplyResources(uspCategoryDelete_Test_TestAction, "uspCategoryDelete_Test_TestAction");
      // 
      // uspCategoryInsert_TestData
      // 
      this.uspCategoryInsert_TestData.PosttestAction = null;
      this.uspCategoryInsert_TestData.PretestAction = null;
      this.uspCategoryInsert_TestData.TestAction = uspCategoryInsert_Test_TestAction;
      // 
      // uspCategoryInsert_Test_TestAction
      // 
      resources.ApplyResources(uspCategoryInsert_Test_TestAction, "uspCategoryInsert_Test_TestAction");
      // 
      // uspCategorySelect_TestData
      // 
      this.uspCategorySelect_TestData.PosttestAction = null;
      this.uspCategorySelect_TestData.PretestAction = null;
      this.uspCategorySelect_TestData.TestAction = uspCategorySelect_Test_TestAction;
      // 
      // uspCategorySelect_Test_TestAction
      // 
      resources.ApplyResources(uspCategorySelect_Test_TestAction, "uspCategorySelect_Test_TestAction");
      // 
      // uspListingDelete_TestData
      // 
      this.uspListingDelete_TestData.PosttestAction = null;
      this.uspListingDelete_TestData.PretestAction = null;
      this.uspListingDelete_TestData.TestAction = uspListingDelete_Test_TestAction;
      // 
      // uspListingDelete_Test_TestAction
      // 
      resources.ApplyResources(uspListingDelete_Test_TestAction, "uspListingDelete_Test_TestAction");
      // 
      // uspListingInsert_TestData
      // 
      this.uspListingInsert_TestData.PosttestAction = null;
      this.uspListingInsert_TestData.PretestAction = null;
      this.uspListingInsert_TestData.TestAction = uspListingInsert_Test_TestAction;
      // 
      // uspListingInsert_Test_TestAction
      // 
      resources.ApplyResources(uspListingInsert_Test_TestAction, "uspListingInsert_Test_TestAction");
      // 
      // uspListingSelect_TestData
      // 
      this.uspListingSelect_TestData.PosttestAction = null;
      this.uspListingSelect_TestData.PretestAction = null;
      this.uspListingSelect_TestData.TestAction = uspListingSelect_Test_TestAction;
      // 
      // uspListingSelect_Test_TestAction
      // 
      resources.ApplyResources(uspListingSelect_Test_TestAction, "uspListingSelect_Test_TestAction");
      // 
      // uspListingUpdate_TestData
      // 
      this.uspListingUpdate_TestData.PosttestAction = null;
      this.uspListingUpdate_TestData.PretestAction = null;
      this.uspListingUpdate_TestData.TestAction = uspListingUpdate_Test_TestAction;
      // 
      // uspListingUpdate_Test_TestAction
      // 
      resources.ApplyResources(uspListingUpdate_Test_TestAction, "uspListingUpdate_Test_TestAction");
      // 
      // AuctionTests
      // 
      this.TestInitializeAction = testInitializeAction;
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

    [TestMethod()]
    public void CategoryInsert_Bikes_NotEmpty()
    {
      SqlDatabaseTestActions testActions = this.CategoryInsert_Bikes_NotEmptyData;
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
    [TestMethod(), ExpectedSqlException(Severity = 16, MatchFirstError = false, State = 1)]
    public void CategoryInsert_Duplicate_Fails()
    {
      SqlDatabaseTestActions testActions = this.CategoryInsert_Duplicate_FailsData;
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
    public void uspCategoryDelete_Test()
    {
      SqlDatabaseTestActions testActions = this.uspCategoryDelete_TestData;
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
    public void uspCategoryInsert_Test()
    {
      SqlDatabaseTestActions testActions = this.uspCategoryInsert_TestData;
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
    public void uspCategorySelect_Test()
    {
      SqlDatabaseTestActions testActions = this.uspCategorySelect_TestData;
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
    public void uspListingDelete_Test()
    {
      SqlDatabaseTestActions testActions = this.uspListingDelete_TestData;
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
    public void uspListingInsert_Test()
    {
      SqlDatabaseTestActions testActions = this.uspListingInsert_TestData;
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
    public void uspListingSelect_Test()
    {
      SqlDatabaseTestActions testActions = this.uspListingSelect_TestData;
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
    public void uspListingUpdate_Test()
    {
      SqlDatabaseTestActions testActions = this.uspListingUpdate_TestData;
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








    private SqlDatabaseTestActions CategoryInsert_Bikes_NotEmptyData;
    private SqlDatabaseTestActions CategoryInsert_Duplicate_FailsData;
    private SqlDatabaseTestActions uspCategoryDelete_TestData;
    private SqlDatabaseTestActions uspCategoryInsert_TestData;
    private SqlDatabaseTestActions uspCategorySelect_TestData;
    private SqlDatabaseTestActions uspListingDelete_TestData;
    private SqlDatabaseTestActions uspListingInsert_TestData;
    private SqlDatabaseTestActions uspListingSelect_TestData;
    private SqlDatabaseTestActions uspListingUpdate_TestData;
  }
}
