﻿using System;

namespace Konamiman.Z80dotNet
{
    public partial class Z80InstructionExecutor
    {
        private Func<byte>[] SingleByte_InstructionExecutors;

        private void Initialize_SingleByte_InstructionsTable()
        {
            SingleByte_InstructionExecutors = new Func<byte>[]
            {
                NOP,    //00
                LD_BC_nn,    //01
                LD_aBC_A,    //02
                INC_BC,    //03
                INC_B,    //04
                DEC_B,    //05
                LD_B_n,    //06
                RLCA,    //7
                EX_AF_AF,    //08
                ADD_HL_BC,    //09
                LD_A_aBC,    //0A
                DEC_BC,    //0B
                INC_C,    //0C
                DEC_C,    //0D
                LD_C_n,    //0E
                RRCA,    //0F
                DJNZ_d,    //10
                LD_DE_nn,    //11
                LD_aDE_A,    //12
                INC_DE,    //13
                INC_D,    //14
                DEC_D,    //15
                LD_D_n,    //16
                RLA,    //17
                JR_d,    //18
                ADD_HL_DE,    //19
                LD_A_aDE,    //1A
                DEC_DE,    //1B
                INC_E,    //1C
                DEC_E,    //1D
                LD_E_n,    //1E
                RRA,    //1F
                JR_NZ_d,    //20
                LD_HL_nn,    //21
                LD_aa_HL,    //22
                INC_HL,    //23
                INC_H,    //24
                DEC_H,    //25
                LD_H_n,    //26
                DAA,    //27
                JR_Z_d,    //28
                ADD_HL_HL,    //29
                LD_HL_aa,    //2A
                DEC_HL,    //2B
                INC_L,    //2C
                DEC_L,    //2D
                LD_L_n,    //2E
                CPL,    //2F
                JR_NC_d,    //30
                LD_SP_nn,    //31
                LD_aa_A,    //32
                INC_SP,    //33
                INC_aHL,    //34
                DEC_aHL,    //35
                LD_aHL_n,    //36
                SCF,    //37
                JR_C_d,    //38
                ADD_HL_SP,    //39
                LD_A_aa,    //3A
                DEC_SP,    //3B
                INC_A,    //3C
                DEC_A,    //3D
                LD_A_n,    //3E
                CCF,    //3F
                LD_B_B,    //40
                LD_B_C,    //41
                LD_B_D,    //42
                LD_B_E,    //43
                LD_B_H,    //44
                LD_B_L,    //45
                LD_B_aHL,    //46
                LD_B_A,    //47
                LD_C_B,    //48
                LD_C_C,    //49
                LD_C_D,    //4A
                LD_C_E,    //4B
                LD_C_H,    //4C
                LD_C_L,    //4D
                LD_C_aHL,    //4E
                LD_C_A,    //4F
                LD_D_B,    //50
                LD_D_C,    //51
                LD_D_D,    //52
                LD_D_E,    //53
                LD_D_H,    //54
                LD_D_L,    //55
                LD_D_aHL,    //56
                LD_D_A,    //57
                LD_E_B,    //58
                LD_E_C,    //59
                LD_E_D,    //5A
                LD_E_E,    //5B
                LD_E_H,    //5C
                LD_E_L,    //5D
                LD_E_aHL,    //5E
                LD_E_A,    //5F
                LD_H_B,    //60
                LD_H_C,    //61
                LD_H_D,    //62
                LD_H_E,    //63
                LD_H_H,    //64
                LD_H_L,    //65
                LD_H_aHL,    //66
                LD_H_A,    //67
                LD_L_B,    //68
                LD_L_C,    //69
                LD_L_D,    //6A
                LD_L_E,    //6B
                LD_L_H,    //6C
                LD_L_L,    //6D
                LD_L_aHL,    //6E
                LD_L_A,    //6F
                LD_aHL_B,    //70
                LD_aHL_C,    //71
                LD_aHL_D,    //72
                LD_aHL_E,    //73
                LD_aHL_H,    //74
                LD_aHL_L,    //75
                HALT,    //76
                LD_aHL_A,    //77
                LD_A_B,    //78
                LD_A_C,    //79
                LD_A_D,    //7A
                LD_A_E,    //7B
                LD_A_H,    //7C
                LD_A_L,    //7D
                LD_A_aHL,    //7E
                LD_A_A,    //7F
                ADD_A_B,    //80
                ADD_A_C,    //81
                ADD_A_D,    //82
                ADD_A_E,    //83
                ADD_A_H,    //84
                ADD_A_L,    //85
                ADD_A_aHL,    //86
                ADD_A_A,    //87
                ADC_A_B,    //88
                ADC_A_C,    //89
                ADC_A_D,    //8A
                ADC_A_E,    //8B
                ADC_A_H,    //8C
                ADC_A_L,    //8D
                ADC_A_aHL,    //8E
                ADC_A_A,    //8F
                SUB_B,    //90
                SUB_C,    //91
                SUB_D,    //92
                SUB_E,    //93
                SUB_H,    //94
                SUB_L,    //95
                SUB_aHL,    //96
                SUB_A,    //97
                SBC_A_B,    //98
                SBC_A_C,    //99
                SBC_A_D,    //9A
                SBC_A_E,    //9B
                SBC_A_H,    //9C
                SBC_A_L,    //9D
                SBC_A_aHL,    //9E
                SBC_A_A,    //9F
                AND_B,    //A0
                AND_C,    //A1
                AND_D,    //A2
                AND_E,    //A3
                AND_H,    //A4
                AND_L,    //A5
                AND_aHL,    //A6
                AND_A,    //A7
                XOR_B,    //A8
                XOR_C,    //A9
                XOR_D,    //AA
                XOR_E,    //AB
                XOR_H,    //AC
                XOR_L,    //AD
                XOR_aHL,    //AE
                XOR_A,    //AF
                OR_B,    //B0
                OR_C,    //B1
                OR_D,    //B2
                OR_E,    //B3
                OR_H,    //B4
                OR_L,    //B5
                OR_aHL,    //B6
                OR_A,    //B7
                CP_B,    //B8
                CP_C,    //B9
                CP_D,    //BA
                CP_E,    //BB
                CP_H,    //BC
                CP_L,    //BD
                CP_aHL,    //BE
                CP_A,    //BF
                RET_NZ,    //C0
                POP_BC,    //C1
                JP_NZ_nn,    //C2
                JP_nn,    //C3
                CALL_NZ_nn,    //C4
                PUSH_BC,    //C5
                ADD_A_n,    //C6
                RST_00,    //C7
                RET_Z,    //C8
                RET,    //C9
                JP_Z_nn,    //CA
                null,    //CB
                CALL_Z_nn,    //CC
                CALL_nn,    //CD
                ADC_A_n,    //CE
                RST_08,    //CF
                RET_NC,    //D0
                POP_DE,    //D1
                JP_NC_nn,    //D2
                OUT_n_A,    //D3
                CALL_NC_nn,    //D4
                PUSH_DE,    //D5
                SUB_n,    //D6
                RST_10,    //D7
                RET_C,    //D8
                EXX,    //D9
                JP_C_nn,    //DA
                IN_A_n,    //DB
                CALL_C_nn,    //DC
                null,    //DD
                SBC_A_n,    //DE
                RST_18,    //DF
                RET_PO,    //E0
                POP_HL,    //E1
                JP_PO_nn,    //E2
                EX_aSP_HL,    //E3
                CALL_PO_nn,    //E4
                PUSH_HL,    //E5
                AND_n,    //E6
                RST_20,    //E7
                RET_PE,    //E8
                JP_aHL,    //E9
                JP_PE_nn,    //EA
                EX_DE_HL,    //EB
                CALL_PE_nn,    //EC
                null,    //ED
                XOR_n,    //EE
                RST_28,    //EF
                RET_P,    //F0
                POP_AF,    //F1
                JP_P_nn,    //F2
                DI,    //F3
                CALL_P_nn,    //F4
                PUSH_AF,    //F5
                OR_n,    //F6
                RST_30,    //F7
                RET_M,    //F8
                LD_SP_HL,    //F9
                JP_M_nn,    //FA
                EI,    //FB
                CALL_M_nn,    //FC
                null,    //FD
                CP_n,    //FE
                RST_38    //FF
            };
        }

