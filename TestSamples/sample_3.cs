[CachedOptimizedCode(new string[] { "__name__", "__file__", "__doc__", "__path__", "__builtins__", "__package__", "clr", "TestForm", "form", "Form", "Application" })]
public static object __main__$1(CodeContext $globalContext, FunctionCode $functionCode)
{
    StrongBox<object[]> box;
    object obj2;
    object[] objArray = new object[] { box = new StrongBox<object[]>() };
    box.Value = new object[12];
    box.Value[11] = (object[]) CallSite<Func<CallSite, object, string, object>>.Create(PythonOps.MakeSetAction($globalContext, "Name"));
    box.Value[10] = (object[]) CallSite<Func<CallSite, object, string, object>>.Create(PythonOps.MakeSetAction($globalContext, "Text"));
    string[] argNames = new string[] { "self" };
    string[] varNames = new string[] { "self" };
    box.Value[9] = (object[]) PythonOps.MakeFunctionCode($globalContext, "__init__", null, argNames, FunctionAttributes.None, 0xc0, 0x124, @"Tutorial\sample_3.py", new Func<PythonFunction, object, object>(DLRCachedCode.__init__$78), null, null, null, varNames, 1);
    string[] textArray3 = new string[] { "__module__", "__init__" };
    box.Value[8] = textArray3;
    box.Value[7] = (object[]) CallSite<Func<CallSite, object, CodeContext, object>>.Create(PythonOps.MakeGetAction($globalContext, "Run", false));
    box.Value[6] = (object[]) CallSite<Func<CallSite, CodeContext, object, object, object>>.Create(PythonOps.MakeInvokeAction($globalContext, new CallSignature(1)));
    box.Value[5] = (object[]) CallSite<Func<CallSite, CodeContext, object, object>>.Create(PythonOps.MakeInvokeAction($globalContext, new CallSignature(0)));
    string[] textArray4 = new string[] { "__module__", "__init__" };
    box.Value[4] = (object[]) PythonOps.MakeFunctionCode($globalContext, "TestForm", null, new string[0], FunctionAttributes.None, 0xa2, 0x128, @"Tutorial\sample_3.py", new Func<CodeContext, CodeContext>(DLRCachedCode.TestForm$37), null, null, null, textArray4, 2);
    box.Value[3] = (object[]) CallSite<Func<CallSite, object, CodeContext, object>>.Create(PythonOps.MakeGetAction($globalContext, "AddReference", false));
    box.Value[2] = (object[]) CallSite<Func<CallSite, CodeContext, object, string, object>>.Create(PythonOps.MakeInvokeAction($globalContext, new CallSignature(1)));
    box.Value[1] = (object[]) CallSite<Func<CallSite, object, CodeContext, object>>.Create(PythonOps.MakeGetAction($globalContext, "AddReference", false));
    box.Value[0] = (object[]) CallSite<Func<CallSite, CodeContext, object, string, object>>.Create(PythonOps.MakeInvokeAction($globalContext, new CallSignature(1)));
    PythonGlobal[] globalArrayFromContext = PythonOps.GetGlobalArrayFromContext($globalContext);
    try
    {
        int num;
        obj2 = PythonOps.PublishModule($globalContext, "__main__");
        try
        {
            CallSite<Func<CallSite, CodeContext, object, string, object>> site;
            CallSite<Func<CallSite, object, CodeContext, object>> site2;
            CallSite<Func<CallSite, CodeContext, object, string, object>> site3;
            CallSite<Func<CallSite, object, CodeContext, object>> site4;
            CallSite<Func<CallSite, CodeContext, object, object>> site5;
            CallSite<Func<CallSite, CodeContext, object, object, object>> site6;
            CallSite<Func<CallSite, object, CodeContext, object>> site7;
            globalArrayFromContext[1].CurrentValue = @"Tutorial\sample_3.py";
            globalArrayFromContext[0].CurrentValue = "__main__";
            PythonOps.ModuleStarted($globalContext, ModuleOptions.Initialize);
            globalArrayFromContext[2].CurrentValue = null;
            num = 1;
            globalArrayFromContext[6].CurrentValue = LightExceptions.CheckAndThrow(PythonOps.ImportTop($globalContext, "clr", -1));
            num = 3;
            (site = (CallSite<Func<CallSite, CodeContext, object, string, object>>) box.Value[0]).Target(site, $globalContext, (site2 = (CallSite<Func<CallSite, object, CodeContext, object>>) box.Value[1]).Target(site2, globalArrayFromContext[6].CurrentValue, $globalContext), "System.Drawing");
            num = 4;
            (site3 = (CallSite<Func<CallSite, CodeContext, object, string, object>>) box.Value[2]).Target(site3, $globalContext, (site4 = (CallSite<Func<CallSite, object, CodeContext, object>>) box.Value[3]).Target(site4, globalArrayFromContext[6].CurrentValue, $globalContext), "System.Windows.Forms");
            num = 5;
            PythonOps.ImportStar($globalContext, "System.Drawing", -1);
            num = 6;
            PythonOps.ImportStar($globalContext, "System.Windows.Forms", -1);
            num = 9;
            object[] bases = new object[] { globalArrayFromContext[9].CurrentValue };
            globalArrayFromContext[7].CurrentValue = PythonOps.MakeClass((FunctionCode) box.Value[4], null, $globalContext, "TestForm", bases, "Text,Name");
            num = 15;
            globalArrayFromContext[8].CurrentValue = (site5 = (CallSite<Func<CallSite, CodeContext, object, object>>) box.Value[5]).Target(site5, $globalContext, globalArrayFromContext[7].CurrentValue);
            num = 0x10;
            (site6 = (CallSite<Func<CallSite, CodeContext, object, object, object>>) box.Value[6]).Target(site6, $globalContext, (site7 = (CallSite<Func<CallSite, object, CodeContext, object>>) box.Value[7]).Target(site7, globalArrayFromContext[10].CurrentValue, $globalContext), globalArrayFromContext[8].CurrentValue);
        }
        catch (Exception exception)
        {
            PythonOps.UpdateStackTrace(exception, $globalContext, $functionCode, num);
            throw;
        }
    }
    catch (Exception)
    {
        PythonOps.RemoveModule($globalContext, "__main__", obj2);
        throw;
    }
    return null;
}

 

 private static CodeContext TestForm$37(Closure closure1, CodeContext $parentContext)
{
    object[] locals = closure1.Locals;
    PythonGlobal[] globalArrayFromContext = PythonOps.GetGlobalArrayFromContext(PythonOps.GetGlobalContext($parentContext));
    ClosureCell cell = PythonOps.MakeClosureCell();
    ClosureCell cell2 = PythonOps.MakeClosureCell();
    CodeContext context = PythonOps.CreateLocalContext($parentContext, new MutableTuple<ClosureCell, ClosureCell>(cell, cell2), (string[]) ((StrongBox<object[]>) locals[0]).Value[8]);
    cell.Value = globalArrayFromContext[0].CurrentValue;
    cell2.Value = PythonOps.MakeFunction(context, (FunctionCode) ((StrongBox<object[]>) locals[0]).Value[9], globalArrayFromContext[0].RawValue, null);
    return context;
}




 private static object __init__$78(Closure closure1, PythonFunction $function, object self)
{
    int num;
    StrongBox<object[]> box = (StrongBox<object[]>) closure1.Locals[0];
    CodeContext globalContext = PythonOps.GetGlobalContext(PythonOps.GetParentContextFromFunction($function));
    PythonGlobal[] globalArrayFromContext = PythonOps.GetGlobalArrayFromContext(globalContext);
    try
    {
        CallSite<Func<CallSite, object, string, object>> site;
        CallSite<Func<CallSite, object, string, object>> site2;
        num = 12;
        (site = (CallSite<Func<CallSite, object, string, object>>) box.Value[10]).Target(site, self, "Hello, IronPython!");
        num = 13;
        (site2 = (CallSite<Func<CallSite, object, string, object>>) box.Value[11]).Target(site2, self, "Test Programm");
    }
    catch (Exception exception)
    {
        PythonOps.UpdateStackTrace(exception, globalContext, (FunctionCode) box.Value[9], num);
        throw;
    }
    return null;
}

 


 

