﻿using System;

namespace KSharp.NChronicle.Core.Abstractions
{

    /// <summary>
    /// A container for primary recording methods.
    /// </summary>
    public interface IChronicle
    {

        IChronicleScope CurrentScope { get; }

        IChronicleScope ScopeIn();

        void ScopeIn(IChronicleScope scope);

        void ScopeOut();

        /// <summary>
        /// Record a <see cref="Model.ChronicleLevel.Emergency"/> level message with the specified <paramref name="tags"/>.
        /// </summary>
        /// <param name="message">Message to be recorded.</param>
        /// <param name="tags">Tags to be appended to this record.</param>
        void Emergency(string message, params string[] tags);

        /// <summary>
        /// Record a <see cref="Model.ChronicleLevel.Emergency"/> level message and <see cref="Exception"/> with the specified <paramref name="tags"/>.
        /// </summary>
        /// <param name="message">Message to be recorded.</param>
        /// <param name="exception"><see cref="Exception"/> to be recorded.</param>
        /// <param name="tags">Tags to be appended to this record.</param>
        void Emergency(string message, Exception exception, params string[] tags);

        /// <summary>
        /// Record a <see cref="Model.ChronicleLevel.Emergency"/> level <see cref="Exception"/> with the specified <paramref name="tags"/>.
        /// </summary>
        /// <param name="exception"><see cref="Exception"/> to be recorded.</param>
        /// <param name="tags">Tags to be appended to this record.</param>
        void Emergency(Exception exception, params string[] tags);

        /// <summary>
        /// Record a <see cref="Model.ChronicleLevel.Fatal"/> level message with the specified <paramref name="tags"/>.
        /// </summary>
        /// <param name="message">Message to be recorded.</param>
        /// <param name="tags">Tags to be appended to this record.</param>
        void Fatal(string message, params string[] tags);

        /// <summary>
        /// Record a <see cref="Model.ChronicleLevel.Fatal"/> level message and <see cref="Exception"/> with the specified <paramref name="tags"/>.
        /// </summary>
        /// <param name="message">Message to be recorded.</param>
        /// <param name="exception"><see cref="Exception"/> to be recorded.</param>
        /// <param name="tags">Tags to be appended to this record.</param>
        void Fatal(string message, Exception exception, params string[] tags);

        /// <summary>
        /// Record a <see cref="Model.ChronicleLevel.Fatal"/> level <see cref="Exception"/> with the specified <paramref name="tags"/>.
        /// </summary>
        /// <param name="exception"><see cref="Exception"/> to be recorded.</param>
        /// <param name="tags">Tags to be appended to this record.</param>
        void Fatal(Exception exception, params string[] tags);

        /// <summary>
        /// Record a <see cref="Model.ChronicleLevel.Critical"/> level message with the specified <paramref name="tags"/>.
        /// </summary>
        /// <param name="message">Message to be recorded.</param>
        /// <param name="tags">Tags to be appended to this record.</param>
        void Critical(string message, params string[] tags);

        /// <summary>
        /// Record a <see cref="Model.ChronicleLevel.Critical"/> level message and <see cref="Exception"/> with the specified <paramref name="tags"/>.
        /// </summary>
        /// <param name="message">Message to be recorded.</param>
        /// <param name="exception"><see cref="Exception"/> to be recorded.</param>
        /// <param name="tags">Tags to be appended to this record.</param>
        void Critical(string message, Exception exception, params string[] tags);

        /// <summary>
        /// Record a <see cref="Model.ChronicleLevel.Critical"/> level <see cref="Exception"/> with the specified <paramref name="tags"/>.
        /// </summary>
        /// <param name="exception"><see cref="Exception"/> to be recorded.</param>
        /// <param name="tags">Tags to be appended to this record.</param>
        void Critical(Exception exception, params string[] tags);

        /// <summary>
        /// Record a <see cref="Model.ChronicleLevel.Warning"/> level message with the specified <paramref name="tags"/>.
        /// </summary>
        /// <param name="message">Message to be recorded.</param>
        /// <param name="tags">Tags to be appended to this record.</param>
        void Warning(string message, params string[] tags);

        /// <summary>
        /// Record a <see cref="Model.ChronicleLevel.Warning"/> level message and <see cref="Exception"/> with the specified <paramref name="tags"/>.
        /// </summary>
        /// <param name="message">Message to be recorded.</param>
        /// <param name="exception"><see cref="Exception"/> to be recorded.</param>
        /// <param name="tags">Tags to be appended to this record.</param>
        void Warning(string message, Exception exception, params string[] tags);

