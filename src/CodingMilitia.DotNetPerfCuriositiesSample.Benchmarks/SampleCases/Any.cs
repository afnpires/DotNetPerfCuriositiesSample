using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using CodingMilitia.DotNetPerfCuriositiesSample.Benchmarks.Helpers;

namespace CodingMilitia.DotNetPerfCuriositiesSample.Benchmarks.SampleCases
{
    public class Any
    {
        private static readonly IReadOnlyCollection<int> EmptyReadonlyCollection = Array.Empty<int>();
        private static readonly IReadOnlyCollection<int> NonEmptyReadonlyCollection = Enumerable.Range(0, 1000).ToArray();

        [Benchmark]
        public void EmptyReadonlyCollectionAny() => EmptyReadonlyCollection.Any();

        [Benchmark]
        public void EmptyReadonlyCollectionSome() => EmptyReadonlyCollection.AnyUsingCount();

        [Benchmark]
        public void NonEmptyReadonlyCollectionAny() => NonEmptyReadonlyCollection.Any();

        [Benchmark]
        public void NonEmptyReadonlyCollectionSome() => NonEmptyReadonlyCollection.AnyUsingCount();

        [Benchmark]
        public void EmptyReadonlyCollectionLoopAny()
        {
            for (var i = 0; i < 1000; ++i)
            {
                EmptyReadonlyCollection.Any();
            }
        }

        [Benchmark]
        public void EmptyReadonlyCollectionLoopSome()
        {
            for (var i = 0; i < 1000; ++i)
            {
                EmptyReadonlyCollection.AnyUsingCount();
            }
        }

        [Benchmark]
        public void NonEmptyReadonlyCollectionLoopAny()
        {
            for (var i = 0; i < 1000; ++i)
            {
                NonEmptyReadonlyCollection.Any();
            }
        }

        [Benchmark]
        public void NonEmptyReadonlyCollectionLoopSome()
        {
            for (var i = 0; i < 1000; ++i)
            {
                NonEmptyReadonlyCollection.AnyUsingCount();
            }
        }
    }
}