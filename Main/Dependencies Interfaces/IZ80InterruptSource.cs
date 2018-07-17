﻿using System;

namespace Konamiman.Z80dotNet
{
    /// <summary>
    /// Represents a source of interrupts for a Z80 processor.
    /// </summary>
    public interface IZ80InterruptSource
    {
        /// <summary>
        /// Signals a NMI interrupt pulse generated by the source.
        /// </summary>
        event EventHandler NmiInterruptPulse;

        /// <summary>
        /// Gets the current state of the INT line as set by the source.
        /// This is a logical state: a value of <i>True</i> means that an interrupt is requested.
        /// </summary>
        bool IntLineIsActive { get; set; }

        /// <summary>
        /// Gets the value put on the data bus by the source. This is used by the processor in interrupt mode 2 only.
        /// </summary>
        byte? ValueOnDataBus { get; }
    }
}
