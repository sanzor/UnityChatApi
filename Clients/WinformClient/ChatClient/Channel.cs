﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace WinformClient {
    public class Channel : IEquatable<Channel> {
        public readonly string Name;
        public DateTime SubscribedAt { get; }
        public Channel(string name) {
            this.Name = name;
            this.SubscribedAt = DateTime.UtcNow;
        }

        public bool Equals([AllowNull] Channel other) {
            return other.Name == this.Name && this.SubscribedAt == other.SubscribedAt;
        }
        public override bool Equals(object obj) {
            if(!(obj is Channel ch)) {
                return false;
            }
            return this.Equals(ch);
        }
        public override int GetHashCode() {
            return this.Name.GetHashCode() ^ 7;
        }


    }
}
