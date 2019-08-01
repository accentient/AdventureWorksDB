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
  public class dboTests : SqlDatabaseTestClass
  {

    public dboTests()
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
    public void uspGetBillOfMaterials_Test()
    {
      SqlDatabaseTestActions testActions = this.uspGetBillOfMaterials_TestData;
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
    public void uspGetEmployeeManagers_Test()
    {
      SqlDatabaseTestActions testActions = this.uspGetEmployeeManagers_TestData;
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
    public void uspGetManagerEmployees_Test()
    {
      SqlDatabaseTestActions testActions = this.uspGetManagerEmployees_TestData;
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
    public void uspGetWhereUsedProductID_Test()
    {
      SqlDatabaseTestActions testActions = this.uspGetWhereUsedProductID_TestData;
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
    public void useLogError_Test()
    {
      SqlDatabaseTestActions testActions = this.useLogError_TestData;
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
    public void usePrintError_Test()
    {
      SqlDatabaseTestActions testActions = this.usePrintError_TestData;
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
      Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction uspGetBillOfMaterials_Test_TestAction;
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dboTests));
      Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction uspGetEmployeeManagers_Test_TestAction;
      Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction uspGetManagerEmployees_Test_TestAction;
      Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction uspGetWhereUsedProductID_Test_TestAction;
      Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction useLogError_Test_TestAction;
      Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction usePrintError_Test_TestAction;
      this.uspGetBillOfMaterials_TestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
      this.uspGetEmployeeManagers_TestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
      this.uspGetManagerEmployees_TestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
      this.uspGetWhereUsedProductID_TestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
      this.useLogError_TestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
      this.usePrintError_TestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
      uspGetBillOfMaterials_Test_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
      uspGetEmployeeManagers_Test_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
      uspGetManagerEmployees_Test_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
      uspGetWhereUsedProductID_Test_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
      useLogError_Test_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
      usePrintError_Test_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
      // 
      // uspGetBillOfMaterials_TestData
      // 
      this.uspGetBillOfMaterials_TestData.PosttestAction = null;
      this.uspGetBillOfMaterials_TestData.PretestAction = null;
      this.uspGetBillOfMaterials_TestData.TestAction = uspGetBillOfMaterials_Test_TestAction;
      // 
      // uspGetBillOfMaterials_Test_TestAction
      // 
      resources.ApplyResources(uspGetBillOfMaterials_Test_TestAction, "uspGetBillOfMaterials_Test_TestAction");
      // 
      // uspGetEmployeeManagers_TestData
      // 
      this.uspGetEmployeeManagers_TestData.PosttestAction = null;
      this.uspGetEmployeeManagers_TestData.PretestAction = null;
      this.uspGetEmployeeManagers_TestData.TestAction = uspGetEmployeeManagers_Test_TestAction;
      // 
      // uspGetEmployeeManagers_Test_TestAction
      // 
      resources.ApplyResources(uspGetEmployeeManagers_Test_TestAction, "uspGetEmployeeManagers_Test_TestAction");
      // 
      // uspGetManagerEmployees_TestData
      // 
      this.uspGetManagerEmployees_TestData.PosttestAction = null;
      this.uspGetManagerEmployees_TestData.PretestAction = null;
      this.uspGetManagerEmployees_TestData.TestAction = uspGetManagerEmployees_Test_TestAction;
      // 
      // uspGetManagerEmployees_Test_TestAction
      // 
      resources.ApplyResources(uspGetManagerEmployees_Test_TestAction, "uspGetManagerEmployees_Test_TestAction");
      // 
      // uspGetWhereUsedProductID_TestData
      // 
      this.uspGetWhereUsedProductID_TestData.PosttestAction = null;
      this.uspGetWhereUsedProductID_TestData.PretestAction = null;
      this.uspGetWhereUsedProductID_TestData.TestAction = uspGetWhereUsedProductID_Test_TestAction;
      // 
      // uspGetWhereUsedProductID_Test_TestAction
      // 
      resources.ApplyResources(uspGetWhereUsedProductID_Test_TestAction, "uspGetWhereUsedProductID_Test_TestAction");
      // 
      // useLogError_TestData
      // 
      this.useLogError_TestData.PosttestAction = null;
      this.useLogError_TestData.PretestAction = null;
      this.useLogError_TestData.TestAction = useLogError_Test_TestAction;
      // 
      // useLogError_Test_TestAction
      // 
      resources.ApplyResources(useLogError_Test_TestAction, "useLogError_Test_TestAction");
      // 
      // usePrintError_TestData
      // 
      this.usePrintError_TestData.PosttestAction = null;
      this.usePrintError_TestData.PretestAction = null;
      this.usePrintError_TestData.TestAction = usePrintError_Test_TestAction;
      // 
      // usePrintError_Test_TestAction
      // 
      resources.ApplyResources(usePrintError_Test_TestAction, "usePrintError_Test_TestAction");
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

    private SqlDatabaseTestActions uspGetBillOfMaterials_TestData;
    private SqlDatabaseTestActions uspGetEmployeeManagers_TestData;
    private SqlDatabaseTestActions uspGetManagerEmployees_TestData;
    private SqlDatabaseTestActions uspGetWhereUsedProductID_TestData;
    private SqlDatabaseTestActions useLogError_TestData;
    private SqlDatabaseTestActions usePrintError_TestData;
  }
}
