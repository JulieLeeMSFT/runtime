// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Threading;

public class Test{

	public static int Main()
	{
		int rValue = 0;		
		Object foo = new Object();
		
		try{
			Monitor.Exit(foo);
			rValue = -1;
		}
		catch(SynchronizationLockException)
		{
			rValue = 100;
		}
		Console.WriteLine(100 == rValue ? "Test Passed":"Test Failed");
		return rValue;
	}
}
