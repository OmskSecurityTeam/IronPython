[CachedOptimizedCode(new string[] { "__name__", "__file__", "__doc__", "__path__", "__builtins__", "__package__", "sys", "System", "product", "HelloWorld", "Myclass", "obj_my_class", "i", "l", "divmod", "xrange" })]
public static object __main__$1(CodeContext $globalContext, FunctionCode $functionCode)
{
    StrongBox<object[]> box;
    object obj2;
    object[] objArray = new object[] { box = new StrongBox<object[]>() };
    box.Value = new object[0x18];
    box.Value[0x17] = (object[]) CallSite<Func<CallSite, object, object, object>>.Create(PythonOps.MakeBinaryOperationAction($globalContext, ExpressionType.Add));
    box.Value[0x16] = (object[]) CallSite<Func<CallSite, object, object, object>>.Create(PythonOps.MakeBinaryOperationAction($globalContext, ExpressionType.Multiply));
    box.Value[0x15] = (object[]) CallSite<Func<CallSite, object, object, object>>.Create(PythonOps.MakeSetAction($globalContext, "var_b"));
    box.Value[20] = (object[]) CallSite<Func<CallSite, object, object, object>>.Create(PythonOps.MakeSetAction($globalContext, "var_a"));
    box.Value[0x13] = (object[]) CallSite<Func<CallSite, CodeContext, object, object, int, object>>.Create(PythonOps.MakeInvokeAction($globalContext, new CallSignature(2)));
    string[] argNames = new string[] { "self", "a", "b" };
    string[] varNames = new string[] { "self", "a", "b", "c" };
    box.Value[0x12] = (object[]) PythonOps.MakeFunctionCode($globalContext, "mysum", null, argNames, FunctionAttributes.None, 250, 0x12a, @"Tutorial\sample_2.py", new Func<PythonFunction, object, object, object, object>(DLRCachedCode.mysum$80), null, null, null, varNames, 4);
    string[] textArray3 = new string[] { "self", "init_num" };
    string[] names = new string[] { "divmod" };
    string[] textArray5 = new string[] { "self", "init_num" };
    box.Value[0x11] = (object[]) PythonOps.MakeFunctionCode($globalContext, "__init__", null, textArray3, FunctionAttributes.None, 0xa4, 0xf5, @"Tutorial\sample_2.py", new Func<PythonFunction, object, object, object>(DLRCachedCode.__init__$79), null, names, null, textArray5, 2);
    string[] textArray6 = new string[] { "__module__", "var_a", "var_b", "__init__", "mysum" };
    box.Value[0x10] = textArray6;
    box.Value[15] = (object[]) CallSite<Func<CallSite, object, int, object>>.Create(PythonOps.MakeGetIndexAction($globalContext, 2));
    box.Value[14] = (object[]) CallSite<Func<CallSite, object, CodeContext, object>>.Create(PythonOps.MakeGetAction($globalContext, "index", false));
    box.Value[13] = (object[]) CallSite<Func<CallSite, CodeContext, object, int, object>>.Create(PythonOps.MakeInvokeAction($globalContext, new CallSignature(1)));
    box.Value[12] = (object[]) CallSite<Func<CallSite, object, CodeContext, object>>.Create(PythonOps.MakeGetAction($globalContext, "append", false));
    box.Value[11] = (object[]) CallSite<Func<CallSite, CodeContext, object, int, object>>.Create(PythonOps.MakeInvokeAction($globalContext, new CallSignature(1)));
    box.Value[10] = (object[]) CallSite<Func<CallSite, CodeContext, object, int, int, object>>.Create(PythonOps.MakeInvokeAction($globalContext, new CallSignature(2)));
    box.Value[9] = (object[]) CallSite<Func<CallSite, object, KeyValuePair<IEnumerator, IDisposable>>>.Create(PythonOps.MakeOperationAction($globalContext, 0x12));
    box.Value[8] = (object[]) CallSite<Func<CallSite, CodeContext, object, object>>.Create(PythonOps.MakeInvokeAction($globalContext, new CallSignature(0)));
    box.Value[7] = (object[]) CallSite<Func<CallSite, CodeContext, object, int, object>>.Create(PythonOps.MakeInvokeAction($globalContext, new CallSignature(1)));
    box.Value[6] = (object[]) CallSite<Func<CallSite, object, KeyValuePair<IEnumerator, IDisposable>>>.Create(PythonOps.MakeOperationAction($globalContext, 0x12));
    box.Value[5] = (object[]) CallSite<Func<CallSite, object, CodeContext, object>>.Create(PythonOps.MakeGetAction($globalContext, "mysum", false));
    box.Value[4] = (object[]) CallSite<Func<CallSite, CodeContext, object, int, int, object>>.Create(PythonOps.MakeInvokeAction($globalContext, new CallSignature(2)));
    box.Value[3] = (object[]) CallSite<Func<CallSite, CodeContext, object, object>>.Create(PythonOps.MakeInvokeAction($globalContext, new CallSignature(0)));
    box.Value[2] = (object[]) CallSite<Func<CallSite, object, string, bool>>.Create(PythonOps.MakeComboAction($globalContext, PythonOps.MakeBinaryOperationAction($globalContext, ExpressionType.Equal), PythonOps.MakeConversionAction($globalContext, typeof(bool), ConversionResultKind.ExplicitCast)));
    string[] textArray7 = new string[] { "__module__", "var_a", "var_b", "__init__", "mysum" };
    box.Value[1] = (object[]) PythonOps.MakeFunctionCode($globalContext, "Myclass", null, new string[0], FunctionAttributes.None, 0x7b, 0x12e, @"Tutorial\sample_2.py", new Func<CodeContext, CodeContext>(DLRCachedCode.Myclass$38), null, null, null, textArray7, 5);
    box.Value[0] = (object[]) PythonOps.MakeFunctionCode($globalContext, "HelloWorld", null, new string[0], FunctionAttributes.None, 0x4d, 0x77, @"Tutorial\sample_2.py", new Func<PythonFunction, object>(DLRCachedCode.HelloWorld$78), null, null, null, null, 0);
    PythonGlobal[] globalArrayFromContext = PythonOps.GetGlobalArrayFromContext($globalContext);
    try
    {
        int num;
        obj2 = PythonOps.PublishModule($globalContext, "__main__");
        try
        {
            CallSite<Func<CallSite, object, string, bool>> site;
            globalArrayFromContext[1].CurrentValue = @"Tutorial\sample_2.py";
            globalArrayFromContext[0].CurrentValue = "__main__";
            PythonOps.ModuleStarted($globalContext, ModuleOptions.Initialize);
            globalArrayFromContext[2].CurrentValue = null;
            num = 1;
            globalArrayFromContext[6].CurrentValue = LightExceptions.CheckAndThrow(PythonOps.ImportTop($globalContext, "sys", -1));
            globalArrayFromContext[7].CurrentValue = LightExceptions.CheckAndThrow(PythonOps.ImportTop($globalContext, "System", -1));
            num = 2;
            string[] textArray8 = new string[] { "product" };
            object module = LightExceptions.CheckAndThrow(PythonOps.ImportWithNames($globalContext, "itertools", textArray8, -1));
            globalArrayFromContext[8].CurrentValue = PythonOps.ImportFrom($globalContext, module, "product");
            num = 3;
            PythonOps.ImportStar($globalContext, "binascii", -1);
            globalArrayFromContext[9].CurrentValue = PythonOps.MakeFunction($globalContext, (FunctionCode) box.Value[0], globalArrayFromContext[0].RawValue, null);
            num = 8;
            globalArrayFromContext[10].CurrentValue = PythonOps.MakeClass((FunctionCode) box.Value[1], null, $globalContext, "Myclass", new object[0], "");
            num = 0x12;
            if ((site = (CallSite<Func<CallSite, object, string, bool>>) box.Value[2]).Target(site, globalArrayFromContext[0].CurrentValue, "__main__"))
            {
                CallSite<Func<CallSite, CodeContext, object, object>> site2;
                CallSite<Func<CallSite, CodeContext, object, int, int, object>> site3;
                CallSite<Func<CallSite, object, CodeContext, object>> site4;
                CallSite<Func<CallSite, object, KeyValuePair<IEnumerator, IDisposable>>> site5;
                CallSite<Func<CallSite, CodeContext, object, int, object>> site6;
                CallSite<Func<CallSite, object, KeyValuePair<IEnumerator, IDisposable>>> site8;
                CallSite<Func<CallSite, CodeContext, object, int, int, object>> site9;
                CallSite<Func<CallSite, CodeContext, object, int, object>> site10;
                CallSite<Func<CallSite, object, CodeContext, object>> site11;
                CallSite<Func<CallSite, CodeContext, object, int, object>> site12;
                CallSite<Func<CallSite, object, CodeContext, object>> site13;
                CallSite<Func<CallSite, object, int, object>> site14;
                num = 0x13;
                globalArrayFromContext[11].CurrentValue = (site2 = (CallSite<Func<CallSite, CodeContext, object, object>>) box.Value[3]).Target(site2, $globalContext, globalArrayFromContext[10].CurrentValue);
                num = 20;
                (site3 = (CallSite<Func<CallSite, CodeContext, object, int, int, object>>) box.Value[4]).Target(site3, $globalContext, (site4 = (CallSite<Func<CallSite, object, CodeContext, object>>) box.Value[5]).Target(site4, globalArrayFromContext[11].CurrentValue, $globalContext), 100, 200);
                num = 0x15;
                KeyValuePair<IEnumerator, IDisposable> iteratorInfo = (site5 = (CallSite<Func<CallSite, object, KeyValuePair<IEnumerator, IDisposable>>>) box.Value[6]).Target(site5, (site6 = (CallSite<Func<CallSite, CodeContext, object, int, object>>) box.Value[7]).Target(site6, $globalContext, globalArrayFromContext[15].CurrentValue, 5));
                try
                {
                    while (iteratorInfo.Key.MoveNext())
                    {
                        CallSite<Func<CallSite, CodeContext, object, object>> site7;
                        globalArrayFromContext[12].CurrentValue = iteratorInfo.Key.Current;
                        (site7 = (CallSite<Func<CallSite, CodeContext, object, object>>) box.Value[8]).Target(site7, $globalContext, globalArrayFromContext[9].CurrentValue);
                        num = 0x15;
                    }
                }
                finally
                {
                    PythonOps.ForLoopDispose(iteratorInfo);
                }
                num = 0x16;
                PythonGlobal global = globalArrayFromContext[13];
                List l = PythonOps.MakeList();
                KeyValuePair<IEnumerator, IDisposable> pair2 = (site8 = (CallSite<Func<CallSite, object, KeyValuePair<IEnumerator, IDisposable>>>) box.Value[9]).Target(site8, (site9 = (CallSite<Func<CallSite, CodeContext, object, int, int, object>>) box.Value[10]).Target(site9, $globalContext, globalArrayFromContext[15].CurrentValue, 1, 5));
                try
                {
                    while (pair2.Key.MoveNext())
                    {
                        globalArrayFromContext[12].CurrentValue = pair2.Key.Current;
                        PythonOps.ListAddForComprehension(l, globalArrayFromContext[12].CurrentValue);
                    }
                }
                finally
                {
                    PythonOps.ForLoopDispose(pair2);
                }
                List list = l;
                global.CurrentValue = list;
                num = 0x17;
                (site10 = (CallSite<Func<CallSite, CodeContext, object, int, object>>) box.Value[11]).Target(site10, $globalContext, (site11 = (CallSite<Func<CallSite, object, CodeContext, object>>) box.Value[12]).Target(site11, globalArrayFromContext[13].CurrentValue, $globalContext), 8);
                num = 0x18;
                PythonOps.Print($globalContext, (site12 = (CallSite<Func<CallSite, CodeContext, object, int, object>>) box.Value[13]).Target(site12, $globalContext, (site13 = (CallSite<Func<CallSite, object, CodeContext, object>>) box.Value[14]).Target(site13, globalArrayFromContext[13].CurrentValue, $globalContext), 4));
                num = 0x19;
                PythonOps.Print($globalContext, (site14 = (CallSite<Func<CallSite, object, int, object>>) box.Value[15]).Target(site14, globalArrayFromContext[13].CurrentValue, 2));
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

private static CodeContext Myclass$38(Closure closure1, CodeContext $parentContext)
{
    CodeContext context;
    int num;
    StrongBox<object[]> box = (StrongBox<object[]>) closure1.Locals[0];
    try
    {
        PythonGlobal[] globalArrayFromContext = PythonOps.GetGlobalArrayFromContext(PythonOps.GetGlobalContext($parentContext));
        ClosureCell cell = PythonOps.MakeClosureCell();
        ClosureCell cell2 = PythonOps.MakeClosureCell();
        ClosureCell cell3 = PythonOps.MakeClosureCell();
        ClosureCell cell4 = PythonOps.MakeClosureCell();
        ClosureCell cell5 = PythonOps.MakeClosureCell();
        context = PythonOps.CreateLocalContext($parentContext, new MutableTuple<ClosureCell, ClosureCell, ClosureCell, ClosureCell, ClosureCell, DynamicNull, DynamicNull, DynamicNull>(cell, cell2, cell3, cell4, cell5, null, null, null), (string[]) box.Value[0x10]);
        cell.Value = globalArrayFromContext[0].CurrentValue;
        num = 9;
        object obj2 = ScriptingRuntimeHelpers.Int32ToObject(0);
        PythonOps.SetName(context, "var_a", obj2);
        PythonOps.SetName(context, "var_b", obj2);
        object[] defaults = new object[] { ScriptingRuntimeHelpers.Int32ToObject(0xfb) };
        cell4.Value = PythonOps.MakeFunction(context, (FunctionCode) box.Value[0x11], globalArrayFromContext[0].RawValue, defaults);
        cell5.Value = PythonOps.MakeFunction(context, (FunctionCode) box.Value[0x12], globalArrayFromContext[0].RawValue, null);
        return context;
    }
    catch (Exception exception)
    {
        PythonOps.UpdateStackTrace(exception, context, (FunctionCode) box.Value[1], num);
        throw;
    }
}

 
 
private static object __init__$79(Closure closure1, PythonFunction $function, object self, object init_num)
{
    int num;
    StrongBox<object[]> box = (StrongBox<object[]>) closure1.Locals[0];
    CodeContext globalContext = PythonOps.GetGlobalContext(PythonOps.GetParentContextFromFunction($function));
    PythonGlobal[] globalArrayFromContext = PythonOps.GetGlobalArrayFromContext(globalContext);
    try
    {
        CallSite<Func<CallSite, CodeContext, object, object, int, object>> site;
        CallSite<Func<CallSite, object, object, object>> site2;
        CallSite<Func<CallSite, object, object, object>> site3;
        num = 12;
        object e = (site = (CallSite<Func<CallSite, CodeContext, object, object, int, object>>) box.Value[0x13]).Target(site, globalContext, globalArrayFromContext[14].CurrentValue, init_num, 0x2f);
        object[] objArray2 = (object[]) LightExceptions.CheckAndThrow(PythonOps.GetEnumeratorValues(globalContext, e, 2));
        (site2 = (CallSite<Func<CallSite, object, object, object>>) box.Value[20]).Target(site2, self, objArray2[0]);
        (site3 = (CallSite<Func<CallSite, object, object, object>>) box.Value[0x15]).Target(site3, self, objArray2[1]);
    }
    catch (Exception exception)
    {
        PythonOps.UpdateStackTrace(exception, globalContext, (FunctionCode) box.Value[0x11], num);
        throw;
    }
    return null;
}


private static object mysum$80(Closure closure1, PythonFunction $function, object self, object a, object b)
{
    int num;
    StrongBox<object[]> box = (StrongBox<object[]>) closure1.Locals[0];
    CodeContext globalContext = PythonOps.GetGlobalContext(PythonOps.GetParentContextFromFunction($function));
    PythonGlobal[] globalArrayFromContext = PythonOps.GetGlobalArrayFromContext(globalContext);
    try
    {
        CallSite<Func<CallSite, object, object, object>> site;
        CallSite<Func<CallSite, object, object, object>> site2;
        num = 15;
        object obj2 = ScriptingRuntimeHelpers.Int32ToObject(50);
        num = 0x10;
        return (site = (CallSite<Func<CallSite, object, object, object>>) box.Value[0x16]).Target(site, (site2 = (CallSite<Func<CallSite, object, object, object>>) box.Value[0x17]).Target(site2, a, b), obj2);
    }
    catch (Exception exception)
    {
        PythonOps.UpdateStackTrace(exception, globalContext, (FunctionCode) box.Value[0x12], num);
        throw;
    }
    return null;
}

 


 


 
