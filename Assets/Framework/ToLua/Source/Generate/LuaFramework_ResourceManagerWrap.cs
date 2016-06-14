﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class LuaFramework_ResourceManagerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(LuaFramework.ResourceManager), typeof(Manager));
		L.RegFunction("Initialize", Initialize);
		L.RegFunction("LoadPrefab", LoadPrefab);
		L.RegFunction("LoadAssetBundle", LoadAssetBundle);
		L.RegFunction("LoadTable", LoadTable);
		L.RegFunction("CreateObject", CreateObject);
		L.RegFunction("LoadFile", LoadFile);
		L.RegFunction("CreateObjectWithOutScript", CreateObjectWithOutScript);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", Lua_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Initialize(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LuaFramework.ResourceManager obj = (LuaFramework.ResourceManager)ToLua.CheckObject(L, 1, typeof(LuaFramework.ResourceManager));
			obj.Initialize();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadPrefab(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			LuaFramework.ResourceManager obj = (LuaFramework.ResourceManager)ToLua.CheckObject(L, 1, typeof(LuaFramework.ResourceManager));
			string arg0 = ToLua.CheckString(L, 2);
			string[] arg1 = ToLua.CheckStringArray(L, 3);
			LuaFunction arg2 = ToLua.CheckLuaFunction(L, 4);
			obj.LoadPrefab(arg0, arg1, arg2);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadAssetBundle(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			LuaFramework.ResourceManager obj = (LuaFramework.ResourceManager)ToLua.CheckObject(L, 1, typeof(LuaFramework.ResourceManager));
			string arg0 = ToLua.CheckString(L, 2);
			UnityEngine.AssetBundle o = obj.LoadAssetBundle(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadTable(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			LuaFramework.ResourceManager obj = (LuaFramework.ResourceManager)ToLua.CheckObject(L, 1, typeof(LuaFramework.ResourceManager));
			string arg0 = ToLua.CheckString(L, 2);
			string o = obj.LoadTable(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CreateObject(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 5 && TypeChecker.CheckTypes(L, 1, typeof(LuaFramework.ResourceManager), typeof(string), typeof(string), typeof(string), typeof(string)))
			{
				LuaFramework.ResourceManager obj = (LuaFramework.ResourceManager)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				string arg1 = ToLua.ToString(L, 3);
				string arg2 = ToLua.ToString(L, 4);
				string arg3 = ToLua.ToString(L, 5);
				LuaInterface.LuaTable o = obj.CreateObject(arg0, arg1, arg2, arg3);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 7 && TypeChecker.CheckTypes(L, 1, typeof(LuaFramework.ResourceManager), typeof(string), typeof(string), typeof(string), typeof(string), typeof(LuaInterface.LuaFunction), typeof(LuaInterface.LuaFunction)))
			{
				LuaFramework.ResourceManager obj = (LuaFramework.ResourceManager)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				string arg1 = ToLua.ToString(L, 3);
				string arg2 = ToLua.ToString(L, 4);
				string arg3 = ToLua.ToString(L, 5);
				LuaFunction arg4 = ToLua.ToLuaFunction(L, 6);
				LuaFunction arg5 = ToLua.ToLuaFunction(L, 7);
				obj.CreateObject(arg0, arg1, arg2, arg3, arg4, arg5);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: LuaFramework.ResourceManager.CreateObject");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadFile(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			LuaFramework.ResourceManager obj = (LuaFramework.ResourceManager)ToLua.CheckObject(L, 1, typeof(LuaFramework.ResourceManager));
			string arg0 = ToLua.CheckString(L, 2);
			string arg1 = ToLua.CheckString(L, 3);
			string o = obj.LoadFile(arg0, arg1);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CreateObjectWithOutScript(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			LuaFramework.ResourceManager obj = (LuaFramework.ResourceManager)ToLua.CheckObject(L, 1, typeof(LuaFramework.ResourceManager));
			string arg0 = ToLua.CheckString(L, 2);
			string arg1 = ToLua.CheckString(L, 3);
			string arg2 = ToLua.CheckString(L, 4);
			UnityEngine.GameObject o = obj.CreateObjectWithOutScript(arg0, arg1, arg2);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Lua_ToString(IntPtr L)
	{
		object obj = ToLua.ToObject(L, 1);

		if (obj != null)
		{
			LuaDLL.lua_pushstring(L, obj.ToString());
		}
		else
		{
			LuaDLL.lua_pushnil(L);
		}

		return 1;
	}
}
