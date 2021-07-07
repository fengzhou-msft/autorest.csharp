// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Resources
{
    /// <summary> The JIT request scheduling type. </summary>
    public readonly partial struct JitSchedulingType : IEquatable<JitSchedulingType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="JitSchedulingType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public JitSchedulingType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotSpecifiedValue = "NotSpecified";
        private const string OnceValue = "Once";
        private const string RecurringValue = "Recurring";

        /// <summary> NotSpecified. </summary>
        public static JitSchedulingType NotSpecified { get; } = new JitSchedulingType(NotSpecifiedValue);
        /// <summary> Once. </summary>
        public static JitSchedulingType Once { get; } = new JitSchedulingType(OnceValue);
        /// <summary> Recurring. </summary>
        public static JitSchedulingType Recurring { get; } = new JitSchedulingType(RecurringValue);
        /// <summary> Determines if two <see cref="JitSchedulingType"/> values are the same. </summary>
        public static bool operator ==(JitSchedulingType left, JitSchedulingType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="JitSchedulingType"/> values are not the same. </summary>
        public static bool operator !=(JitSchedulingType left, JitSchedulingType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="JitSchedulingType"/>. </summary>
        public static implicit operator JitSchedulingType(string value) => new JitSchedulingType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is JitSchedulingType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(JitSchedulingType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
