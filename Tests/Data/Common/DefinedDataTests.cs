﻿using Abc.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class DefinedDataTests : AbstractClassTest<DefinedEntityData, NamedEntityData>
    {
        private class testClass : DefinedEntityData { }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            obj = new testClass();
        }

        [TestMethod]
        public void DefinitionTest()
        {
            isNullableProperty(() => obj.Definition, x => obj.Definition = x);
        }
    }
}
