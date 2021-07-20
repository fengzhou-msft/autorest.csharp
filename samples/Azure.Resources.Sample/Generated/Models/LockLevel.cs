// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Resources.Sample
{
    /// <summary> The level of the lock. Possible values are: NotSpecified, CanNotDelete, ReadOnly. CanNotDelete means authorized users are able to read and modify the resources, but not delete. ReadOnly means authorized users can only read from a resource, but they can&apos;t modify or delete it. </summary>
    public readonly partial struct LockLevel : IEquatable<LockLevel>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="LockLevel"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LockLevel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotSpecifiedValue = "NotSpecified";
        private const string CanNotDeleteValue = "CanNotDelete";
        private const string ReadOnlyValue = "ReadOnly";

        /// <summary> NotSpecified. </summary>
        public static LockLevel NotSpecified { get; } = new LockLevel(NotSpecifiedValue);
        /// <summary> CanNotDelete. </summary>
        public static LockLevel CanNotDelete { get; } = new LockLevel(CanNotDeleteValue);
        /// <summary> ReadOnly. </summary>
        public static LockLevel ReadOnly { get; } = new LockLevel(ReadOnlyValue);
        /// <summary> Determines if two <see cref="LockLevel"/> values are the same. </summary>
        public static bool operator ==(LockLevel left, LockLevel right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LockLevel"/> values are not the same. </summary>
        public static bool operator !=(LockLevel left, LockLevel right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="LockLevel"/>. </summary>
        public static implicit operator LockLevel(string value) => new LockLevel(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LockLevel other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LockLevel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
