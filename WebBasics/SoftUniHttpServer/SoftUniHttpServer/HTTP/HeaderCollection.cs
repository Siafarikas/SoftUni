﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniHttpServer.HTTP
{
    public class HeaderCollection : IEnumerable<Header>
    {
        private readonly Dictionary<string, Header> headers;

        public HeaderCollection() => this.headers = new Dictionary<string, Header>();

        public string this[string name]
            => this.headers[name].Value;

        public int Count => headers.Count;

        public bool Contains(string name)
            => headers.ContainsKey(name);

        public void Add(string name, string value)
            => this.headers[name] = new Header(name, value);

        public IEnumerator<Header> GetEnumerator() => this.headers.Values.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