        /// <summary>
        /// Record a <see cref="Model.ChronicleLevel.Warning"/> level <see cref="Exception"/> with specified <paramref name="tags"/>.
        /// </summary>
        /// <param name="exception"><see cref="Exception"/> to be recorded.</param>
        /// <param name="tags">Tags to be appended to this record.</param>
        void Warning(Exception exception, params string[] tags);

        /// <summary>
        /// Record a <see cref="Model.ChronicleLevel.Debug"/> level message with the specified <paramref name="tags"/>.
        /// </summary>
        /// <param name="message">Message to be recorded.</param>
        /// <param name="tags">Tags to be appended to this record.</param>
        void Debug(string message, params string[] tags);

        /// <summary>
        /// Record a <see cref="Model.ChronicleLevel.Debug"/> level message and <see cref="Exception"/> with the specified <paramref name="tags"/>.
        /// </summary>
        /// <param name="message">Message to be recorded.</param>
        /// <param name="exception"><see cref="Exception"/> to be recorded.</param>
        /// <param name="tags">Tags to be appended to this record.</param>
        void Debug(string message, Exception exception, params string[] tags);

        /// <summary>
        /// Record a <see cref="Model.ChronicleLevel.Debug"/> level exception with the specified <paramref name="tags"/>.
        /// </summary>
        /// <param name="exception"><see cref="Exception"/> to be recorded.</param>
        /// <param name="tags">Tags to be appended to this record.</param>
        void Debug(Exception exception, params string[] tags);

        /// <summary>
        /// Record a <see cref="Model.ChronicleLevel.Success"/> level message with the specified <paramref name="tags"/>.
        /// </summary>
        /// <param name="message">Message to be recorded.</param>
        /// <param name="tags">Tags to be appended to this record.</param>
        void Success(string message, params string[] tags);

        /// <summary>
        /// Record a <see cref="Model.ChronicleLevel.Success"/> level message and <see cref="Exception"/> with the specified <paramref name="tags"/>.
        /// </summary>
        /// <param name="message">Message to be recorded.</param>
        /// <param name="exception"><see cref="Exception"/> to be recorded.</param>
        /// <param name="tags">Tags to be appended to this record.</param>
        void Success(string message, Exception exception, params string[] tags);

        /// <summary>
        /// Record a <see cref="Model.ChronicleLevel.Success"/> level <see cref="Exception"/> with the specified <paramref name="tags"/>.
        /// </summary>
        /// <param name="exception"><see cref="Exception"/> to be recorded.</param>
        /// <param name="tags">Tags to be appended to this record.</param>
        void Success(Exception exception, params string[] tags);

        /// <summary>
        /// Record a <see cref="Model.ChronicleLevel.Info"/> level message with the specified <paramref name="tags"/>.
        /// </summary>
        /// <param name="message">Message to be recorded.</param>
        /// <param name="tags">Tags to be appended to this record.</param>
        void Info(string message, params string[] tags);

        /// <summary>
        /// Record a <see cref="Model.ChronicleLevel.Info"/> level message and <see cref="Exception"/> with the specified <paramref name="tags"/>.
        /// </summary>
        /// <param name="message">Message to be recorded.</param>
        /// <param name="exception"><see cref="Exception"/> to be recorded.</param>
        /// <param name="tags">Tags to be appended to this record.</param>
        void Info(string message, Exception exception, params string[] tags);

        /// <summary>
        /// Record a <see cref="Model.ChronicleLevel.Info"/> level <see cref="Exception"/> with the specified <paramref name="tags"/>.
        /// </summary>
        /// <param name="exception"><see cref="Exception"/> to be recorded.</param>
        /// <param name="tags">Tags to be appended to this record.</param>
        void Info(Exception exception, params string[] tags);

        /// <summary>
        /// Record a <see cref="Model.ChronicleLevel.Trace"/> level message with the specified <paramref name="tags"/>.
        /// </summary>
        /// <param name="message">Message to be recorded.</param>
        /// <param name="tags">Tags to be appended to this record.</param>
        void Trace(string message, params string[] tags);

        /// <summary>
        /// Record a <see cref="Model.ChronicleLevel.Trace"/> level message and <see cref="Exception"/> with the specified <paramref name="tags"/>.
        /// </summary>
        /// <param name="message">Message to be recorded.</param>
        /// <param name="exception"><see cref="Exception"/> to be recorded.</param>
        /// <param name="tags">Tags to be appended to this record.</param>
        void Trace(string message, Exception exception, params string[] tags);

        /// <summary>
        /// Record a <see cref="Model.ChronicleLevel.Trace"/> level <see cref="Exception"/> with the specified <paramref name="tags"/>.
        /// </summary>
        /// <param name="exception"><see cref="Exception"/> to be recorded.</param>
        /// <param name="tags">Tags to be appended to this record.</param>
        void Trace(Exception exception, params string[] tags);

    }

}
