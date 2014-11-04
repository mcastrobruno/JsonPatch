﻿using System;
namespace Marvin.JsonPatch.Adapters
{
    public interface IObjectAdapter<T>
     where T : class
    {
        void Add(Marvin.JsonPatch.Operations.Operation<T> operation, T objectToApplyTo);
        void Copy(Marvin.JsonPatch.Operations.Operation<T> operation, T objectToApplyTo);
        void Move(Marvin.JsonPatch.Operations.Operation<T> operation, T objectToApplyTo);
        void Remove(Marvin.JsonPatch.Operations.Operation<T> operation, T objectToApplyTo);
        void Replace(Marvin.JsonPatch.Operations.Operation<T> operation, T objectToApplyTo);
        void Test(Marvin.JsonPatch.Operations.Operation<T> operation, T objectToApplyTo);
    }

    public interface IObjectAdapter
    {
        void Add(Marvin.JsonPatch.Operations.Operation operation, object objectToApplyTo);
        void Copy(Marvin.JsonPatch.Operations.Operation operation, object objectToApplyTo);
        void Move(Marvin.JsonPatch.Operations.Operation operation, object objectToApplyTo);
        void Remove(Marvin.JsonPatch.Operations.Operation operation, object objectToApplyTo);
        void Replace(Marvin.JsonPatch.Operations.Operation operation, object objectToApplyTo);
        void Test(Marvin.JsonPatch.Operations.Operation operation, object objectToApplyTo);
    }
}