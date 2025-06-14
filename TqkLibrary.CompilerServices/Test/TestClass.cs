using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace TqkLibrary.CompilerServices.Test
{
    internal class TestClass
    {
        public TestClass()
        {

        }
        [SetsRequiredMembers]
        public TestClass(string name, string name2)
        {
            this.Name = name;
            this.Name2 = name2;
        }
        public required string Name { get; init; }
        public required string Name2 { get; set; }


        static void Create()
        {
            TestClass testClass = new TestClass()
            {
                Name = "Test",
                Name2 = "Test2"
            };
            TestClass testClass2 = new TestClass("Test", "Test2");
        }

    }
}
