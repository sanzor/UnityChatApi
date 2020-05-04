﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PubSubSharp.Models;
using StackExchange.Redis;

namespace PubSubSharp.DataAccess {
    public class RedisAdapter {
        public static User Adapt(HashEntry[] entries) {
            var user = new User {
                Id = entries.First(x => x.Name == "id").Value,
            };
            return user;
        }
        public static HashEntry[] Adapt(User user) {
            List<HashEntry> entries = new List<HashEntry>();
            entries.Add(new HashEntry("id", user.Id));
            return entries.ToArray();
        }
    }
}