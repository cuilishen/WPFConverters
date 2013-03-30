using Kent.Boogaart.Converters.Expressions.Nodes;
using Xunit;

namespace Kent.Boogaart.Converters.UnitTests.Expressions.Nodes
{
    public sealed class ModulusNodeTest : WideningBinaryNodeTestBase
    {
        private ModulusNode modulusNode;

        protected override void SetUpCore()
        {
            base.SetUpCore();
            this.modulusNode = new ModulusNode(new ConstantNode<int>(0), new ConstantNode<int>(0));
        }

        [Fact]
        public void OperatorSymbols_ShouldYieldCorrectOperatorSymbols()
        {
            Assert.Equal("%", GetPrivateMemberValue<string>(this.modulusNode, "OperatorSymbols"));
        }

        [Fact]
        public void DoByte_ShouldDoModulus()
        {
            Assert.Equal(1, InvokeDoMethod<int>(this.modulusNode, "DoByte", (byte)5, (byte)2));
        }

        [Fact]
        public void DoInt16_ShouldDoModulus()
        {
            Assert.Equal(1, InvokeDoMethod<int>(this.modulusNode, "DoInt16", (short)5, (short)2));
        }

        [Fact]
        public void DoInt32_ShouldDoModulus()
        {
            Assert.Equal(1, InvokeDoMethod<int>(this.modulusNode, "DoInt32", 5, 2));
        }

        [Fact]
        public void DoInt64_ShouldDoModulus()
        {
            Assert.Equal(1L, InvokeDoMethod<long>(this.modulusNode, "DoInt64", 5L, 2L));
        }

        [Fact]
        public void DoSingle_ShouldDoModulus()
        {
            Assert.Equal(1f, InvokeDoMethod<float>(this.modulusNode, "DoSingle", 5f, 2f));
        }

        [Fact]
        public void DoDouble_ShouldDoModulus()
        {
            Assert.Equal(1d, InvokeDoMethod<double>(this.modulusNode, "DoDouble", 5d, 2d));
        }

        [Fact]
        public void DoDecimal_ShouldDoModulus()
        {
            Assert.Equal(1m, InvokeDoMethod<decimal>(this.modulusNode, "DoDecimal", 5m, 2m));
        }
    }
}