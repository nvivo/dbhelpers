using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBHelpers.Tests
{
    public abstract class BaseOverloadTests
    {
        protected virtual IEnumerable<string> GetRequiredInstanceSignatures()
        {
            return null;
        }

        protected virtual IEnumerable<string> GetRequiredStaticSignatures()
        {
            return null;
        }

        protected virtual IEnumerable<string> GetExistingInstanceSignatures()
        {
            return null;
        }

        protected virtual IEnumerable<string> GetExistingStaticSignatures()
        {
            return null;
        }

        [TestCaseSource("RequiredInstanceSignaturesTestSource")]
        public void RequiredInstanceSignaturesExist(bool pass)
        {
            Assert.That(pass, "The signature does not exists when it should.");
        }

        [TestCaseSource("RequiredStaticSignaturesTestSource")]
        public void RequiredStaticSignaturesExist(bool pass)
        {
            Assert.That(pass, "The signature does not exists when it should.");
        }

        [TestCaseSource("TestedInstanceSignaturesTestSource")]
        public void TestedInstanceSignatures(bool pass)
        {
            Assert.That(pass, "Public instance signature exists but is not required.");
        }

        [TestCaseSource("TestedStaticSignaturesTestSource")]
        public void TestedStaticSignatures(bool pass)
        {
            Assert.That(pass, "Public static signature exists but is not required.");
        }

        public IEnumerable<TestCaseData> RequiredInstanceSignaturesTestSource()
        {
            var existing = GetExistingInstanceSignatures() ?? new string[0];
            var required = GetRequiredInstanceSignatures() ?? new string[0];

            if (required.Count() == 0)
                yield return new TestCaseData(true).SetName("No required signatures to test.");

            foreach (var sig in required)
            {
                bool pass = existing.Contains(sig);
                yield return new TestCaseData(pass).SetName(sig);
            }
        }

        protected IEnumerable<TestCaseData> TestedInstanceSignaturesTestSource()
        {
            var existing = GetExistingInstanceSignatures() ?? new string[0];
            var required = GetRequiredInstanceSignatures() ?? new string[0];

            if (required.Count() == 0)
                yield return new TestCaseData(true).SetName("No required signatures to test.");

            foreach (var sig in existing)
            {
                bool pass = required.Contains(sig);
                yield return new TestCaseData(pass).SetName(sig);
            }
        }

        protected IEnumerable<TestCaseData> RequiredStaticSignaturesTestSource()
        {
            var existing = GetExistingStaticSignatures() ?? new string[0];
            var required = GetRequiredStaticSignatures() ?? new string[0];
            
            if (required.Count() == 0)
                yield return new TestCaseData(true).SetName("No required signatures to test.");

            foreach (var sig in required)
            {
                bool pass = existing.Contains(sig);
                yield return new TestCaseData(pass).SetName(sig);
            }
        }

        protected IEnumerable<TestCaseData> TestedStaticSignaturesTestSource()
        {
            var existing = GetExistingStaticSignatures() ?? new string[0];
            var required = GetRequiredStaticSignatures() ?? new string[0];

            if (required.Count() == 0)
                yield return new TestCaseData(true).SetName("No required signatures to test.");

            foreach (var sig in existing)
            {
                bool pass = required.Contains(sig);
                yield return new TestCaseData(pass).SetName(sig);
            }
        }
    }
}
