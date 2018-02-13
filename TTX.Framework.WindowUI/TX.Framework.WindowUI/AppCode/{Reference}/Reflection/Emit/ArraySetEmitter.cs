﻿#region COPYRIGHT
//
//     THIS IS GENERATED BY TEMPLATE
//     
//     AUTHOR  :     ROYE
//     DATE       :     2010
//
//     COPYRIGHT (C) 2010, TIANXIAHOTEL TECHNOLOGIES CO., LTD. ALL RIGHTS RESERVED.
//
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Reflection.Emit
{
    internal class ArraySetEmitter : BaseEmitter
    {
        public ArraySetEmitter(Type targetType)
            : base(new CallInfo(targetType, Flags.InstanceAnyVisibility, MemberTypes.Method, Constants.ArraySetterName, new[] { typeof(int), targetType.GetElementType() }, null))
        {
        }

        internal protected override DynamicMethod CreateDynamicMethod()
        {
            return CreateDynamicMethod(Constants.ArraySetterName, CallInfo.TargetType, null, new[] { Constants.ObjectType, Constants.IntType, Constants.ObjectType });
        }

        internal protected override Delegate CreateDelegate()
        {
            Type elementType = CallInfo.TargetType.GetElementType();
            Generator.ldarg_0 // load array
                .castclass(CallInfo.TargetType) // (T[])array
                .ldarg_1 // load index
                .ldarg_2 // load value
                .CastFromObject(elementType) // (unbox | cast) value
                .stelem(elementType) // array[index] = value
                .ret();
            return Method.CreateDelegate(typeof(ArrayElementSetter));
        }
    }
}