        //TODO: Move instructions to their own files and include them in the table when they are implemented.

        /// <summary>
        /// The PUSH BC instruction.
        /// </summary>
        byte PUSH_BC()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The RST 00 instruction.
        /// </summary>
        byte RST_00()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The RST 08 instruction.
        /// </summary>
        byte RST_08()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The OUT (n),A instruction.
        /// </summary>
        byte OUT_n_A()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The PUSH DE instruction.
        /// </summary>
        byte PUSH_DE()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The RST 10 instruction.
        /// </summary>
        byte RST_10()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The EXX instruction.
        /// </summary>
        byte EXX()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The IN A,(n) instruction.
        /// </summary>
        byte IN_A_n()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The RST 18 instruction.
        /// </summary>
        byte RST_18()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The EX (SP),HL instruction.
        /// </summary>
        byte EX_aSP_HL()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The PUSH HL instruction.
        /// </summary>
        byte PUSH_HL()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The RST 20 instruction.
        /// </summary>
        byte RST_20()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The JP (HL) instruction.
        /// </summary>
        byte JP_aHL()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The EX DE,HL instruction.
        /// </summary>
        byte EX_DE_HL()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The RST 28 instruction.
        /// </summary>
        byte RST_28()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The DI instruction.
        /// </summary>
        byte DI()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The PUSH AF instruction.
        /// </summary>
        byte PUSH_AF()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The RST 30 instruction.
        /// </summary>
        byte RST_30()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The LD SP,HL instruction.
        /// </summary>
        byte LD_SP_HL()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The EI instruction.
        /// </summary>
        byte EI()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The RST 38 instruction.
        /// </summary>
        byte RST_38()
        {
            throw new NotImplementedException();
        }
    }
}
