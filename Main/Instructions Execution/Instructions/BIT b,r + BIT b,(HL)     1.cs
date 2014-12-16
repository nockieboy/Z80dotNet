﻿
// AUTOGENERATED CODE
//
// Do not make changes directly to this (.cs) file.
// Change "BIT b,r + BIT b,(HL)     .tt" instead.

namespace Konamiman.Z80dotNet
{
    public partial class Z80InstructionExecutor
    {
		/// <summary>
        /// The BIT 0,A instruction
        /// </summary>
        byte BIT_0_A()
        {
            FetchFinished();

            var oldValue = Registers.A;
	        var bitValue = oldValue.GetBit(0);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 1,A instruction
        /// </summary>
        byte BIT_1_A()
        {
            FetchFinished();

            var oldValue = Registers.A;
	        var bitValue = oldValue.GetBit(1);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 2,A instruction
        /// </summary>
        byte BIT_2_A()
        {
            FetchFinished();

            var oldValue = Registers.A;
	        var bitValue = oldValue.GetBit(2);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 3,A instruction
        /// </summary>
        byte BIT_3_A()
        {
            FetchFinished();

            var oldValue = Registers.A;
	        var bitValue = oldValue.GetBit(3);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 4,A instruction
        /// </summary>
        byte BIT_4_A()
        {
            FetchFinished();

            var oldValue = Registers.A;
	        var bitValue = oldValue.GetBit(4);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 5,A instruction
        /// </summary>
        byte BIT_5_A()
        {
            FetchFinished();

            var oldValue = Registers.A;
	        var bitValue = oldValue.GetBit(5);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 6,A instruction
        /// </summary>
        byte BIT_6_A()
        {
            FetchFinished();

            var oldValue = Registers.A;
	        var bitValue = oldValue.GetBit(6);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 7,A instruction
        /// </summary>
        byte BIT_7_A()
        {
            FetchFinished();

            var oldValue = Registers.A;
	        var bitValue = oldValue.GetBit(7);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = bitValue;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 0,B instruction
        /// </summary>
        byte BIT_0_B()
        {
            FetchFinished();

            var oldValue = Registers.B;
	        var bitValue = oldValue.GetBit(0);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 1,B instruction
        /// </summary>
        byte BIT_1_B()
        {
            FetchFinished();

            var oldValue = Registers.B;
	        var bitValue = oldValue.GetBit(1);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 2,B instruction
        /// </summary>
        byte BIT_2_B()
        {
            FetchFinished();

            var oldValue = Registers.B;
	        var bitValue = oldValue.GetBit(2);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 3,B instruction
        /// </summary>
        byte BIT_3_B()
        {
            FetchFinished();

            var oldValue = Registers.B;
	        var bitValue = oldValue.GetBit(3);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 4,B instruction
        /// </summary>
        byte BIT_4_B()
        {
            FetchFinished();

            var oldValue = Registers.B;
	        var bitValue = oldValue.GetBit(4);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 5,B instruction
        /// </summary>
        byte BIT_5_B()
        {
            FetchFinished();

            var oldValue = Registers.B;
	        var bitValue = oldValue.GetBit(5);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 6,B instruction
        /// </summary>
        byte BIT_6_B()
        {
            FetchFinished();

            var oldValue = Registers.B;
	        var bitValue = oldValue.GetBit(6);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 7,B instruction
        /// </summary>
        byte BIT_7_B()
        {
            FetchFinished();

            var oldValue = Registers.B;
	        var bitValue = oldValue.GetBit(7);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = bitValue;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 0,C instruction
        /// </summary>
        byte BIT_0_C()
        {
            FetchFinished();

            var oldValue = Registers.C;
	        var bitValue = oldValue.GetBit(0);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 1,C instruction
        /// </summary>
        byte BIT_1_C()
        {
            FetchFinished();

            var oldValue = Registers.C;
	        var bitValue = oldValue.GetBit(1);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 2,C instruction
        /// </summary>
        byte BIT_2_C()
        {
            FetchFinished();

            var oldValue = Registers.C;
	        var bitValue = oldValue.GetBit(2);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 3,C instruction
        /// </summary>
        byte BIT_3_C()
        {
            FetchFinished();

            var oldValue = Registers.C;
	        var bitValue = oldValue.GetBit(3);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 4,C instruction
        /// </summary>
        byte BIT_4_C()
        {
            FetchFinished();

            var oldValue = Registers.C;
	        var bitValue = oldValue.GetBit(4);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 5,C instruction
        /// </summary>
        byte BIT_5_C()
        {
            FetchFinished();

            var oldValue = Registers.C;
	        var bitValue = oldValue.GetBit(5);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 6,C instruction
        /// </summary>
        byte BIT_6_C()
        {
            FetchFinished();

            var oldValue = Registers.C;
	        var bitValue = oldValue.GetBit(6);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 7,C instruction
        /// </summary>
        byte BIT_7_C()
        {
            FetchFinished();

            var oldValue = Registers.C;
	        var bitValue = oldValue.GetBit(7);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = bitValue;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 0,D instruction
        /// </summary>
        byte BIT_0_D()
        {
            FetchFinished();

            var oldValue = Registers.D;
	        var bitValue = oldValue.GetBit(0);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 1,D instruction
        /// </summary>
        byte BIT_1_D()
        {
            FetchFinished();

            var oldValue = Registers.D;
	        var bitValue = oldValue.GetBit(1);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 2,D instruction
        /// </summary>
        byte BIT_2_D()
        {
            FetchFinished();

            var oldValue = Registers.D;
	        var bitValue = oldValue.GetBit(2);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 3,D instruction
        /// </summary>
        byte BIT_3_D()
        {
            FetchFinished();

            var oldValue = Registers.D;
	        var bitValue = oldValue.GetBit(3);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 4,D instruction
        /// </summary>
        byte BIT_4_D()
        {
            FetchFinished();

            var oldValue = Registers.D;
	        var bitValue = oldValue.GetBit(4);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 5,D instruction
        /// </summary>
        byte BIT_5_D()
        {
            FetchFinished();

            var oldValue = Registers.D;
	        var bitValue = oldValue.GetBit(5);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 6,D instruction
        /// </summary>
        byte BIT_6_D()
        {
            FetchFinished();

            var oldValue = Registers.D;
	        var bitValue = oldValue.GetBit(6);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 7,D instruction
        /// </summary>
        byte BIT_7_D()
        {
            FetchFinished();

            var oldValue = Registers.D;
	        var bitValue = oldValue.GetBit(7);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = bitValue;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 0,E instruction
        /// </summary>
        byte BIT_0_E()
        {
            FetchFinished();

            var oldValue = Registers.E;
	        var bitValue = oldValue.GetBit(0);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 1,E instruction
        /// </summary>
        byte BIT_1_E()
        {
            FetchFinished();

            var oldValue = Registers.E;
	        var bitValue = oldValue.GetBit(1);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 2,E instruction
        /// </summary>
        byte BIT_2_E()
        {
            FetchFinished();

            var oldValue = Registers.E;
	        var bitValue = oldValue.GetBit(2);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 3,E instruction
        /// </summary>
        byte BIT_3_E()
        {
            FetchFinished();

            var oldValue = Registers.E;
	        var bitValue = oldValue.GetBit(3);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 4,E instruction
        /// </summary>
        byte BIT_4_E()
        {
            FetchFinished();

            var oldValue = Registers.E;
	        var bitValue = oldValue.GetBit(4);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 5,E instruction
        /// </summary>
        byte BIT_5_E()
        {
            FetchFinished();

            var oldValue = Registers.E;
	        var bitValue = oldValue.GetBit(5);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 6,E instruction
        /// </summary>
        byte BIT_6_E()
        {
            FetchFinished();

            var oldValue = Registers.E;
	        var bitValue = oldValue.GetBit(6);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 7,E instruction
        /// </summary>
        byte BIT_7_E()
        {
            FetchFinished();

            var oldValue = Registers.E;
	        var bitValue = oldValue.GetBit(7);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = bitValue;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 0,H instruction
        /// </summary>
        byte BIT_0_H()
        {
            FetchFinished();

            var oldValue = Registers.H;
	        var bitValue = oldValue.GetBit(0);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 1,H instruction
        /// </summary>
        byte BIT_1_H()
        {
            FetchFinished();

            var oldValue = Registers.H;
	        var bitValue = oldValue.GetBit(1);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 2,H instruction
        /// </summary>
        byte BIT_2_H()
        {
            FetchFinished();

            var oldValue = Registers.H;
	        var bitValue = oldValue.GetBit(2);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 3,H instruction
        /// </summary>
        byte BIT_3_H()
        {
            FetchFinished();

            var oldValue = Registers.H;
	        var bitValue = oldValue.GetBit(3);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 4,H instruction
        /// </summary>
        byte BIT_4_H()
        {
            FetchFinished();

            var oldValue = Registers.H;
	        var bitValue = oldValue.GetBit(4);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 5,H instruction
        /// </summary>
        byte BIT_5_H()
        {
            FetchFinished();

            var oldValue = Registers.H;
	        var bitValue = oldValue.GetBit(5);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 6,H instruction
        /// </summary>
        byte BIT_6_H()
        {
            FetchFinished();

            var oldValue = Registers.H;
	        var bitValue = oldValue.GetBit(6);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 7,H instruction
        /// </summary>
        byte BIT_7_H()
        {
            FetchFinished();

            var oldValue = Registers.H;
	        var bitValue = oldValue.GetBit(7);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = bitValue;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 0,L instruction
        /// </summary>
        byte BIT_0_L()
        {
            FetchFinished();

            var oldValue = Registers.L;
	        var bitValue = oldValue.GetBit(0);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 1,L instruction
        /// </summary>
        byte BIT_1_L()
        {
            FetchFinished();

            var oldValue = Registers.L;
	        var bitValue = oldValue.GetBit(1);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 2,L instruction
        /// </summary>
        byte BIT_2_L()
        {
            FetchFinished();

            var oldValue = Registers.L;
	        var bitValue = oldValue.GetBit(2);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 3,L instruction
        /// </summary>
        byte BIT_3_L()
        {
            FetchFinished();

            var oldValue = Registers.L;
	        var bitValue = oldValue.GetBit(3);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 4,L instruction
        /// </summary>
        byte BIT_4_L()
        {
            FetchFinished();

            var oldValue = Registers.L;
	        var bitValue = oldValue.GetBit(4);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 5,L instruction
        /// </summary>
        byte BIT_5_L()
        {
            FetchFinished();

            var oldValue = Registers.L;
	        var bitValue = oldValue.GetBit(5);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 6,L instruction
        /// </summary>
        byte BIT_6_L()
        {
            FetchFinished();

            var oldValue = Registers.L;
	        var bitValue = oldValue.GetBit(6);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 7,L instruction
        /// </summary>
        byte BIT_7_L()
        {
            FetchFinished();

            var oldValue = Registers.L;
	        var bitValue = oldValue.GetBit(7);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = bitValue;
            Registers.HF = 1;
            Registers.NF = 0;

			return 8;
        }

		/// <summary>
        /// The BIT 0,(HL) instruction
        /// </summary>
        byte BIT_0_aHL()
        {
            FetchFinished();

			var address = Registers.HL.ToUShort();
			var oldValue = ProcessorAgent.ReadFromMemory(address);
            var bitValue = oldValue.GetBit(0);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 12;
        }

		/// <summary>
        /// The BIT 1,(HL) instruction
        /// </summary>
        byte BIT_1_aHL()
        {
            FetchFinished();

			var address = Registers.HL.ToUShort();
			var oldValue = ProcessorAgent.ReadFromMemory(address);
            var bitValue = oldValue.GetBit(1);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 12;
        }

		/// <summary>
        /// The BIT 2,(HL) instruction
        /// </summary>
        byte BIT_2_aHL()
        {
            FetchFinished();

			var address = Registers.HL.ToUShort();
			var oldValue = ProcessorAgent.ReadFromMemory(address);
            var bitValue = oldValue.GetBit(2);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 12;
        }

		/// <summary>
        /// The BIT 3,(HL) instruction
        /// </summary>
        byte BIT_3_aHL()
        {
            FetchFinished();

			var address = Registers.HL.ToUShort();
			var oldValue = ProcessorAgent.ReadFromMemory(address);
            var bitValue = oldValue.GetBit(3);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 12;
        }

		/// <summary>
        /// The BIT 4,(HL) instruction
        /// </summary>
        byte BIT_4_aHL()
        {
            FetchFinished();

			var address = Registers.HL.ToUShort();
			var oldValue = ProcessorAgent.ReadFromMemory(address);
            var bitValue = oldValue.GetBit(4);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 12;
        }

		/// <summary>
        /// The BIT 5,(HL) instruction
        /// </summary>
        byte BIT_5_aHL()
        {
            FetchFinished();

			var address = Registers.HL.ToUShort();
			var oldValue = ProcessorAgent.ReadFromMemory(address);
            var bitValue = oldValue.GetBit(5);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 12;
        }

		/// <summary>
        /// The BIT 6,(HL) instruction
        /// </summary>
        byte BIT_6_aHL()
        {
            FetchFinished();

			var address = Registers.HL.ToUShort();
			var oldValue = ProcessorAgent.ReadFromMemory(address);
            var bitValue = oldValue.GetBit(6);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = 0;
            Registers.HF = 1;
            Registers.NF = 0;

			return 12;
        }

		/// <summary>
        /// The BIT 7,(HL) instruction
        /// </summary>
        byte BIT_7_aHL()
        {
            FetchFinished();

			var address = Registers.HL.ToUShort();
			var oldValue = ProcessorAgent.ReadFromMemory(address);
            var bitValue = oldValue.GetBit(7);
            Registers.ZF = Registers.PF = ~bitValue;
            Registers.SF = bitValue;
            Registers.HF = 1;
            Registers.NF = 0;

			return 12;
        }

	}
}
