// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace MgmtListMethods.Models
{
    /// <summary> The SharedToValues. </summary>
    public readonly partial struct SharedToValues : IEquatable<SharedToValues>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="SharedToValues"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SharedToValues(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TenantValue = "tenant";

        /// <summary> tenant. </summary>
        public static SharedToValues Tenant { get; } = new SharedToValues(TenantValue);
        /// <summary> Determines if two <see cref="SharedToValues"/> values are the same. </summary>
        public static bool operator ==(SharedToValues left, SharedToValues right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SharedToValues"/> values are not the same. </summary>
        public static bool operator !=(SharedToValues left, SharedToValues right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SharedToValues"/>. </summary>
        public static implicit operator SharedToValues(string value) => new SharedToValues(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SharedToValues other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SharedToValues other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
