﻿// AUTOGENERATED CODE
//
// Do not make changes directly to this (.cs) file.
// Change LD_rr_nn.Tests.tt instead.

using NUnit.Framework;
using Ploeh.AutoFixture;

namespace Konamiman.Z80dotNet.Tests.InstructionsExecution
{
    public partial class Z80InstructionsExecutor
    {
        [Test]
        public void LD_BC_nn_works()
        {
            var oldValue = Fixture.Create<short>();
            var newValue = Fixture.Create<short>();

            Registers.Main.BC = oldValue;

            SetNextFetches(newValue.GetLowByte(), newValue.GetHighByte());
            Sut.Execute(0x01);

            Assert.AreEqual(newValue, Registers.Main.BC);
        }

        [Test]
        public void LD_DE_nn_works()
        {
            var oldValue = Fixture.Create<short>();
            var newValue = Fixture.Create<short>();

            Registers.Main.DE = oldValue;

            SetNextFetches(newValue.GetLowByte(), newValue.GetHighByte());
            Sut.Execute(0x11);

            Assert.AreEqual(newValue, Registers.Main.DE);
        }

        [Test]
        public void LD_HL_nn_works()
        {
            var oldValue = Fixture.Create<short>();
            var newValue = Fixture.Create<short>();

            Registers.Main.HL = oldValue;

            SetNextFetches(newValue.GetLowByte(), newValue.GetHighByte());
            Sut.Execute(0x21);

            Assert.AreEqual(newValue, Registers.Main.HL);
        }

        [Test]
        public void LD_SP_nn_works()
        {
            var oldValue = Fixture.Create<short>();
            var newValue = Fixture.Create<short>();

            Registers.SP = oldValue;

            SetNextFetches(newValue.GetLowByte(), newValue.GetHighByte());
            Sut.Execute(0x31);

            Assert.AreEqual(newValue, Registers.SP);
        }

    }
}