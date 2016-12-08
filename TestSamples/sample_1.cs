[CachedOptimizedCode(new string[] { "__name__", "__file__", "__doc__", "__path__", "__builtins__", "__package__", "sys", "HelloWorld", "mysum" })]
public static object __main__$1(CodeContext $globalContext, FunctionCode $functionCode)
{
    StrongBox<object[]> box;
    object obj2;
    object[] objArray = new object[] { box = new StrongBox<object[]>() };
    box.Value = new object[6];
    box.Value[5] = (object[]) CallSite<Func<CallSite, object, object, object>>.Create(PythonOps.MakeBinaryOperationAction($globalContext, ExpressionType.Add));
    box.Value[4] = (object[]) CallSite<Func<CallSite, CodeContext, object, int, int, object>>.Create(PythonOps.MakeInvokeAction($globalContext, new CallSignature(2)));
    box.Value[3] = (object[]) CallSite<Func<CallSite, CodeContext, object, object>>.Create(PythonOps.MakeInvokeAction($globalContext, new CallSignature(0)));
    box.Value[2] = (object[]) CallSite<Func<CallSite, object, string, bool>>.Create(PythonOps.MakeComboAction($globalContext, PythonOps.MakeBinaryOperationAction($globalContext, ExpressionType.Equal), PythonOps.MakeConversionAction($globalContext, typeof(bool), ConversionResultKind.ExplicitCast)));
    string[] argNames = new string[] { "a", "b" };
    string[] varNames = new string[] { "a", "b" };
    box.Value[1] = (object[]) PythonOps.MakeFunctionCode($globalContext, "mysum", null, argNames, FunctionAttributes.None, 0x55, 0x71, @"Tutorial\Mytest.py", new Func<PythonFunction, object, object, object>(DLRCachedCode.mysum$79), null, null, null, varNames, 2);
    box.Value[0] = (object[]) PythonOps.MakeFunctionCode($globalContext, "HelloWorld", null, new string[0], FunctionAttributes.None, 0x27, 0x51, @"Tutorial\Mytest.py", new Func<PythonFunction, object>(DLRCachedCode.HelloWorld$78), null, null, null, null, 0);
    PythonGlobal[] globalArrayFromContext = PythonOps.GetGlobalArrayFromContext($globalContext);
    try
    {
        int num;
        obj2 = PythonOps.PublishModule($globalContext, "__main__");
        try
        {
            CallSite<Func<CallSite, object, string, bool>> site;
            globalArrayFromContext[1].CurrentValue = @"Tutorial\Mytest.py";
            globalArrayFromContext[0].CurrentValue = "__main__";
            PythonOps.ModuleStarted($globalContext, ModuleOptions.Initialize);
            globalArrayFromContext[2].CurrentValue = null;
            num = 1;
            globalArrayFromContext[6].CurrentValue = LightExceptions.CheckAndThrow(PythonOps.ImportTop($globalContext, "sys", -1));
            globalArrayFromContext[7].CurrentValue = PythonOps.MakeFunction($globalContext, (FunctionCode) box.Value[0], globalArrayFromContext[0].RawValue, null);
            globalArrayFromContext[8].CurrentValue = PythonOps.MakeFunction($globalContext, (FunctionCode) box.Value[1], globalArrayFromContext[0].RawValue, null);
            num = 10;
            if ((site = (CallSite<Func<CallSite, object, string, bool>>) box.Value[2]).Target(site, globalArrayFromContext[0].CurrentValue, "__main__"))
            {
                CallSite<Func<CallSite, CodeContext, object, object>> site2;
                CallSite<Func<CallSite, CodeContext, object, int, int, object>> site3;
                num = 11;
                PythonOps.Print($globalContext, (site2 = (CallSite<Func<CallSite, CodeContext, object, object>>) box.Value[3]).Target(site2, $globalContext, globalArrayFromContext[7].CurrentValue));
                num = 12;
                PythonOps.Print($globalContext, (site3 = (CallSite<Func<CallSite, CodeContext, object, int, int, object>>) box.Value[4]).Target(site3, $globalContext, globalArrayFromContext[8].CurrentValue, 100, 200));
            }
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


private static object HelloWorld$78(PythonFunction $function)
{
    PythonGlobal[] globalArrayFromContext = PythonOps.GetGlobalArrayFromContext(PythonOps.GetGlobalContext(PythonOps.GetParentContextFromFunction($function)));
    return (object) "Hello, World!";
}


private static object mysum$79(Closure closure1, PythonFunction $function, object a, object b)
{
    int num;
    object[] locals = closure1.Locals;
    CodeContext globalContext = PythonOps.GetGlobalContext(PythonOps.GetParentContextFromFunction($function));
    PythonGlobal[] globalArrayFromContext = PythonOps.GetGlobalArrayFromContext(globalContext);
    try
    {
        CallSite<Func<CallSite, object, object, object>> site;
        num = 7;
        return (site = (CallSite<Func<CallSite, object, object, object>>) ((StrongBox<object[]>) locals[0]).Value[5]).Target(site, a, b);
    }
    catch (Exception exception)
    {
        PythonOps.UpdateStackTrace(exception, globalContext, (FunctionCode) ((StrongBox<object[]>) locals[0]).Value[1], num);
        throw;
    }
    return null;
}




